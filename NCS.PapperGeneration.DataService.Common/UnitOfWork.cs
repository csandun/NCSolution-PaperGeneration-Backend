// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitOfWork.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the UnitOfWork type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NCS.PapperGeneration.DataService.Common
{
    using System;
    using System.Data.Entity;

    /// <summary>
    /// The unit of work.
    /// </summary>
    public sealed class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// The DbContextInstance
        /// </summary>
        private DbContext _dbContextInstance;

        /// <summary>
        /// Initializes a new instance of the UnitOfWork class.
        /// </summary>
        /// <param name="contextInstance">The object contextInstance</param>
        public UnitOfWork(DbContext contextInstance)
        {
            this._dbContextInstance = contextInstance;
        }

        /// <summary>
        /// Disposes the current object
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The save.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Save()
        {
            return this._dbContextInstance.SaveChanges();
        }

        /// <summary>
        /// Disposes all external resources.
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this._dbContextInstance != null)
                {
                    this._dbContextInstance.Dispose();
                    this._dbContextInstance = null;
                }
            }
        }
    }
}
