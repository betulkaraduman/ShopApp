using System.Collections.Generic;

namespace shopApp.entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}