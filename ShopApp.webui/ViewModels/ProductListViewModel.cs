using System;
using System.Collections.Generic;
using shopApp.entity;

namespace ShopApp.webui.ViewModels
{
    public class ProductListViewModel
    {
        public List<Product> product { get; set; }
        public PageInfo PageInfo { get; set; }

    }
    public class PageInfo
    {
        public int ItemPerPage { get; set; }
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentCategory { get; set; }

        public int TotalPage()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemPerPage);
        }
    }
}