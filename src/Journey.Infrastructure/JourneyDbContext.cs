using Journey.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey.Infrastructure
{
    public class JourneyDbContext : DbContext
    {
        //using the concept of db first, we have to put the name of the prop exactly like the name of the table
        public DbSet<Trip> Trips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=PATH TO THE DB");
        }
    }
}
