using Microsoft.EntityFrameworkCore;
using SiteCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SiteCRM.Infrastructure
{
    public class SiteCRMDbContext : DbContext
    {
        public SiteCRMDbContext(DbContextOptions<SiteCRMDbContext> options) : base(options) 
        {
			ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
			AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
			AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
		}

        public DbSet<Sobre> Sobres { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Missoes> Missoes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPermissions> UserPermissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
