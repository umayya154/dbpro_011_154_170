using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DB3.Models
{
    public class BillViewModel
    {
        public DateTime Date { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "This field is required")]
        public int Price { get; set; }
        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "This field is required")]
        public int Quantity { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
    }
}