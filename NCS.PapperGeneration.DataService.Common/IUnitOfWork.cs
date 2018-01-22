// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitOfWork.cs" company="">
//   
// </copyright>
// <summary>
//   The UnitOfWork interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NCS.PapperGeneration.DataService.Common
{
    using System;

    /// <summary>
    /// The UnitOfWork interface.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// The save.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int Save();
    }
}
