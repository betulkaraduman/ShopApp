using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using shopApp.business.Abstract;
using shopApp.entity;
using ShopApp.webui.Models;
using ShopApp.webui.ViewModels;

namespace ShopApp.webui.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _service;
        public ShopController(IProductService service)
        {
            _service = service;

        }
        public IActionResult List(string category, int page = 1)
        {


            const int pageSize=1;
            ViewBag.pageSize=pageSize;
            // if (!string.IsNullOrEmpty(category))
            // {
            //     products = _service.getProductByCategpry(category, page, pageSize);
            // }
            // products = ;
            var productViewModel = new ProductListViewModel()
            {
                PageInfo= new PageInfo(){
                    TotalItems= _service.getCountCategory(category),
                    CurrentPage=page,
                    ItemPerPage=pageSize,
                    CurrentCategory=category
                },
                product = _service.getProductByCategpry(category, page, pageSize)

            };

            return View(productViewModel);
        }
        public IActionResult Details(string productUrl)
        {

            if (string.IsNullOrEmpty(productUrl))
            {

                return NotFound();
            }
            Product product = _service.GetDetails(productUrl);

            if (product == null)
            {
                return NotFound();
            }
            return View(
                new ProductDetailModel
                {
                    Product = product,
                    Categories = product.ProductCategories.Select(t => t.Category).ToList()
                });

        }
    }
}