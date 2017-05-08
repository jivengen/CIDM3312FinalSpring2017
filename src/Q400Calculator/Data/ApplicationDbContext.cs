using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Q400Calculator.Models;

namespace Q400Calculator.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ClimbData> ClimbData { get; set; }
        public DbSet<flaps518ColdData> flaps518ColdData { get; set; }
        public DbSet<flaps520ColdData> flaps520ColdData { get; set; }
        public DbSet<flaps522ColdData> flaps522ColdData { get; set; }
        public DbSet<flaps524ColdData> flaps524ColdData { get; set; }
        public DbSet<flaps526ColdData> flaps526ColdData { get; set; }
        public DbSet<flaps528ColdData> flaps528ColdData { get; set; }
        public DbSet<flaps529ColdData> flaps529ColdData { get; set; }
        public DbSet<flaps1018ColdData> flaps1018ColdData { get; set; }
        public DbSet<flaps1020ColdData> flaps1020ColdData { get; set; }
        public DbSet<flaps1022ColdData> flaps1022ColdData { get; set; }
        public DbSet<flaps1024ColdData> flaps1024ColdData { get; set; }
        public DbSet<flaps1026ColdData> flaps1026ColdData { get; set; }
        public DbSet<flaps1028ColdData> flaps1028ColdData { get; set; }
        public DbSet<flaps1029ColdData> flaps1029ColdData { get; set; }
        public DbSet<flaps518HotData> flaps518HotData { get; set; }
        public DbSet<flaps520HotData> flaps520HotData { get; set; }
        public DbSet<flaps522HotData> flaps522HotData { get; set; }
        public DbSet<flaps524HotData> flaps524HotData { get; set; }
        public DbSet<flaps526HotData> flaps526HotData { get; set; }
        public DbSet<flaps528HotData> flaps528HotData { get; set; }
        public DbSet<flaps529HotData> flaps529HotData { get; set; }
        public DbSet<flaps1018HotData> flaps1018HotData { get; set; }
        public DbSet<flaps1020HotData> flaps1020HotData { get; set; }
        public DbSet<flaps1022HotData> flaps1022HotData { get; set; }
        public DbSet<flaps1024HotData> flaps1024HotData { get; set; }
        public DbSet<flaps1026HotData> flaps1026HotData { get; set; }
        public DbSet<flaps1028HotData> flaps1028HotData { get; set; }
        public DbSet<flaps1029HotData> flaps1029HotData { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<ClimbData>().ToTable("ClimbData");
        }
    }
}
