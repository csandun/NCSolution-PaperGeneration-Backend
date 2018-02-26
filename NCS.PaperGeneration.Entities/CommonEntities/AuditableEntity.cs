
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.CommonEntities
{
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        [JsonIgnore]
        public DateTime CreatedDate { get; set; }

        [JsonIgnore]
        public int CreatedBy { get; set; }

        [JsonIgnore]
        public Nullable<DateTime> UpdatedDate { get; set; }

        [JsonIgnore]
        public int? UpdatedBy { get; set; }
    }
}
