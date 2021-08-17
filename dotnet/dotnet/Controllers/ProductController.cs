using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Controllers
{
    [ApiController]
    [Route("dotnet/product")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] Titles = new[]
        {
            "Iphone 5", "Xbox One", "Macbook Pro", "Galaxy S20", "MSI Ghost Pro", "Lenovo V15", "Logitech G29", "Xiaomi Note 10 Pro", "Ipad Pro", "Samsung Evo 1TB"
        };

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, Titles.Length).Select(index => new Product
            {
                Id = index,
                Price = rng.Next(800,1001),
                Date = DateTime.Now,
                Rating = rng.Next(1,6),
                Title = Titles[index - 1]
            })
            .ToArray();
        }
    }
}
