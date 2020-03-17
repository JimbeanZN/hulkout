using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HulkOut.AspNetCore.Swashbuckle.OperationFilters.Http
{
	public class HttpDeleteResponsesOperationFilter : IOperationFilter
	{
		public void Apply(OpenApiOperation operation, OperationFilterContext context)
		{
			var deleteAttribute = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
				.OfType<HttpDeleteAttribute>()
				.FirstOrDefault();

			if (deleteAttribute == null) return;

			operation.Responses.Add(((int) HttpStatusCode.NotFound).ToString(),
				new OpenApiResponse {Description = "Not Found"});
			operation.Responses.Add(((int) HttpStatusCode.NotImplemented).ToString(),
				new OpenApiResponse {Description = "Not Implemented"});
		}
	}
}