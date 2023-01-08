using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemadeRestaurant.Entities
{
    public class Food : Product
    {
        public Food(string title, decimal price) : base(title, price)
        {
            Title = title;
            Price = price;
        }
    }
}