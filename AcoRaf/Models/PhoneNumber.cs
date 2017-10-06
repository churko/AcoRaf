using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcoRaf.Models
{
    public class PhoneNumber
    {
        [Key]
        public int Id { get; set; }

        public string PhoneType { get; set; }

        public string PhoneDigits { get; set; }
    }
}