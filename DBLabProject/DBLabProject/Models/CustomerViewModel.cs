using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBLabProject.Models
{
    public class CustomerViewModel
    {
        public int user_Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone{ get; set; }
        public int status { get; set; }
        public string city { get; set; }
        public int order_Id { get; set; }

    }
}