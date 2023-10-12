using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace labor_project.Models
{
    public class my_profile
    {
        [Key]
        public int id { get; set; }
        public string name { get; set;}
        public string work_address { get; set; }
        public string dist { get; set; }
        public string work { get; set; }
        public int phone_number { get; set; }
        public int proce { get; set; }
    }
}
