using dotnet.Models;
using dotnet.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Services
{
    public interface IProductService
    {
        public List<ProductPreviewDto> GetAll();
        public Product GetOne(string id);
        public List<ProductPreviewDto> Search(string q);
    }
}
