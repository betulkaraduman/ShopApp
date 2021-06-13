using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShopApp.webui.ViewModels;
using shopApp.entity;

namespace ShopApp.webui.Controllers
{
    //localhost:5000/home
    public class ProductController : Controller
    {
        //localhost:5000/product/index
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult List(int? id, string q)
        {

            //     var products = ProductRepository.products;

            //     if (id != null)
            //     {
            //         products = products.Where(p => p.CategoryId == id).ToList();
            //     }
            //     if (!string.IsNullOrEmpty(q))
            //     {
            //         products = products.Where(p => p.Name.ToLower().Contains(q.ToLower())).ToList();
            //     }
            //     var categories = new List<Category>(){
            //        new Category{Id=1,Name="Phone",Description="Tecnology"},
            //        new Category{Id=2,Name="XX",Description="Home"},
            //        new Category{Id=3,Name="YY",Description="Life"},
            //        new Category{Id=4,Name="Computer",Description="Tecnology"},
            //    };
            //     var Category = new Category { Name = "Phone", Description = "Tecnology" };
            //     var productViewModel = new ProductViewModel()
            //     {
            //         category = categories,
            //         product = products
            //     };

            //     return View(productViewModel);

            return View();
        }

        //localhost:5000/product/about
        public IActionResult ListDetail(int id)
        {
            // return View(ProductRepository.getById(id));

            return View();
        }

        public IActionResult Create()
        {

            // ViewBag.categories = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(CategoryRepository.products, "Id", "Name");
            // return View(new Product());

            return View();
        }

        public IActionResult update(int id)
        {
            // ViewBag.categories = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(CategoryRepository.products, "Id", "Name");

            // return View(ProductRepository.getById(id));

            return View();
        }
        [HttpPost]
        public IActionResult update(Product p)
        {
            // ViewBag.categories = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(CategoryRepository.products, "Id", "Name");

            // ProductRepository.EditProduct(p);
            // return RedirectToAction("list");

            return View();
        }
        [HttpPost]
        public IActionResult Create(Product prd)
        {

            // ViewBag.categories = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(CategoryRepository.products, "Id", "Name");
            // if (ModelState.IsValid)
            // {

            //     ProductRepository.AddProduct(prd);
            //     return RedirectToAction("list");
            // }
            // return View(prd);

            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            // ProductRepository.deleteProduct(id);
            // return Redirect("List");

            return View();
        }
    }
}
