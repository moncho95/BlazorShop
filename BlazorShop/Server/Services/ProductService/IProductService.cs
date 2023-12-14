using BlazorShop.Shared;

namespace BlazorShop.Server.Services.ProductService
{
	public interface IProductService
	{
		Task<List<Product>> GetAllProducts();
		Task<List<Product>> GetProductsByCategory(string categoryUrl);
		Task<Product> GetProduct(int id);

	}
}
