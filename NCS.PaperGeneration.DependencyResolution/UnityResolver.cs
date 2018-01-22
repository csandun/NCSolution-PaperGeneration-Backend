using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Dependencies;
using Unity;

namespace NCS.PaperGeneration.DependencyResolution
{
     public class UnityResolver : IDependencyResolver
    {
        /// <summary>
        /// The container.
        /// </summary>
        private readonly IUnityContainer container;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnityResolver" /> class. Unity Resolver.
        /// </summary>
        /// <param name = "container">The unity container.</param>
        /// <returns>
        /// The <see cref = "IUnityContainer"/>.
        /// </returns>
        public UnityResolver(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }

            this.container = container;
        }

        /// <summary>
        /// Get Service.
        /// </summary>
        /// <param name = "serviceType">The service type.</param>
        /// <returns>
        /// object unity container
        /// </returns>
        public object GetService(Type serviceType)
        {
            try
            {
                return this.container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        /// <summary>
        /// Get Services.
        /// </summary>
        /// <param name = "serviceType">The service type.</param>
        /// <returns>
        /// IEnumerable object
        /// </returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return this.container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        /// <summary>
        /// Begin Scope.
        /// </summary>
        /// <returns>
        /// IDependency Scope
        /// </returns>
        public IDependencyScope BeginScope()
        {
            var child = this.container.CreateChildContainer();
            return new UnityResolver(child);
        }

        /// <summary>
        /// Dispose container.
        /// </summary>
        public void Dispose()
        {
            this.container.Dispose();
        }
    }
}
