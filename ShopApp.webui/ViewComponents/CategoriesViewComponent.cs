
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopApp.business.Abstract;
using shopApp.entity;

namespace ShopApp.webui.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {


        private ICategoryService _categoryService;
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {


            if (RouteData.Values["category"] != null)
            {
                ViewBag.ActiveCategory = RouteData?.Values["category"];
            }
            return View(await _categoryService.GetAll());


        }

    }
}