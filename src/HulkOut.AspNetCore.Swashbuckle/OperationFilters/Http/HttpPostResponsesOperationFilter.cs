using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HulkOut.AspNetCore.Swashbuckle.OperationFilters.Http
{
	public class HttpPostResponsesOperationFilter : IOperationFilter
	{
		public void Apply(OpenApiOperation operation, OperationFilterContext context)
		{
			var postAttribute = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
				.OfType<HttpPostAttribute>()
				.FirstOrDefault();

			if (postAttribute == null) return;

			operation.Responses.Add(((int) HttpStatusCode.BadRequest).ToString(),
				new OpenApiResponse {Description = "Bad Request"});
		}
	}
}