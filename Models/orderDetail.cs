using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mw246116MIS4200.Models
{
    public class OrderDetail
    {
        public int orderDetailId { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        public int orderId { get; set; }
        public virtual Orders Order { get; set; }
        public int productId { get; set; }
        public virtual Product Product { get; set; }

    }
}