using Bogus;
using Microsoft.AspNetCore.Mvc;
using miniapps.Models;
using miniapps.Services;

namespace miniapps.Controllers
{
    public class ProductController : Controller
    {
        ProductsDAO productsDAO;

        public ProductController()
        {
            productsDAO = new ProductsDAO();
        }

        public IActionResult Index()
        {
            return View(productsDAO.GetAllProducts());
        }

        public IActionResult SearchResults(string searchTerm)
        {
            List<ProductModel> products = productsDAO.SearchProducts(searchTerm);
            return View("index", products);
        }

        public IActionResult SearchForm()
        {
            return View();
        }
    }
}
