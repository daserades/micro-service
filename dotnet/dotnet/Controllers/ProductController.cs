using dotnet.Models;
using dotnet.Models.Dto;
using dotnet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _products;
        public ProductController(IProductService products)
        {
            _products = products;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult Get()
        {
            List<ProductPreviewDto> products;
            try
            {
                products = _products.GetAll();
            }
            catch
            {
                return StatusCode(500);                
            }

            if (products == null)
                return NotFound("No products found!");

            return Ok(products);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetOne(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest("Please provide valid id");

            Product product;

            try
            {
                product = _products.GetOne(id);
            }
            catch
            {
                return StatusCode(500);
            }

            if (product == null)
                return NotFound("Product not found!");

            return Ok(product);
        }

        [HttpGet]
        [Route("search/{q}")]
        public IActionResult Search(string q)
        {
            if (string.IsNullOrEmpty(q))
                return BadRequest("Please provide valid string to search");

            List<ProductPreviewDto> product;

            try
            {
                product = _products.Search(q);
            }
            catch
            {
                return StatusCode(500);
            }

            if (product == null)
                return NotFound("Product not found!");

            return Ok(product);
        }
    }
}
