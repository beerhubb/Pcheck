using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCheck.Models
{
    public class Login
    {
        [Required]
        [Display(Name ="UserName")]
        public string id { get; set; }

        [Required]
        [Display(Name ="PassWord")]
        [DataType(DataType.Password)]
        public string pass { get; set; }
    }
}
