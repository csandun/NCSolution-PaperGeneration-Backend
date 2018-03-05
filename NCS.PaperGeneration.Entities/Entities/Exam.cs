using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.Entities
{
    using NCS.PaperGeneration.Entities.CompactEntities;

    /// <summary>
    /// The exam.
    /// </summary>
    public class Exam : ExamCompact
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the total questions.
        /// </summary>
        public int TotalQuestions { get; set; }
    }
}
