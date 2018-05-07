// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserExamController.cs" company="NCSolution">
//   Copyright 2018
// </copyright>
// <summary>
//   User exam attempt questions.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NCS.PaperGeneration.ApiService.Controllers
{
    using System.Web.Http;
    using NCS.PaperGeneration.IServices;

    /// <summary>
    /// User exam attempt questions.
    /// </summary>
    [RoutePrefix("api/UserExam")]
    public class UserExamController : ApiController
    {
        /// <summary>
        /// The user exam service.
        /// </summary>
        private readonly IUserExamService userExamService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExamController"/> class. 
        /// User exam attempt questions.
        /// </summary>
        /// <param name="userExamService">The userExamService
        /// </param>
        public UserExamController(IUserExamService userExamService)
        {
            this.userExamService = userExamService;
        }
    }
}
