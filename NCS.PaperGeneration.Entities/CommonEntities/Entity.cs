using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.CommonEntities
{
    public abstract class Entity<T> : BaseEntity, IEntitiy<T>
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public virtual T Id { get; set; }
    }
}
