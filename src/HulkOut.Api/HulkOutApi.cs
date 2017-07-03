using System.Collections.Generic;
using System.Fabric;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.ServiceFabric.Services.Communication.AspNetCore;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;

namespace HulkOut.Api
{
	/// <summary>
	///   The FabricRuntime creates an instance of this class for each service type instance.
	/// </summary>
	internal sealed class HulkOutApi : StatelessService
	{
		public HulkOutApi(StatelessServiceContext context)
			: base(context)
		{
		}

		/// <summary>
		///   Optional override to create listeners (like tcp, http) for this service instance.
		/// </summary>
		/// <returns>The collection of listeners.</returns>
		protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
		{
			return new[]
			{
				new ServiceInstanceListener(serviceContext =>
					new WebListenerCommunicationListener(serviceContext, "HulkOutApiServiceEndpoint", (url, listener) =>
					{
						ServiceEventSource.Current.ServiceMessage(serviceContext, $"Starting WebListener on {url}");

						return new WebHostBuilder().UseWebListener()
							.ConfigureServices(
								services => services
									.AddSingleton(serviceContext))
							.UseContentRoot(Directory.GetCurrentDirectory())
							.UseStartup<Startup>()
							.UseApplicationInsights()
							.UseServiceFabricIntegration(listener, ServiceFabricIntegrationOptions.None)
							.UseUrls(url)
							.Build();
					}))
			};
		}
	}
}