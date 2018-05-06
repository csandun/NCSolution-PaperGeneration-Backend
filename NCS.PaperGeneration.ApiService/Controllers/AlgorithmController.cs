// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AlgorithmController.cs" company="NCSolution">
//   Copyright 2018
// </copyright>
// <summary>
//   Defines the ExamController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NCS.PaperGeneration.ApiService.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Web.Http;
    using NCS.PaperGeneration.Entities.Entities;
    using NCS.PaperGeneration.IServices;    

    /// <summary>
    /// Defines algorithm controller
    /// </summary>
    [RoutePrefix("api/algorithms")]
    public class AlgorithmController : ApiController
    {
        /// <summary>
        /// The algorithm service.
        /// </summary>
        private readonly IAlgorithmService algorithmService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlgorithmController"/> class. 
        /// Algorithm controller class
        /// </summary>
        /// <param name="algorithmService">
        /// The algorithm service.
        /// </param>
        public AlgorithmController(IAlgorithmService algorithmService)
        {
            this.algorithmService = algorithmService;
        }

        /// <summary>
        /// Get algorithm details
        /// </summary>
        /// <returns>The algorithm list.</returns>
        [HttpGet]
        [Route("")]
        public List<Algorithms> Get()
        {
            List<Algorithms> algorithms = null;
            try
            {
                algorithms = this.algorithmService.Get();
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                throw e;
            }

            return algorithms;
        }

        /// <summary>
        /// Get algorithm using id
        /// </summary>
        /// <param name="id">The algorithm id</param>
        /// <returns>Returns algorithm</returns>
        [HttpGet]
        [Route("{id:int}")]
        public Algorithms Get(int id)
        {
            Algorithms algorithm = null;
            try
            {
                algorithm = this.algorithmService.GetById(id);
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                throw e;
            }

            return algorithm;
        }

        /// <summary>
        /// Create new algorithm
        /// </summary>
        /// <param name="algorithms">The algorithm</param>
        [HttpPost]
        [Route("")]
        public void Post([FromBody] Algorithms algorithms)
        {            
            try
            {
                algorithms.CreatedDate = DateTime.Now;
                algorithms.CreatedBy = 1;
                this.algorithmService.Create(algorithms);
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                throw e;
            }            
        }

        /// <summary>
        /// update new algorithm
        /// </summary>
        /// <param name="algorithms">The algorithm</param>
        [HttpPut]
        [Route("")]
        public void Put([FromBody] Algorithms algorithms)
        {
            try
            {
                algorithms.CreatedDate = DateTime.Now;
                algorithms.CreatedBy = 1;
                this.algorithmService.Update(algorithms);
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
                throw e;
            }
        }
    }
}
