﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mw246116MIS4200.Models
{
    public class Orders
    {
        [Key]
        public int orderNum { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
        public int customerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}