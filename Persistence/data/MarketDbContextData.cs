using Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Persistence.data
{
    public class MarketDbContextData
    {
        public static async Task LoadDataAsync(MarketDbContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Brands.Any())
                {
                    var data = File.ReadAllText("../Persistence/loadData/marca.json");
                    var brands = JsonSerializer.Deserialize<List<Brand>>(data);

                    foreach (var brand in brands)   
                    {
                        context.Brands.Add(brand);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Categories.Any())
                {
                    var data = File.ReadAllText("../Persistence/loadData/categoria.json");
                    var categories = JsonSerializer.Deserialize<List<Category>>(data);

                    foreach (var category in categories)
                    {
                        context.Categories.Add(category);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Products.Any())
                {
                    var data = File.ReadAllText("../Persistence/loadData/producto.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(data);

                    foreach (var product in products)
                    {
                        context.Products.Add(product);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<MarketDbContextData>();
                logger.LogError(e.Message);
            }
        }
    }
}
