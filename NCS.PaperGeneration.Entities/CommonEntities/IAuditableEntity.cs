using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.CommonEntities
{
    public interface IAuditableEntity
    {
        DateTime CreatedDate { get; set; }

        int CreatedBy { get; set; }

        Nullable<DateTime> UpdatedDate { get; set; }

        int? UpdatedBy { get; set; }
    }
}
