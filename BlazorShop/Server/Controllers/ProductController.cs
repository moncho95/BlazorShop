using BlazorShop.Server.Services.ProductService;
using BlazorShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.Server.Controllers
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
		public async Task<ActionResult<List<Product>>> GetAllProductsAsync()
		{
			return Ok(await _productService.GetAllProducts());
		}
		[HttpGet("Category/{categoryUrl}")]
		public async Task<ActionResult<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
		{
			return Ok(await _productService.GetProductsByCategory(categoryUrl));
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<Product>> GetProduct(int id)
		{
			return Ok(await _productService.GetProduct(id));
		}
		[HttpGet("Search/{searchText}")]
		public async Task<List<Product>> SearchProduct(string searchText)
		{
			return await _productService.SearchProduct(searchText);
		}
		[HttpGet("SearchCategory/{searchText}")]
		public async Task<List<Product>> SearchProductByCategory(string searchText)
		{
			return await _productService.SearchProductByCategory(searchText);
		}
    }
}
