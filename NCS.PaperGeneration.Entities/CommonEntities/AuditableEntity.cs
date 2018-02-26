
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.CommonEntities
{
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
      
        public DateTime CreatedDate { get; set; }

      
        public int CreatedBy { get; set; }

      
        public Nullable<DateTime> UpdatedDate { get; set; }

      
        public int? UpdatedBy { get; set; }
    }
}
