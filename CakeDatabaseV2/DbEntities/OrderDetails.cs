using CakeDatabase.DbEntities.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDatabase.DbEntities
{
    public class OrderDetails : BaseEntity2
    {
        public int OrderId { get; set; }

        public string ClientName { get; set; }

        public string CakeName { get; set; }

        public DateTime OrderRequest { get; set; }

        public DateTime OrderCheckout { get; set; }
    }
}
