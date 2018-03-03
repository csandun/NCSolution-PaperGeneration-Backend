
using NCS.PaperGeneration.Entities.CompactEntities;
using NCS.PaperGeneration.Entities.Entities;
using NCS.PaperGeneration.IServices;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace NCS.PaperGeneration.ApiService.Controllers
{
    [RoutePrefix("api/UserExamQuestions")]
    /// <summary>
    /// user exam attempt question controller
    /// </summary>
    public class UserExamQuestionController : ApiController
    {

        private readonly IUserExamQuestionService _userExamQuestionService;

        /// <summary>
        /// user exam questions controller.
        /// </summary>
        public UserExamQuestionController(IUserExamQuestionService userExamQuestionService)
        {
            this._userExamQuestionService = userExamQuestionService;
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
                return _userExamQuestionService.GetUserExamQuestions(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Update the answer of the question
        /// </summary>
        /// <returns>Updated user exam question.</returns>
        [HttpPut]
        [Route("{id:int}")]
        public void UpdateQuestionAnswer(UserExamAttemptQuestion questionCompact)
        {
            try
            {
                _userExamQuestionService.Update(questionCompact);
            }
            catch (Exception e)
            {                 
                throw e;
            }
        }


    }
}
