using Microsoft.Practices.Unity;
using System.Web.Http;
using HulkOut.Data.EF;
using HulkOut.Data.EF.Auditing;
using HulkOut.Interfaces.Auditing;
using Unity.WebApi;

namespace HulkOut.Api
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();

			// register all your components with the container here
			// it is NOT necessary to register your controllers

			// e.g. container.RegisterType<ITestService, TestService>();

			container.RegisterType<IAuditRepository, AuditRepository>();

			GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
		}
	}
}