using DemoMOMO_nhom2.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMOMO_nhom2.Repository
{
    public class SeedData
    {
        public static void SeedingData(DataContext _context)
        {
            _context.Database.Migrate();
            if (!_context.Products.Any())
            {
                CategotyModel macbook = new CategotyModel { Name = "Macbook", Slug = "mic", Description = "Apple is Brand in the word", Status = 1 };
                CategotyModel pc = new CategotyModel { Name = "Pc", Slug = "pc", Description = "Apple is Brand in the word", Status = 1 };

                BrandModel apple = new BrandModel { Name = "apple", Slug = "mic", Description = "Apple is Brand in the word", Status = 1 };
                BrandModel samsung = new BrandModel { Name = "samsunghhhh", Slug = "pc", Description = "Apple is Brand in the word", Status = 1 };

                _context.Products.AddRange(

                    new ProductModel { Name = "MacBook", Slug = "mic", Description = "mic is best", Image = "mac.jpg", Categoty = macbook, Brand = apple, Price = 1233432 },
                    new ProductModel { Name = "pc", Slug = "pc", Description = "mic is best", Image = "1.jpg", Categoty = pc, Brand = samsung, Price = 1233432 },
                    new ProductModel { Name = "MacBook pro 2019", Slug = "mic", Description = "mic is best", Image = "1.jpg", Categoty = macbook, Brand = apple, Price = 1233432 }


                );
                _context.SaveChanges();
            }
        }

    }
}
