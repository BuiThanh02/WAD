using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Test.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("test") { }

        public DbSet<Contacts> Contacts { get; set; }
    }
}