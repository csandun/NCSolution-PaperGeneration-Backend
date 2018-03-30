using NCS.PaperGeneration.Entities.Entities;
using NCS.PaperGeneration.IDataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NCS.PaperGeneration.ApiService.Controllers
{
    [RoutePrefix("api/Chapter")]
    public class ChapterController : ApiController
    {
        private readonly IChapterRepository _chapterService;

        /// <summary>
        /// user exam questions controller.
        /// </summary>
        public ChapterController(IChapterRepository chapterService)
        {
            this._chapterService = chapterService;
        }

        /// <summary>
        /// Get All Chapters as a List
        /// </summary>
        /// <returns></returns>
        [HttpGet]        
        public List<Chapter> GetChapters()
        {
            return _chapterService.Get().ToList<Chapter>();
        }

        /// <summary>
        /// Get chapter by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id:int}")]
        public Chapter GetChapterById(int id)
        {
            return _chapterService.GetById(id);
        }

        /// <summary>
        /// Update Chapter
        /// </summary>
        /// <param name="chapter"></param>
        /// <returns></returns>
        [HttpPut]
        public Chapter UpdateChapter(Chapter chapter)
        {
            _chapterService.Update(chapter);
            return _chapterService.GetById(chapter.Id);
        }

        [HttpPost]
        public void AddChapter(Chapter chapter)
        {
            try
            {
                _chapterService.Insert(chapter);
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
