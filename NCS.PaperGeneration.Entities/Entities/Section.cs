using NCS.PaperGeneration.Entities.CommonEntities;
using NCS.PaperGeneration.Entities.CompactEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.Entities
{
    public class Section : SectionCompact
    {
        public string SectionName { get; set; }
        public virtual Chapter Chapter { get; set; }
    }
}
