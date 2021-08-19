using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Models.Dto
{
    public class ProductPreviewDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Thumbnail { get; set; }
        public int Price { get; set; }
        public bool IsHot { get; set; }
    }
}
