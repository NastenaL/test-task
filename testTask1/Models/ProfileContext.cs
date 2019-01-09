using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace testTask1.Models
{
    public class ProfileContext : DbContext
    {
        public ProfileContext() :
            base("DefaultConnection")
        { }

        public DbSet<Profile> Profile { get; set; }
    }
}