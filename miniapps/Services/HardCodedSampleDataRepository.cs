using Bogus;
using miniapps.Models;

namespace miniapps.Services
{
    public class HardCodedSampleDataRepository : IProductDataService
    {
        static List<ProductModel> productsList = new List<ProductModel>();

        public int delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            if(productsList.Count == 0)
            {
                productsList.Add(new ProductModel { Id = 1, Name = "name1", Price = 1.99m, Description = "des1" });
                productsList.Add(new ProductModel { Id = 2, Name = "name2", Price = 2.99m, Description = "des2" });
                productsList.Add(new ProductModel { Id = 3, Name = "name3", Price = 3.99m, Description = "des3" });
                productsList.Add(new ProductModel { Id = 4, Name = "name4", Price = 4.99m, Description = "des4" });
                productsList.Add(new ProductModel { Id = 5, Name = "name5", Price = 5.99m, Description = "des5" });

                for (int i = 0; i < 100; i++)
                {
                    productsList.Add(new Faker<ProductModel>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Int(10000, 100000))
                        .RuleFor(p => p.Description, f => f.Rant.Review())
                        );
                }
            }
            return productsList;
        }

        public ProductModel GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
