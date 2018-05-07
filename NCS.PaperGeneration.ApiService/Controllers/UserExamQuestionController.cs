// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserExamQuestionController.cs" company="NCSolution">
//   Copyright 2018 
// </copyright>
// <summary>
//   user exam attempt question controller
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NCS.PaperGeneration.ApiService.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Http;

    using NCS.PaperGeneration.Entities.CompactEntities;
    using NCS.PaperGeneration.Entities.Entities;
    using NCS.PaperGeneration.IServices;

    /// <summary>
    /// user exam attempt question controller
    /// </summary>
    [RoutePrefix("api/UserExamQuestion")]
    public class UserExamQuestionController : ApiController
    {
        /// <summary>
        /// The user exam question service.
        /// </summary>
        private readonly IUserExamQuestionService userExamQuestionService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExamQuestionController"/> class. 
        /// user exam questions controller.
        /// </summary>
        /// <param name="userExamQuestionService">
        /// The user Exam Question Service.
        /// </param>
        public UserExamQuestionController(IUserExamQuestionService userExamQuestionService)
        {
            this.userExamQuestionService = userExamQuestionService;
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
                return this.userExamQuestionService.GetUserExamQuestions(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Update the answer of the question
        /// </summary>
        /// <param name="answer">
        /// The Answer.
        /// </param>
        [HttpPut]
        public void UpdateQuestionAnswer(QuestionAnswer answer)
        {
            try
            {
                this.userExamQuestionService.SaveUserAnswer(answer.ExamId, answer.QuestionId, answer.AnswerId);
            }
            catch (Exception e)
            {                 
                throw e;
            }
        }
    }
}
