using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }

        /**
         * You must have a constructor. This takes in a DbContextOptions object, which is passed through DI.
         * When this is called, it will
         */
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /**
         * This is Fluent API which uses dependency injection.  Treat this as a black box.  Basically the stuff here defines the primary/foreign keys of your tables.
         * Entity Framework does not support many-many relationships: you need to create an Entity for the intermediate table and specify the relations yourself.
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeAssignment>()
                .HasKey(ea => new { ea.EmployeeID, ea.ProjectID });
            modelBuilder.Entity<EmployeeAssignment>()
                .HasOne(ea => ea.Project)
                .WithMany(p => p.EmployeeAssignments)
                .HasForeignKey(pt => pt.ProjectID);
            modelBuilder.Entity<EmployeeAssignment>()
                .HasOne(ea => ea.Employee)
                .WithMany(e => e.EmployeeAssignments)
                .HasForeignKey(ea => ea.EmployeeID);
        }

        /**This is unnecessary since we are using DI. We need this if we aren't using DI.'*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
