using miniapps.Models;

namespace miniapps.Services
{
    public interface IProductDataService
    {
        List<ProductModel> GetAllProducts();
        List<ProductModel> SearchProducts(string searchTerm);
        ProductModel GetProduct(int id);
        int insert(ProductModel product);
        int delete(ProductModel product);
        int update(ProductModel product);

    }
}
