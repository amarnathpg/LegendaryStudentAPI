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
                        Data = professorService.AddOrUpdateSubject(subject, ClassID)
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
                        Data = professorService.AddOrUpdateSubject(subject)
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

        [Route("DeleteSubject")]
        [HttpDelete]
        public IHttpActionResult DeleteSubject([FromBody]Subject subject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.AddOrUpdateSubject(subject)
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
        [HttpGet]
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
                        Data = professorService.GetAllSubjects(ClassID)
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
                        Data = professorService.AddOrUpdateConcept(concept, SubjectID, ClassID)
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
        [HttpPut]
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
                        Data = professorService.AddOrUpdateConcept(concept)
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

        [Route("DeleteConcept")]
        [HttpDelete]
        public IHttpActionResult DeleteConcept([FromBody]Concept concept)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.AddOrUpdateConcept(concept)
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
        [HttpGet]
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
                        Data = professorService.GetAllConcepts(ClassID, SubjectID)
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
        [Route("PostQuestion/{ClassID:int}/{SubjectID:int}/{ConceptID:int}")]
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
                        Data = professorService.AddOrUpdateQuestion(question, ConceptID, SubjectID, ClassID)
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

        [Route("UpdateQuestion")]
        [HttpPut]
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
                        Data = professorService.AddOrUpdateQuestion(question)
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

        [Route("DeleteQuestion")]
        [HttpDelete]
        public IHttpActionResult DeleteQuestion([FromBody]Question question)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Content(HttpStatusCode.OK, new DataModel()
                    {
                        HttpStatusCode = System.Net.HttpStatusCode.OK,
                        Exception = null,
                        Data = professorService.AddOrUpdateQuestion(question)
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
        [HttpGet]
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