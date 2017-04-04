using Nord.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace Nord.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Faculty> Facultati { get; set; }
    }
}