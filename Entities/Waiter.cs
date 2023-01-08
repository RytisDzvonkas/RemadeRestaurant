using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemadeRestaurant.Entities
{
    public class Waiter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TableId { get; set; }
        public int CustomerId { get; set; }

        public Waiter(int Id, string name, int tableId, int customerId)
        {
            Id = Id;
            Name = name;
            TableId = tableId;
            CustomerId = customerId;
        }
    }
}
