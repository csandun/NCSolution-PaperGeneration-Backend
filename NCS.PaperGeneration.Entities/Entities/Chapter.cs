using NCS.PaperGeneration.Entities.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.Entities
{
    using Newtonsoft.Json;

    public class Chapter : AuditableEntity<int>
    {
        public Chapter()
        {
            this.Sections = new HashSet<Section>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        
        public virtual  ICollection<Section> Sections { get; set; }
    }
}
