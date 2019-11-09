using System;
using System.Collections.Generic;

namespace WebApp.DataAccess
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double? Price { get; set; }
        public string Descriptions { get; set; }
        public string ProductCategory { get; set; }
        public bool? IsActive { get; set; }
        public string check { get; set; } 
    }
}
