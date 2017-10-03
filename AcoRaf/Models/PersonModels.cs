using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcoRaf.Models
{
    public class PersonModels
    {
        [Key]
        public int Id { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string DocumentType { get; set; }

        public int DocumentNumber { get; set; }

        public string FullName => string.Format("{0}, {1}", Surname, Name);

        ICollection<AddressModels> Addresses { get; set; }

        ICollection<PhoneNumberModels> PhoneNumbers { get; set; }

    }
}