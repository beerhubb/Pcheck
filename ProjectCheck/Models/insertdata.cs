using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCheck.Models
{
    public class insertdata
    {
        [BsonId]
        public string _id { get; set; }

        [Required]
        [Display(Name = "รูปภาพ")]
        public string pictrue { get; set; }

        [Required]
        [Display(Name = "ชื่ออะไหล่")]
        public string name { get; set; }

        [Required]
        [Display(Name = "ราคา")]
        public string price { get; set; }

        [Required]
        [Display(Name = "รายละเอียด")]
        public string detail { get; set; }

        [Required]
        [Display(Name = "ประเภท")]
        public string status { get; set; }

    }
}
