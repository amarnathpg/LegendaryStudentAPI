using Legendary_Student_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Legendary_Student_API
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("StudentContext")
        {

        }
        public DbSet<School> Schools { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
    .HasRequired(c => c.Address)
    .WithMany()
    .WillCascadeOnDelete(false);

            modelBuilder.Entity<School>()
                .HasRequired(s => s.Address)
                .WithMany()
                .WillCascadeOnDelete(false);
            //Configure default schema
            //modelBuilder.HasDefaultSchema("Admin");
        }
    }
}