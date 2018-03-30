using NCS.PaperGeneration.Entities.CommonEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.CompactEntities
{
    public class SectionCompact : AuditableEntity<int>
    {
        [ForeignKey("Chapter")]
        public int ChapterId { get; set; }
    }
}
