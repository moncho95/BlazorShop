using BlazorShop.Server.Services.CategoryService;
using BlazorShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
			_categoryService = categoryService;
        }
        [HttpGet]
		public async Task<ActionResult<List<Category>>> GetCategories()
		{
			return Ok(await _categoryService.GetCategories());
		}
	}
}
