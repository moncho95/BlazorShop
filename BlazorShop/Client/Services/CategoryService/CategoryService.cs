using BlazorShop.Shared;

namespace BlazorShop.Client.Services.CategoryService
{
	public class CategoryService : ICategoryService
	{
		public List<Category> Categories { get; set; } = new List<Category>();

		public void LoadCategories()
		{
			Categories = new List<Category>
			{
				new Category { Id = 1, Name ="Movies" , Url="movies", Icon="FilePlay" },
				new Category { Id = 2, Name ="Books" , Url="books", Icon="book" },
				new Category { Id = 3, Name ="Aperature" , Url="aperature", Icon="aperture" }
			};
		}
	}
}
