using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NCS.PaperGeneration.Entities.Entities;
using NCS.PaperGeneration.IServices;

namespace NCS.PaperGeneration.ApiService.Controllers
{
    [RoutePrefix("api/exam")]
    public class ExamController : ApiController
    {
        private readonly IExamService _examService;
        public ExamController(IExamService examService)
        {
            _examService = examService;
        }

        /// <summary>
        /// Get exam details using id
        /// </summary>
        /// <param name="id">The exam id.</param>
        /// <returns>The Exam object.</returns>
        [Route("{id:int}")]
        public Exam GetById(int id)
        {

            Exam exam = null;
            try
            {
                exam = _examService.GetById(id);                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
            return exam;
        }

        
    }
}
