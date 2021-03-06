﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIDemo.Models
{
    public class Order
    {
        //Constructor
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        //Properties
        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }

        //Navigation
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }



    }
}
