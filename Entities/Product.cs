using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemadeRestaurant.Entities
{
    public class Product : Entity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public Product()
        {
        }

        public Product(string title, decimal price)
        {
            Title = title;
            Price = price;
        }
    }
}
