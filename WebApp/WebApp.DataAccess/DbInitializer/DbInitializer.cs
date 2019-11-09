using System;
using System.Linq;
namespace WebApp.DataAccess
{
    public static class DbInitializer
    {
        public static void Initialize(DBContext context)
        {
            //context.Database.EnsureCreated();
            // Look for any students.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
            var Products = new Product[]
            {
                new Product{Id=new Guid(),Title="Samsung note 8",Descriptions="",Price=200000000,IsActive=true},
                new Product{Id=new Guid(),Title="Samsung note 9",Descriptions="",Price=220000000,IsActive=true},
                new Product{Id=new Guid(),Title="Samsung note 10",Descriptions="",Price=230000000,IsActive=true},
                new Product{Id=new Guid(),Title="Samsung note 11",Descriptions="",Price=240000000,IsActive=true},
                new Product{Id=new Guid(),Title="Samsung note 12",Descriptions="",Price=250000000,IsActive=true},
                new Product{Id=new Guid(),Title="Samsung note 13",Descriptions="",Price=260000000,IsActive=true},
                new Product{Id=new Guid(),Title="Samsung note 14",Descriptions="",Price=270000000,IsActive=true},
                new Product{Id=new Guid(),Title="Samsung note 15",Descriptions="",Price=280000000,IsActive=true}
            };
            foreach (Product p in Products)
            {
                context.Product.Add(p);
            }
            var ProductCategory = new ProductCategory[]
            {
                new ProductCategory{Id=new Guid(),Title="Máy tính bảng",IsActive=true},
                new ProductCategory{Id=new Guid(),Title="Laptop",IsActive=true}
            };
            foreach (ProductCategory pc in ProductCategory)
            {
                context.ProductCategory.Add(pc);
            }
            context.SaveChanges();
        }
    }
}