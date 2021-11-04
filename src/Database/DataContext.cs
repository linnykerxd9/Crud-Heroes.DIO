using CRUD.EfCore.src.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.EfCore.src.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hero> Heroes { get; set; }

        public DbSet<Group>  Groups { get; set; }
    }
}
