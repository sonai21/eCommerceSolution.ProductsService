using eCommerceSolution.ProductsService.Models.DTOs;
using eCommerceSolution.ProductsService.Models.Entities;
using eCommerceSolution.ProductsService.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceSolution.ProductsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;
        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }
        [HttpGet]   
        public IActionResult Get()
        {
            return Ok("Works");
        }

        [HttpPost("addProduct")]
        public async Task<IActionResult> AddProduct(ProductAddRequest request)
        {
            var result = await _productsService.AddProduct(request);
            return Created("Product successfully added.", result);
        }

        [HttpGet("getAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _productsService.GetAllProducts();
            return Ok(result);
        }

    }
}
