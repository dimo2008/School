using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using School.Models;

namespace School.Data
{
    public class SchoolContext:DbContext
    {
        public SchoolContext() : base("SchoolConnectionString")
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> classes { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}