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
    [RoutePrefix("api/Section")]
    public class SectionController : ApiController
    {
        private readonly ISectionService _sectionService;

        /// <summary>
        /// user exam questions controller.
        /// </summary>
        public SectionController(ISectionService sectionService)
        {
            this._sectionService = sectionService;
        }

        /// <summary>
        /// Get List of sections
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Sections")]
        public List<Section> GetSectionList()
        {
            return _sectionService.Get().ToList<Section>();
        }

        /// <summary>
        /// get section by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id:int}")]
        public Section GetSection(int id)
        {
            return _sectionService.GetById(id);
        }

        /// <summary>
        /// update section
        /// </summary>
        /// <param name="section"></param>
        /// <returns></returns>
        [HttpPut]
        public Section UpdateSection(Section section)
        {
            _sectionService.Update(section);
            return _sectionService.GetById(section.Id);
        }

        [HttpPost]
        public void AddSection(Section section)
        {
            _sectionService.Insert(section);
        }
    }
}
