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

        public IActionResult ShowDetails(int id)
        {
            ProductModel foundProduct = productsDAO.GetProductById(id);
            return View(foundProduct);
        }

        public IActionResult ProcessEdit(ProductModel product)
        {
            productsDAO.Update(product);
            return View("Index", productsDAO.GetAllProducts());
        }

        public IActionResult Edit(int id)
        {
            ProductModel foundProduct = productsDAO.GetProductById(id);
            return View("ShowEdit", foundProduct);
        }

        public IActionResult ProcessCreate(ProductModel product)
        {
            productsDAO.Insert(product);
            return View("Index", productsDAO.GetAllProducts());
        }

        public IActionResult Create()
        {
            ProductModel newProduct = new ProductModel();
            return View("ShowCreate", newProduct);
        }

        public IActionResult Delete(int id)
        {
            ProductModel foundProduct = productsDAO.GetProductById(id);
            productsDAO.Delete(foundProduct);
            return View("index", productsDAO.GetAllProducts());
        }
    }
}
