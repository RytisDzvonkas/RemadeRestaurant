using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemadeRestaurant.Entities
{
    public class Customer : Entity
    {
        public int TableId { get; set; }
        public int WaiterId { get; set; }

        public Customer(int tableId, int waiterId)
        {
            TableId = tableId;
            WaiterId = waiterId;
        }
    }
}
