using Application.Core.Repositories;
using Application.Core.Services;
using Application.Services;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.ExtensionMethods
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<ICategoryService, CategoryService>();
            return services;
        }
    }
}
