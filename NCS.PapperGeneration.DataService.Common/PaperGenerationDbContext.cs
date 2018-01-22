// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaperGenerationDbContext.cs" company="">
//   
// </copyright>
// <summary>
//   The paper generation db context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using NCS.PaperGeneration.Entities.Entities;

namespace NCS.PapperGeneration.DataService.Common
{
    using System.Data.Entity;

    /// <summary>
    /// The paper generation db context.
    /// </summary>
    public class PaperGenerationDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaperGenerationDbContext"/> class.
        /// </summary>
        public PaperGenerationDbContext() : base("PaperGenerationDbContext")
        {
        }

        public DbSet<Exam> Exams { get; set; }
    }
}
