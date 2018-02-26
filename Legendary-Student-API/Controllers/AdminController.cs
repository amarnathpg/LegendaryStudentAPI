using Legendary_Student_API.Models;
using Legendary_Student_API.Models.Helper;
using Legendary_Student_API.Models.Test;
using Legendary_Student_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace Legendary_Student_API.Controllers
{
    [RoutePrefix("api/Admin")]
    //[Authorize(Roles = "Admin")]
    public class AdminController : ApiController
    {
        ProfessorService professorService = new ProfessorService();

        #region Class
        [Route("PostAllClass")]
        [HttpPost]
        public IHttpActionResult AddAllClass([FromBody]List<Models.Class> lstclass)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.PostAllClass(lstclass)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
        [Route("GetAllClass")]
        [HttpGet]
        public IHttpActionResult GetAllClass()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.GetAllClass()
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }
        #endregion

        #region Subject
        [Route("PostSubject/{ClassID:int}")]
        [HttpPost]
        public IHttpActionResult AddSubject([FromUri]int ClassID, [FromBody]Subject subject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.AddSubject(subject, ClassID)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("UpdateSubject")]
        [HttpPut]
        public IHttpActionResult UpdateSubject([FromBody]Subject subject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.UpdateSubject(subject.SubjectID)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("DeleteSubject/{SubjectID:int}")]
        [HttpDelete]
        public IHttpActionResult DeleteSubject([FromUri]int SubjectID)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.DeleteSubject(SubjectID)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("GetAllSubjects/{ClassID:int}")]
        [HttpPost]
        public IHttpActionResult GetAllSubjects([FromUri]int ClassID)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.GetAllSubjectsByClass(ClassID)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        #endregion

        #region Concept
        [Route("PostConcept/{ClassID:int}/{SubjectID:int}")]
        [HttpPost]
        public IHttpActionResult AddConcept([FromUri]int ClassID, [FromUri]int SubjectID, [FromBody]Concept concept)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.AddConcept(concept, SubjectID, ClassID)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("UpdateConcept")]
        [HttpPost]
        public IHttpActionResult UpdateConcept([FromBody]Concept concept)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.UpdateConcept(concept)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("DeleteConcept/{ConceptID:int}")]
        [HttpPost]
        public IHttpActionResult DeleteConcept([FromUri]int ConceptID)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.DeleteConcept(ConceptID)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("GetAllConcepts/{ClassID:int}/{SubjectID:int}/")]
        [HttpPost]
        public IHttpActionResult GetAllConcepts([FromUri]int ClassID, [FromUri]int SubjectID)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.GetAllConceptsBySubjectIDClassID(ClassID, SubjectID)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        #endregion

        #region Question
        [Route("AddQuestion/{ClassID:int}/{SubjectID:int}/{ConceptID:int}")]
        [HttpPost]
        public IHttpActionResult AddQuestion([FromUri]int ClassID, [FromUri]int SubjectID, [FromUri]int ConceptID, [FromBody]Question question)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.AddQuestionOptionByClassIDSubjectIDConceptID(question, question.lstOption.ToList(), ConceptID, SubjectID, ClassID)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
            //Question question = new Question() { QuestionName = QuestionName, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsActive = true };
            //List<Option> lstOpt = new List<Option>();
            //lstOption.ForEach(x =>
            //{
            //    lstOpt.Add(x);
            //});
            //return Ok(new DataModel() { HttpStatusCode = System.Net.HttpStatusCode.OK, Exception = null, Data = professorService.AddQuestionOptionByClassIDSubjectIDConceptID(question, lstOpt, ConceptID, SubjectID, ClassID) });
        }

        [Route("UpdateQuestion")]
        [HttpPost]
        public IHttpActionResult UpdateQuestion([FromBody]Question question)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.UpdateQuestion(question)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("DeleteQuestion/{QuestionID:int}")]
        [HttpPost]
        public IHttpActionResult DeleteQuestion([FromUri]int QuestionID)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.DeleteQuestion(QuestionID)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("GetAllQuestions/{ClassID:int}/{SubjectID:int}/{ConceptID:int}")]
        [HttpPost]
        public IHttpActionResult GetAllQuestions([FromUri]int ClassID, [FromUri]int SubjectID, [FromUri]int ConceptID)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.GetAllQuestion(ConceptID, SubjectID, ClassID)
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        #endregion

        #region HelperFunctions
        private new IHttpActionResult InternalServerError(Exception ex)
        {
            return Content(HttpStatusCode.InternalServerError, new DataModel()
            {
                HttpStatusCode = HttpStatusCode.InternalServerError,
                Exception = new HttpException(Convert.ToInt32(HttpStatusCode.InternalServerError), HttpStatusCode.InternalServerError.ToString(), ex),
                Data = null
            });
        }

        private new IHttpActionResult BadRequest(ModelStateDictionary ModelState)
        {
            return Content(HttpStatusCode.BadRequest, new DataModel()
            {
                HttpStatusCode = System.Net.HttpStatusCode.BadRequest,
                Exception = null,
                Data = ModelState
            });
        }
        #endregion
    }
}