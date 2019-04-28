using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace DB3.Models
{
    public class CustomerViewModel
    {
       
        [Required(ErrorMessage = "This field is required")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Use letters only please")]

        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "This field is required")]
        public string Address { get; set; }
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", ErrorMessage = "Invalid Phone number")]
        public string Phone { get; set; }
        public string status { get; set; }
        [Display(Name = "City")]
        [Required(ErrorMessage = "This field is required")]
        public string city { get; set; }
    }
}