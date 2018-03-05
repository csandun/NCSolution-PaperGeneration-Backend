using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.CommonEntities
{
    public abstract class Entity<T> : BaseEntity, IEntitiy<T>
    {
        [Key]
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public virtual T Id { get; set; }
    }
}
