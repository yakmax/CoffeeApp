using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public ProductCategory Category { get; set; }
        public string ImageUrl { get; set; }
        public string Country { get; set; }
    }
}