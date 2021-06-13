using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using shopApp.business.Abstract;
using shopApp.data.Abstract;
using shopApp.data.Concrete.EfCore;
using shopApp.entity;
using ShopApp.webui.ViewModels;

namespace ShopApp.webui.Controllers
{
    //localhost:5000/home
    public class HomeController : Controller
    {
        //localhost:5000/home/index
        private IProductService _service;
        public HomeController(IProductService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {

            List<Product> products = new List<Product>(){
            new Product(){Name="aaaa",Description="bbbb",Price=123,ImageUrl="1.jpg"}
                        };
            var productViewModel = new ProductListViewModel()
            {
                // product = _service.getHomePageProducts()
                product = products

            };
            Console.WriteLine(productViewModel.product);
            return View(productViewModel);
        }

        public IActionResult Search(string searched)
        {
            Console.WriteLine(searched);
            if (string.IsNullOrEmpty(searched))
            {
                Console.WriteLine("aaaa");
                return Redirect("NotFound");
            }
            var products = _service.getSearchResult(searched);
            var productViewModel = new ProductListViewModel()
            {
                product = products
            };
            return View(productViewModel);
        }
        //localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }

        public async Task<IActionResult> GetProductFromRestApi()
        {
            var products=new List<Product>();
            using (var http = new HttpClient())
            {
                using (var response = await http.GetAsync("http://localhost:4200/api/product/")) {

                  string Apiresponse= await response.Content.ReadAsStringAsync();
                  products=JsonConvert.DeserializeObject<List<Product>>(Apiresponse);

                 }
            }
            return View(products);
        }
        public IActionResult Contact()
        {

            return View("MyView");
        }

    }
}
