// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SectionController.cs" company="NCSolution">
//      Copyright 2018
// </copyright>
// <summary>
//   Defines the SectionController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NCS.PaperGeneration.ApiService.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using NCS.PaperGeneration.Entities.Entities;
    using NCS.PaperGeneration.IServices;

    /// <summary>
    /// Defines SectionController
    /// </summary>
    [RoutePrefix("api/Section")]
    public class SectionController : ApiController
    {
        /// <summary>
        /// The section service.
        /// </summary>
        private readonly ISectionService sectionService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SectionController"/> class. 
        /// user exam questions controller.
        /// </summary>
        /// <param name="sectionService">
        /// The section Service. 
        /// </param>
        public SectionController(ISectionService sectionService)
        {
            this.sectionService = sectionService;
        }

        /// <summary>
        /// Get List of sections
        /// </summary>
        /// <returns>Returns section list</returns>
        [HttpGet]
        [Route("Sections")]
        public List<Section> GetSectionList()
        {
            return this.sectionService.Get();
        }

        /// <summary>
        /// get section by id
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns section</returns>
        [HttpGet]
        [Route("{id:int}")]
        public Section GetSection(int id)
        {
            return this.sectionService.GetById(id);
        }

        /// <summary>
        /// update section
        /// </summary>
        /// <param name="section">The section object</param>
        /// <returns>Returns section</returns>
        [HttpPut]
        public Section UpdateSection(Section section)
        {
            return this.sectionService.Update(section);
            //// return this.sectionService.GetById(section.Id);
        }

        /// <summary>
        /// Add section
        /// </summary>
        /// <param name="section">The section object</param>
        [HttpPost]
        public void AddSection(Section section)
        {
            this.sectionService.Create(section);
        }
    }
}
