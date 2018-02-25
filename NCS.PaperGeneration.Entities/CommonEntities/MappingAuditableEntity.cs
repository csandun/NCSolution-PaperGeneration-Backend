using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.CommonEntities
{
    public class MappingAuditableEntity : IAuditableEntity
    {
        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public Nullable<DateTime> UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }
    }
}
