using System.Collections.Generic;
using System.Web.Mvc;
using Practical_06.Models;

namespace Practical_06.Controllers
{
    public class ProductDefaultController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = GetProducts();

            return View(products);
        }

        public ActionResult Details(int id)
        {
            List<Product> products = GetProducts();

            Product product = products.Find(p => p.ProductId == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Description = "HP Laptop–Powerful laptop with an Intel Core i5 processor,fast performance,and ample storage.",
                    Price = 55000,
                    Category = "Electronics",
                    Quantity = 10,
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZ9sHs5lsgtdz1ujCpGRvL-VvV3dV_c85Flwj0gSZFXQsvHVbVP1AwT3M&s=10"
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "iPhone 18 Pro Max",
                    Description = "A premium Apple smartphone featuring a powerful A20 Pro chip, advanced camera system, and a large 6.9-inch display.",
                    Price = 150000,
                    Category = "Electronics",
                    Quantity = 15,
                    Image = "https://images.news18.com/ibnlive/uploads/2026/07/iphone-18-pro-max-dark-cherry-colour-2026-07-a3cb605328de47234af80743a3fe4428-e1785468879176-1200x675.png?impolicy=website&width=400&height=225"
                },

                new Product
                {
                    ProductId = 3,
                    ProductName = "Headphones",
                    Description = "Wireless Bluetooth Headphones – Premium headphones with clear sound, deep bass, and comfortable ear cushions.",
                    Price = 2500,
                    Category = "Accessories",
                    Quantity = 20,
                    Image = "https://images.unsplash.com/photo-1546435770-a3e426bf472b?w=400"
                }
            };
        }
    }
}