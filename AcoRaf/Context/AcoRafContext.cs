using AcoRaf.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace AcoRaf.Context
{
    public class AcoRafContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}