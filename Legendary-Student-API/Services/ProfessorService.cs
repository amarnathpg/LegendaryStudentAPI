using Legendary_Student_API.Models;
using Legendary_Student_API.Models.Test;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Services
{

    public class ProfessorService
    {
        public StudentContext _context;
        public ProfessorService()
        {
            _context = new StudentContext();
        }

        #region Class
        public List<Class> GetAllClass()
        {
            return _context.Class.ToList();
        }
        public bool PostAllClass(List<Class> lstClass)
        {
            using (var db = new StudentContext())
            {
                lstClass.ForEach(x => db.Class.Add(x));
                db.SaveChanges();
            }
            return true;
        }
        #endregion Class

        #region Subject
        public bool AddOrUpdateSubject(Subject subject, int ClassID = 0)
        {
            bool returnValue = false;
            using (var db = new StudentContext())
            {
                db.Entry(subject).State = subject.SubjectID == 0 ? EntityState.Added : EntityState.Modified;
                if (db.Entry(subject).State == EntityState.Added)
                {
                    SubjectClassMapping subjectClassMapping = new SubjectClassMapping() { ClassID = ClassID, SubjectID = subject.SubjectID };
                    db.Entry(subjectClassMapping).State = subjectClassMapping.ID == 0 ? EntityState.Added : EntityState.Modified;
                }
                returnValue = db.SaveChanges() > 0;
            }
            return returnValue;
        }
        public List<Subject> GetAllSubjects(int ClassID)
        {
            List<Subject> lstSubject = new List<Subject>();
            using (var db = new StudentContext())
            {
                lstSubject = (from subjectclass in db.SubjectClassMapping
                              join subject in db.Subjects on subjectclass.SubjectID equals subject.SubjectID
                              where subjectclass.ClassID.Equals(ClassID) && subject.IsActive.Equals(true)
                              select subject).ToList<Subject>();
            }
            return lstSubject;
        }
        #endregion

        #region Concept
        public bool AddOrUpdateConcept(Concept concept, int SubjectID = 0, int ClassID = 0)
        {
            using (var db = new StudentContext())
            {                
                db.Entry(concept).State = concept.ConceptID == 0 ? EntityState.Added : EntityState.Modified;
                if (db.Entry(concept).State == EntityState.Added)
                {
                    ConceptClassMapping conceptClassMapping = new ConceptClassMapping() { ClassID = ClassID, ConceptID = concept.ConceptID };
                    db.Entry(conceptClassMapping).State = conceptClassMapping.ID == 0 ? EntityState.Added : EntityState.Modified;
                }
                db.SaveChanges();
            }
            return true;
        }
        public List<Concept> GetAllConcepts(int ClassID, int SubjectID)
        {
            List<Concept> lstConcept = new List<Concept>();
            using (var db = new StudentContext())
            {
                lstConcept = (from conceptclass in db.ConceptClassMappings
                              join concept in db.Concepts.Where(x => x.SubjectID == SubjectID) on conceptclass.ConceptID equals concept.ConceptID
                              where conceptclass.ClassID.Equals(ClassID) && concept.IsActive.Equals(true)
                              select concept).ToList<Concept>();
            }
            return lstConcept;
        }
        #endregion

        #region Question
        public bool AddOrUpdateQuestion(Question question, int ConceptID = 0, int SubjectID = 0, int ClassID = 0)
        {
            using (var db = new StudentContext())
            {
                db.Entry(question).State = question.QuestionID == 0 ? EntityState.Added : EntityState.Modified;
                if (db.Entry(question).State == EntityState.Modified)
                    question.Options.ToList().ForEach(x=> db.Entry(x).State = EntityState.Modified);
                db.SaveChanges();
            }
            return true;
        }
        public List<Question> GetAllQuestion(int ConceptID, int SubjectID, int ClassID)
        {
            List<Question> lstQuestion = new List<Question>();
            List<Option> lstOption = new List<Option>();
            using (var db = new StudentContext())
            {
                lstQuestion = db.Questions.Include(o=>o.Options).ToList();
            }
            return lstQuestion;
        }
        #endregion
    }
}