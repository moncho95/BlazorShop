using BlazorShop.Shared;

namespace BlazorShop.Server.Services.CategoryService
{
	public class CategoryService : ICategoryService
	{
        public List<Category> Categories { get; set; }=
		new List<Category>
			{
				new Category { Id = 1, Name ="Movies" , Url="movies", Icon="FilePlay" },
				new Category { Id = 2, Name ="Books" , Url="books", Icon="book" },
				new Category { Id = 3, Name = "Aperature", Url = "aperature", Icon = "aperture" }
			};
	public async Task<List<Category>> GetCategories()
			{
				return Categories;
			}

		public async Task<Category> GetCategoryByUrl(string categoryUrl)
		{
			return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
		}
	}
}
