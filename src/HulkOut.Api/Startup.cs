using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.Swagger.Model;

namespace HulkOut.Api
{
	public class Startup
	{
		/// <summary>
		///   Initializes a new instance of the <see cref="Startup" /> class.
		/// </summary>
		/// <param name="env">The hosting enviroment.</param>
		public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", false, true)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
				.AddEnvironmentVariables();
			Configuration = builder.Build();
		}

		/// <summary>
		///   Gets the configuration.
		/// </summary>
		/// <value>
		///   The configuration.
		/// </value>
		public IConfigurationRoot Configuration { get; }

		/// <summary>
		///   This method gets called by the runtime. Use this method to add services to the container.
		/// </summary>
		/// <param name="services">The services collection.</param>
		public void ConfigureServices(IServiceCollection services)
		{
			var configurationSection = Configuration.GetSection("App");

			ConfigureOptions(services, configurationSection);
			ConfigureSwaggerGen(services, configurationSection);

			services.AddMvc();
		}

		/// <summary>
		///   Configures the swagger gen.
		/// </summary>
		/// <param name="services">The services collection.</param>
		/// <param name="configurationSection">The configuration section.</param>
		private static void ConfigureSwaggerGen(IServiceCollection services, IConfigurationSection configurationSection)
		{
			var appOptions = configurationSection.Get<AppOptions>();

			services.AddSwaggerGen(options =>
			{
				options.SingleApiVersion(new Info
				{
					Version = appOptions.Version,
					Title = appOptions.ApplicationName,
					Description = appOptions.ApplicationDescription,
					TermsOfService = "None"
				});
			});
		}

		/// <summary>
		///   Configures the application options.
		/// </summary>
		/// <param name="services">The services collection.</param>
		/// <param name="configurationSection">The configuration section.</param>
		private static void ConfigureOptions(IServiceCollection services, IConfigurationSection configurationSection)
		{
			services.AddOptions();
			services.Configure<AppOptions>(configurationSection);
		}

		/// <summary>
		///   This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		/// </summary>
		/// <param name="app">The application.</param>
		/// <param name="env">The env.</param>
		/// <param name="loggerFactory">The logger factory.</param>
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole(Configuration.GetSection("Logging"));
			loggerFactory.AddDebug();

			/*Enabling swagger file*/
			app.UseSwagger();
			/*Enabling Swagger ui, consider doing it on Development env only*/
			app.UseSwaggerUi();
			/*Normal MVC mappings*/
			app.UseMvc();
		}
	}
}