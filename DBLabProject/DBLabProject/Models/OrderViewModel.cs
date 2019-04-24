using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBLabProject.Models
{
    public class OrderViewModel
    {
        public int order_id { get; set; }
        public string order_Medicine { get; set; }
        public int order_Quantity { get; set; }
        public int order_Price { get; set; }
        public int customer_id { get; set; }
        public int medicine_id { get; set; }
    }
}