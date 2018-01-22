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
    [RoutePrefix("api/exams")]
    public class ExamController : ApiController
    {
        private readonly IExamService _examService;
        public ExamController(IExamService examService)
        {
            _examService = examService;
        }

        [Route("getbyid/{id:int}")]
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
