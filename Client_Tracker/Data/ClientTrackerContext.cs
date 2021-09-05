using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client_Tracker.Models;

namespace Client_Tracker.Data
{
    public class ClientTrackerContext :DbContext
    {
        public ClientTrackerContext(DbContextOptions<ClientTrackerContext> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .Property(b => b.CreatedDate)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<User>()
                .Property(b => b.Active)
                .HasDefaultValue("true");

            modelBuilder.Entity<Client>()
                .Property(b => b.IsClient)
               .HasDefaultValue("true");
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
