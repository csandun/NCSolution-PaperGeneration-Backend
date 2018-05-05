// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChapterController.cs" company="NCSolution">
//   Copyright 2018
// </copyright>
// <summary>
//   Define Chapter Repos    itory
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NCS.PaperGeneration.ApiService.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using NCS.PaperGeneration.Entities.Entities;
    using NCS.PaperGeneration.IDataServices;

    /// <summary>
    /// Define Chapter Repository
    /// </summary>
    [RoutePrefix("api/Chapter")]
    public class ChapterController : ApiController
    {
        /// <summary>
        /// The _chapter service.
        /// </summary>
        private readonly IChapterRepository chapterService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterController"/> class. 
        /// user exam questions controller.
        /// </summary>
        /// <param name="chapterService">
        /// The chapter Service.
        /// </param>
        public ChapterController(IChapterRepository chapterService)
        {
            this.chapterService = chapterService;
        }

        /// <summary>
        /// Get All Chapters as a List
        /// </summary>
        /// <returns>Returns chapter list</returns>
        [Authorize(Roles = "admin")]
        [HttpGet]        
        public List<Chapter> GetChapters()
        {
            var a = this.chapterService.Get().ToList<Chapter>();
            return a;
        }

        /// <summary>
        /// Get chapter by id
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns chapter</returns>
        [HttpGet]
        [Route("{id:int}")]
        public Chapter GetChapterById(int id)
        {
            return this.chapterService.GetById(id);
        }

        /// <summary>
        /// Update Chapter
        /// </summary>
        /// <param name="chapter">The chapter</param>
        [HttpPut]
        public void UpdateChapter(Chapter chapter)
        {
            this.chapterService.Update(chapter);            
        }

        /// <summary>
        /// Add Chapter
        /// </summary>
        /// <param name="chapter">The chapter object</param>
        [HttpPost]
        public void AddChapter(Chapter chapter)
        {
            try
            {
                this.chapterService.Insert(chapter);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
