// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExamController.cs" company="NCSolution">
//   Copyright 2018
// </copyright>
// <summary>
//   Defines the ExamController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NCS.PaperGeneration.ApiService.Controllers
{
    using System;
    using System.Web.Http;

    using NCS.PaperGeneration.Entities.Entities;
    using NCS.PaperGeneration.IServices;

    /// <summary>
    /// Defines Exam controller
    /// </summary>
    [RoutePrefix("api/exam")]
    public class ExamController : ApiController
    {
        /// <summary>
        /// The exam service.
        /// </summary>
        private readonly IExamService examService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamController"/> class.
        /// </summary>
        /// <param name="examService">
        /// The exam service.
        /// </param>
        public ExamController(IExamService examService)
        {
            this.examService = examService;
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
                exam = this.examService.GetById(id);                
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
