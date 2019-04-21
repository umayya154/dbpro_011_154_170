using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB3.Models
{
    public class Medicine
    {
        public int Medicine_Id { get; set; }
        public string Medicine_Name { get; set; }
        public int Price { get; set; }
        public DateTime Mfg_Date { get; set; }
        public DateTime Exp_Date { get; set; }
        public int Batch { get; set; }
        public int Type { get; set; }

        public int CompanyID { get; set; }

    }
}