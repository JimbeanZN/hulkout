using System.Web;
using System.Web.Http;

namespace HulkOut.Api
{
	public class WebApiApplication : HttpApplication
	{
		protected void Application_Start()
		{
			UnityConfig.RegisterComponents();
			GlobalConfiguration.Configure(WebApiConfig.Register);
		}
	}
}