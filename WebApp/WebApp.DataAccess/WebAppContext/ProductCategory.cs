using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.DataAccess
{
    [Table("ProductCategory")]
    public class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }
        public bool? IsActive { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
