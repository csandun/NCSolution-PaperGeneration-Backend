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
    /// <summary>
    /// User exam attempt questions.
    /// </summary>
    [RoutePrefix("api/UserExams")]
    public class UserExamController : ApiController
    {
        private readonly IUserExamService _userExamService;

        /// <summary>
        /// User exam attempt questions.
        /// </summary>
        /// <param name="userExamService"></param>
        public UserExamController(IUserExamService userExamService)
        {
            _userExamService = userExamService;
        }

        /// <summary>
        /// Get user exam attempt questions by id.
        /// </summary>
        /// <param name="id">The user exam id.</param>
        /// <returns>Question list in the exam.</returns>
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
