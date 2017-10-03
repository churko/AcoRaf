﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcoRaf.Models
{
    public class PhoneNumberModels
    {
        [Key]
        public int Id { get; set; }

        public string PhoneType { get; set; }

        public string PhoneNumber { get; set; }
    }
}