using Application.Common.Specification;
using Application.Core.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var spec = new ProductWithCategoryAndBrandSpecificator();
            return Ok(await _productService.GetAllWithSpec(spec));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var spec = new ProductWithCategoryAndBrandSpecificator(id);
            return Ok(await _productService.GetByIdWithSpec(spec));
        }
    }
}
