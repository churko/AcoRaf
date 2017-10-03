using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcoRaf.Models
{
    public class AddressModels
    {
        [Key]
        public int Id { get; set; }

        public string StreetName { get; set; }

        public int AddressNumber { get; set; }

        public string Floor { get; set; }

        public string FlatNumber { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Province { get; set; }
    }
}