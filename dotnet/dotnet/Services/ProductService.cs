using dotnet.Context;
using dotnet.Models;
using dotnet.Models.Dto;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Services
{
    public class ProductService : IProductService
    {
        private readonly DbContext _context;
        private readonly IMapper _mapper;
        public ProductService(DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<ProductPreviewDto> GetAll()
        {
            List<Product> allProducts = _context.Products;

            List<ProductPreviewDto> productPreviews = MapToPreview(allProducts);

            return productPreviews;
        }

        public Product GetOne(string id)
        {
            return _context.Products.FirstOrDefault(e => e.Id == int.Parse(id));
        }

        public List<ProductPreviewDto> Search(string q)
        {
            List<Product> allProducts = _context.Products;

            List<ProductPreviewDto> productPreviews = MapToPreview(allProducts);

            return productPreviews.FindAll(e => e.Title.ToLower().Contains(q.ToLower()));
        }

        private List<ProductPreviewDto> MapToPreview(List<Product> products)
        {
            List<ProductPreviewDto> productPreviews = _mapper.Map<List<Product>, List<ProductPreviewDto>>(products);
            return productPreviews;
        }
    }
}
