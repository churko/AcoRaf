using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcoRaf.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }

        public string Plate { get; set; }

        public string VehicleType { get; set; }

        public string Make { get; set; }

        public int Model { get; set; }

        public int Capacity { get; set; }

    }
}