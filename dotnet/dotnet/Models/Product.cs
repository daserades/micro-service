using System;

namespace dotnet.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string Image_1 { get; set; }
        public string Image_2 { get; set; }
        public string Image_3 { get; set; }
        public int Price { get; set; }
        public bool IsHot { get; set; }
        public DateTime Date { get; set; }
    }
}
