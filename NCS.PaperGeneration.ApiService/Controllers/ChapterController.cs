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
    using System.Diagnostics;
    using System.Linq;
    using System.Web.Http;

    using NCS.PaperGeneration.Entities.Entities;
    using NCS.PaperGeneration.IDataServices;
    using NCS.PaperGeneration.IServices;

    /// <summary>
    /// Define Chapter Repository
    /// </summary>
    [RoutePrefix("api/Chapters")]
    public class ChapterController : ApiController
    {
        /// <summary>
        /// The _chapter service.
        /// </summary>
        private readonly IChapterService chapterService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterController"/> class. 
        /// user exam questions controller.
        /// </summary>
        /// <param name="chapterService">
        /// The chapter Service.
        /// </param>
        public ChapterController(IChapterService chapterService)
        {
            this.chapterService = chapterService;
        }

        /// <summary>
        /// Get all chapter details
        /// </summary>
        /// <returns>The chapter list.</returns>
        [HttpGet]
        [Route("")]
        public List<Chapter> Get()
        {
            List<Chapter> chapters = null;
            try
            {
                chapters = this.chapterService.Get();
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                throw e;
            }

            return chapters;
        }

        /// <summary>
        /// Get chapter using id
        /// </summary>
        /// <param name="id">The chapter id</param>
        /// <returns>Returns chapter</returns>
        [HttpGet]
        [Route("{id:int}")]
        public Chapter Get(int id)
        {
            Chapter chapter = null;
            try
            {
                chapter = this.chapterService.GetById(id);
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                throw e;
            }

            return chapter;
        }

        /// <summary>
        /// Create new chapter
        /// </summary>
        /// <param name="chapter">The chapter</param>
        [HttpPost]
        [Route("")]
        public void Post([FromBody] Chapter chapter)
        {
            try
            {
                chapter.CreatedDate = DateTime.Now;
                chapter.CreatedBy = 1;
                this.chapterService.Create(chapter);
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                throw e;
            }
        }

        /// <summary>
        /// Create new chapter
        /// </summary>
        /// <param name="chapter">The chapter</param>
        [HttpPut]
        [Route("")]
        public void Put([FromBody] Chapter chapter)
        {
            try
            {
                chapter.CreatedDate = DateTime.Now;
                chapter.CreatedBy = 1;
                this.chapterService.Update(chapter);
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                throw e;
            }
        }
    }
}
