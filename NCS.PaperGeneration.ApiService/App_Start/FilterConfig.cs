// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FilterConfig.cs" company="NCSolution">
//   copyright
// </copyright>
// <summary>
//   Defines the FilterConfig type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NCS.PaperGeneration.ApiService
{
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// Defines FilterConfig
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// The RegisterGlobalFilters
        /// </summary>
        /// <param name="filters">The filters</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
