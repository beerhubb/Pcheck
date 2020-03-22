using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCheck.Models
{
    public class AddAu
    {
        [BsonId]
        public string _id { get; set; }

        [Required]
        [Display(Name = "ชื่ออู่")]
        public string name { get; set; }

        [Required]
        [Display(Name = "ที่อยุ่อู่")]
        public string address { get; set; }

        [Required]
        [Display(Name = "เบอร์โทรศัพท์")]
        public string phon { get; set; }
    }
}
