using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.DataAccess
{
    [Table("Product")]
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double? Price { get; set; }
        public string Descriptions { get; set; }
        public int? ProductCategoryId { get; set; }
        public bool? IsActive { get; set; }
        public ProductCategory ProductCategory { get; set; }
        [NotMapped] public string abc { get; set; }
    }
}
