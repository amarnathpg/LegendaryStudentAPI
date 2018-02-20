using Legendary_Student_API.Models;
using Legendary_Student_API.Models.Test;
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

        #region MasterTables
        public DbSet<School> Schools { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<SchoolClassMapping> SchoolClassMappings { get; set; }
        #endregion

        public DbSet<ConceptClassMapping> ConceptClassMappings { get; set; }
        

        #region TestRelatedTables
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Concept> Concepts { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Answer> Answers { get; set; }
        #endregion
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>()
            //    .HasOptional(s => s.Address) // Mark Address property optional in Student entity
            //    .WithRequired(ad => ad.Student);
            //modelBuilder.Entity<School>()
            //    .HasOptional(s => s.Address) // Mark Address property optional in Student entity
            //    .WithRequired(ad => ad.School);
            Database.SetInitializer<StudentContext>(new DropCreateDatabaseIfModelChanges<StudentContext>());
            //modelBuilder.Entity<Student>()
            //    .HasRequired(c => c.Address)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<School>()
            //    .HasRequired(s => s.Address)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Question>()
            //    .HasRequired(c => c.Options)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Answer>()
            //    .HasRequired(s => s.Options)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
        }
        //protected override void Seed(StudentContext context)
        //{
        //    try
        //    {
        //        context.Props.AddOrUpdate(
        //        p => p.PropName,
        //        new Prop() { PropName = "sharpie" },
        //        new Prop() { PropName = "coin" },
        //        new Prop() { PropName = "playing cards" },
        //        new Prop() { PropName = "coffee mug" },
        //        new Prop() { PropName = "phone" },
        //        new Prop() { PropName = "keys" },
        //        new Prop() { PropName = "sunglasses" },
        //        new Prop() { PropName = "headphones" },
        //        new Prop() { PropName = "ring" },
        //        new Prop() { PropName = "lighter" }
        //        );

        //        context.SaveChanges();
        //    }
        //    finally
        //    {
        //        context.Dispose();
        //    }
        //}
    }
}