using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopApp.entity;

namespace ShopApp.webui.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        // [Display(Name = "Name", Prompt = "Enter Product Name")]
        // [Required(ErrorMessage="Name is required area")]
        // [StringLength(60,MinimumLength=5,ErrorMessage="Product name length between 5 - 60")]
        public string Name { get; set; }
        // [Required(ErrorMessage="Price is required area")]
        // [Range(1,100000,ErrorMessage="Price must be between 1 - 100000")]
        public double? Price { get; set; }
        [Required(ErrorMessage="Description is required area")]
        [StringLength(100,MinimumLength=5,ErrorMessage="Description length between 5 - 100")]
        public string Description { get; set; }

        [Display(Name = "Image Url")]
        [Required(ErrorMessage="Image Url is required area")]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }

        // [Display(Name = "Product Url")]
        // [Required(ErrorMessage="Product Url is required area")]
        public string ProductUrl { get; set; }
        public List<Category> category { get; set; }
    }
}