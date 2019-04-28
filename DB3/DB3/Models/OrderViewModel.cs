using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DB3.Models
{
    public class OrderViewModel
    {
        //Class
        [Display(Name = "Medicine_Name")]
        [Required(ErrorMessage = "This field is required")]
        public string Medicine_Name { get; set; }
        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "This field is required")]
        
        public int Quantity { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "This field is required")]
        public int Price { get; set; }

        
        public int medicine_id { get; set; }

    }
}