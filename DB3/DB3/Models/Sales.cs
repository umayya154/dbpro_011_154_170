using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DB3.Models
{
    public class Sales
    {
        public DateTime Date { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Total { get; set; }
        public int Medicine_Id { get; set; }
    }
}