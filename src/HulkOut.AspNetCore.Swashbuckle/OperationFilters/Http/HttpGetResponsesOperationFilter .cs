using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HulkOut.AspNetCore.Swashbuckle.OperationFilters.Http
{
	public class HttpGetResponsesOperationFilter : IOperationFilter
	{
		public void Apply(OpenApiOperation operation, OperationFilterContext context)
		{
			var getAttribute = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
				.OfType<HttpGetAttribute>()
				.FirstOrDefault();

			var getSingleItem = context.ApiDescription
				.ParameterDescriptions.Any();

			if (getAttribute == null || !getSingleItem) return;

			operation.Responses.Add(((int) HttpStatusCode.NotFound).ToString(),
				new OpenApiResponse {Description = "Not Found"});
		}
	}
}