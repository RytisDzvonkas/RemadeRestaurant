using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemadeRestaurant.Entities
{
    public class cheque : Entity
    {
        public int TableId { get; set; }
        public int CustomerId { get; set; }
        public int WaiterId { get; set; }

        public cheque(int tableNumber, int customerId, int waiterId)
        {
            TableId = tableNumber;
            CustomerId = customerId;
            WaiterId = waiterId;
        }
    }
}
