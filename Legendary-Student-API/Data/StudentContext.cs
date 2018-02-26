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
        #endregion

        #region MappingTables
        public DbSet<SubjectClassMapping> SubjectClassMapping { get; set; }
        public DbSet<SchoolClassMapping> SchoolClassMappings { get; set; }
        public DbSet<ConceptClassMapping> ConceptClassMappings { get; set; }
        #endregion

        #region TestRelatedTables
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Concept> Concepts { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        #endregion
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<StudentContext>(new DropCreateDatabaseIfModelChanges<StudentContext>());
        }
    }
}