using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemadeRestaurant.Entities
{
    public class Tables : Entity
    {
        public int WaiterId { get; set; }
        public int OrderId { get; set; }
        public int ChequeId { get; set; }
        public int Size { get; set; }
        public bool Busyness { get; set; }

        public Tables()
        {
        }
        public Tables(int size, bool busyness)
        {
            Size = size;
            Busyness = busyness;
        }

    }
}
