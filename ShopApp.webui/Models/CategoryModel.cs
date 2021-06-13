using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopApp.entity;

namespace ShopApp.webui.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Please enter Category Name")] 
        [StringLength(100,MinimumLength=12,ErrorMessage="Category Name length must be 10 between 100")]
        public string Name { get; set; }
        [Required(ErrorMessage="Please enter Catgory Url")]
        public string Url { get; set; }
        public List<Product> Products { get; set; }

    }
}