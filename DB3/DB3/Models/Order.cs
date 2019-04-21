using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB3.Models
{
    public class Order
    {
        public int order_Id { get; set; }
        public string order_Medicine { get; set; }
        public int order_Quantity { get; set; }
        public int order_Price { get; set; }
        public int customer_Id { get; set; }
        public int medicine_Id { get; set; }

    }
}