﻿namespace ShoppingApp.Web.Models.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public DateTime DateAdded { get; set; }

    }
}