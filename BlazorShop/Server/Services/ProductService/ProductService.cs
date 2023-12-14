using BlazorShop.Server.Services.CategoryService;
using BlazorShop.Shared;

namespace BlazorShop.Server.Services.ProductService
{
	public class ProductService : IProductService
	{
		private readonly ICategoryService _ctegoryService;

		public ProductService(ICategoryService ctegoryService)
        {
			_ctegoryService = ctegoryService;
		}
        public async Task<List<Product>> GetAllProducts()
		{
			return Products;
		}

		public async Task<Product> GetProduct(int id)
		{
			Product product = Products.FirstOrDefault(p => p.Id == id);
			return product;
		}

		public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
		{
			Category category = await _ctegoryService.GetCategoryByUrl(categoryUrl);
			return Products.Where(p => p.CategoryId == category.Id).ToList();
		}

		public List<Product> Products { get; set; } = new List<Product>()
		{
			new Product
				{
					Id = 1,
					CategoryId = 1,
					Title = "Mean Girls",
					Description = "Mean Girls is a 2004 American teen comedy film directed by Mark Waters, written by Tina Fey, and starring Lindsay Lohan, Rachel McAdams, Lacey Chabert, Amanda Seyfried (in her film acting debut), Tim Meadows, Ana Gasteyer, Amy Poehler and Fey.",
					Image = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ac/Mean_Girls_film_poster.png/220px-Mean_Girls_film_poster.png",
					Price = 9.99m,
					OriginalPrice = 19.99m,
				},
				new Product
				{
					Id = 2,
					CategoryId = 1,
					Title = "Arrival",
					Description = "Arrival is a 2016 American science fiction drama film directed by Denis Villeneuve and adapted by Eric Heisserer, who conceived the project as a spec script based on the 1998 short story \"Story of Your Life\" by Ted Chiang.",
					Image = "https://upload.wikimedia.org/wikipedia/en/d/df/Arrival%2C_Movie_Poster.jpg",
					Price = 7.99m,
					OriginalPrice = 19.99m,
				}
				,
				new Product
				{
					Id = 3,
					CategoryId = 1,
					Title = "Senior Year",
					Description = "Senior Year is a 2022 American comedy film directed by Alex Hardcastle in his feature film directorial debut from a screenplay by Andrew Knauer, Arthur Pielli, and Brandon Scott Jones.",
					Image = "https://upload.wikimedia.org/wikipedia/en/thumb/2/2f/SeniorYearNetflixTeaser.jpg/220px-SeniorYearNetflixTeaser.jpg",
					Price = 11.99m,
					OriginalPrice = 29.99m,
				}
				,
				new Product
				{
					Id = 4,
					CategoryId = 2,
					Title = "The Time Machine",
					Description = "The Time Machine is a post-apocalyptic science fiction novella by H. G. Wells, published in 1895. The work is generally credited with the popularization of the concept of time travel by using a vehicle or device to travel purposely and selectively forward or backward through time. ",
					Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0a/The_Time_Machine_%28H._G._Wells%2C_William_Heinemann%2C_1895%29_title_page.jpg/220px-The_Time_Machine_%28H._G._Wells%2C_William_Heinemann%2C_1895%29_title_page.jpg",
					Price = 9.99m,
					OriginalPrice = 19.99m,
				},
				new Product
				{
					Id = 5,
					CategoryId = 2,
					Title = "Sherlock Holmes",
					Description = "Sherlock Holmes is a fictional detective created by British author Arthur Conan Doyle. Referring to himself as a \"consulting detective\" in the stories, Holmes is known for his proficiency with observation, deduction, forensic science and logical reasoning that borders on the fantastic, which he employs when investigating cases for a wide variety of clients, including Scotland Yard.",
					Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Sherlock_Holmes_Portrait_Paget.jpg/220px-Sherlock_Holmes_Portrait_Paget.jpg",
					Price = 11.99m,
					OriginalPrice = 29.99m,
				},
				new Product
				{
					Id = 6,
					CategoryId = 2,
					Title = "The Ballad of Songbirds and Snakes",
					Description = "The Ballad of Songbirds and Snakes is a dystopian action-adventure novel written by American author Suzanne Collins. It is a prequel to the original The Hunger Games trilogy, set 64 years before the events of the first novel.",
					Image = "https://upload.wikimedia.org/wikipedia/en/thumb/f/f1/The_Ballad_of_Songbirds_and_Snakes_%28Suzanne_Collins%29.png/220px-The_Ballad_of_Songbirds_and_Snakes_%28Suzanne_Collins%29.png",
					Price = 11.99m,
					OriginalPrice = 29.99m,
				},
				new Product
				{
					Id = 7,
					CategoryId = 3,
					Title = "Canon T50",
					Description = "The Canon T50, introduced in March 1983 and discontinued in December 1989, was the first in Canon's new T series of 35mm single-lens reflex cameras compatible with Canon's FD lens mount.",
					Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Canon_T50.jpg/300px-Canon_T50.jpg",
					Price = 10.99m,
					OriginalPrice = 19.99m,
				},
				new Product
				{
					Id = 8,
					CategoryId = 3,
					Title = "Canon T80",
					Description = "The Canon T80 is Canon's first autofocus 35mm single-lens reflex camera. It was introduced in April 1985 and discontinued in June 1986 and is part of the T series of FD mount cameras.",
					Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/Canon_T80.jpg/230px-Canon_T80.jpg",
					Price = 11.99m,
					OriginalPrice = 29.99m,
				},
				new Product
				{
					Id = 9,
					CategoryId = 3,
					Title = "Canon T90",
					Description = "The Canon T90, introduced in 1986, was the top of the line in Canon's T series of 35 mm Single-lens reflex (SLR) cameras.",
					Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8a/T90front.jpg/220px-T90front.jpg",
					Price = 11.99m,
					OriginalPrice = 29.99m,
				}
		};
	}
}
