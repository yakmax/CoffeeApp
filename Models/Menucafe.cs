using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeApp.Models
{
    public class Menucafe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public MenuCategory Category { get; set; }
    }
    public class MenuCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}