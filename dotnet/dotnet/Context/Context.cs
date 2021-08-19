using dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Context
{
    public class DbContext
    {
        public List<Product> Products { get; set; }

        public DbContext()
        {

            string[] titles = new string[]
            {
                "Iphone 5", "Xbox One", "Macbook Pro", "Galaxy S20", "MSI Ghost Pro", "Lenovo V15", "Logitech G29", "Xiaomi Note 10 Pro", "Ipad Pro", "Samsung Evo 1TB"
            };

            var rng = new Random();
            List<Product> products = new();

            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product
                {
                    Id = i + 1,
                    Title = titles[i],
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur.",
                    Description = "Curabitur tempor ipsum a sem mattis, id congue urna venenatis. Nullam eget lorem rhoncus, aliquam diam et, aliquam eros. Duis lacinia sapien sed hendrerit dignissim. Morbi tincidunt ipsum libero, et auctor eros rutrum at. Nunc enim nunc, pellentesque vel tincidunt ut, aliquet non erat. Fusce auctor ante eros, non mollis felis sagittis et. Phasellus scelerisque accumsan quam eget congue. Vivamus eget massa vulputate, ultricies eros eu, dictum mi.",
                    Thumbnail = $"https://via.placeholder.com/150/42B983/FFFFFF?text={i+1}",
                    Image_1 = "https://via.placeholder.com/350/EFCA25/FFFFFF?text=Image%201",
                    Image_2 = "https://via.placeholder.com/350/34495E/FFFFFF?text=Image%202",
                    Image_3 = "https://via.placeholder.com/350/522E5B/FFFFFF?text=Image%203",
                    IsHot = rng.Next(0,2) == 1 ? true : false,
                    Price = rng.Next(800, 1001),
                    Date = DateTime.Now
                });
            }
            Products = products;
        }

    }
}
