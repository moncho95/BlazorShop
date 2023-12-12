using BlazorShop.Shared;

namespace BlazorShop.Client.Services.CategoryService
{
	public interface ICategoryService
	{
		List<Category> Categories { get; set; }
		void LoadCategories();
	}
}
