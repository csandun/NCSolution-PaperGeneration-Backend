// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebApiConfig.cs" company="dd">
//   copyright
// </copyright>
// <summary>
//   Defines the WebApiConfig type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NCS.PaperGeneration.ApiService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Cors;

    using NCS.PaperGeneration.DependencyResolution;

    using Unity;

    /// <summary>
    /// Defines the WebApiConfig
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// The register.
        /// </summary>
        /// <param name="config">
        /// The config.
        /// </param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Enable cors
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            var container = new UnityContainer();
            IocRegister.RegisterAll(container);
            config.DependencyResolver = new UnityResolver(container);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
        }
    }
}
