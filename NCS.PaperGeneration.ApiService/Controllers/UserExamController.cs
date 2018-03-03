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
    }
}
