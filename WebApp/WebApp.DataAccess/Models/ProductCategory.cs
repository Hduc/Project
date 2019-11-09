using System;
using System.Collections.Generic;

namespace WebApp.DataAccess
{
    public class ProductCategory
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }
        public bool? IsActive { get; set; }
    }
}
