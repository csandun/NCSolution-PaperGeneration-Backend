using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.CommonEntities
{
    /// <summary>
    /// The i entitiy.
    /// </summary>
    /// <typeparam name="T"> common type
    /// </typeparam>
    public interface IEntitiy<T>
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        T Id { get; set; }
    }
}
