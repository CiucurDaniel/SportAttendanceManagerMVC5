using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using SportAttendanceManager.Models;

namespace SportAttendanceManager.DataAccessLayer
{
    public class SportAttendanceManagerContext : DbContext 
    {
        public SportAttendanceManagerContext() : base("SportAttendanceManagerDatabase")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<demoEntities>(null);
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);


        }
    }
}