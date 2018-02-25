using NCS.PaperGeneration.Entities.Entities;
using NCS.PaperGeneration.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NCS.PaperGeneration.ApiService.Controllers
{
    [RoutePrefix("api/UserExams")]
    public class UserExamController : ApiController
    {
        private readonly IUserExamService _userExamService;
        public UserExamController(IUserExamService userExamService)
        {
            _userExamService = userExamService;
        }

        [HttpGet]
        [Route("{id:int}/Questions")]
        public List<UserExamAttemptQuestion> GetUserExamQuestions(int id)
        {
            try
            {
                return _userExamService.GetUserExamQuestions(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
