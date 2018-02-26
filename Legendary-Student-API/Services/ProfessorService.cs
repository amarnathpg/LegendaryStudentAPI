using Legendary_Student_API.Models;
using Legendary_Student_API.Models.Test;
using System;
using System.Collections.Generic;
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
        public bool AddSubject(Subject subject, int ClassID)
        {
            bool returnValue = false;
            using (var db = new StudentContext())
            {
                db.Subjects.Add(subject);
                db.SubjectClassMapping.Add(new SubjectClassMapping() { ClassID = ClassID, SubjectID = subject.SubjectID });
                returnValue = db.SaveChanges() > 0;
            }
            return returnValue;
        }
        public List<Subject> GetAllSubjectsByClass(int ClassID)
        {
            List<Subject> lstSubject = new List<Subject>();
            using (var db = new StudentContext())
            {
                lstSubject = (from subjectclass in db.SubjectClassMapping
                              join subject in db.Subjects on subjectclass.SubjectID equals subject.SubjectID
                              where subjectclass.ClassID.Equals(ClassID)
                              select subject).ToList<Subject>();
            }
            return lstSubject;
        }
        public bool AddConcept(Concept concept, int SubjectID, int ClassID)
        {
            using (var db = new StudentContext())
            {
                concept.SubjectID = SubjectID;
                db.Concepts.Add(concept);
                db.ConceptClassMappings.Add(new ConceptClassMapping() { ClassID = ClassID, ConceptID = concept.ConceptID });
                db.SaveChanges();
            }
            return true;
        }
        public List<Concept> GetAllConceptsBySubjectIDClassID(int ClassID, int SubjectID)
        {
            List<Concept> lstConcept = new List<Concept>();
            using (var db = new StudentContext())
            {
                //lstSubject = (from subjectclass in db.ConceptClassMappings
                //              join subject in db.Subjects on subjectclass.SubjectID equals subject.SubjectID
                //              where subjectclass.ClassID.Equals(ClassID)
                //              select subject).ToList<Subject>();

                lstConcept = db.Concepts.Where(x => x.SubjectID == SubjectID).ToList();
            }
            return lstConcept;
        }
        public bool AddQuestionOptionByClassIDSubjectIDConceptID(Question question, List<Option> lstOption, int ConceptID, int SubjectID, int ClassID)
        {
            using (var db = new StudentContext())
            {
                question.ClassID = ClassID;
                db.Questions.Add(question);
                lstOption.ForEach(x =>
                {
                    x.QuestionID = question.QuestionID;
                    x.Question = question;
                    db.Options.Add(x);
                });

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
                lstQuestion = db.Questions.Include(db.Options.ToString()).ToList();
            }
            return lstQuestion;
        }

        internal object UpdateSubject(int subjectID)
        {
            throw new NotImplementedException();
        }

        internal object DeleteSubject(int subjectID)
        {
            throw new NotImplementedException();
        }

        internal object UpdateConcept(Concept concept)
        {
            throw new NotImplementedException();
        }

        internal object DeleteConcept(int conceptID)
        {
            throw new NotImplementedException();
        }

        internal object UpdateQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        internal object DeleteQuestion(int questionID)
        {
            throw new NotImplementedException();
        }
    }
}