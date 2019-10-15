using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Real_Estate_Application.Models
{
    public class RealEstateContext : DbContext
    {
        public DbSet<Agent> Agents { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Image> Images { get; set; }
    }
}