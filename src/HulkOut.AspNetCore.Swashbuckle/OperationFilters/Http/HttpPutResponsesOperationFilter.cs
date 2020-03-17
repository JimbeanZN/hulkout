using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HulkOut.AspNetCore.Swashbuckle.OperationFilters.Http
{
	public class HttpPutResponsesOperationFilter : IOperationFilter
	{
		public void Apply(OpenApiOperation operation, OperationFilterContext context)
		{
			var putAttribute = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
				.OfType<HttpPutAttribute>()
				.FirstOrDefault();

			if (putAttribute == null) return;

			operation.Responses.Add(((int) HttpStatusCode.BadRequest).ToString(),
				new OpenApiResponse {Description = "Bad Request"});
			operation.Responses.Add(((int) HttpStatusCode.NotFound).ToString(),
				new OpenApiResponse {Description = "Not Found"});
			operation.Responses.Add(((int) HttpStatusCode.NotModified).ToString(),
				new OpenApiResponse {Description = "Not Modified"});
		}
	}
}