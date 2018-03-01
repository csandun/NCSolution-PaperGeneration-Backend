using NCS.PaperGeneration.Entities.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.CompactEntities
{
    public class ChoiceCompact :  AuditableEntity<int>
    {
        public int QuestionId { get; set; }
    }
}
