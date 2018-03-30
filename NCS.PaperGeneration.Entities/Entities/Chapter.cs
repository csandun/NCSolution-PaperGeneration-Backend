using NCS.PaperGeneration.Entities.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.Entities
{
    public class Chapter : AuditableEntity<int>
    {
        public string ChapterName { get; set; }
        public string ChapterDescription { get; set; }
    }
}
