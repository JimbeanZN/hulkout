using System.Net;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HulkOut.AspNetCore.Swashbuckle.OperationFilters.Http
{
	/// <inheritdoc />
	public class HttpErrorResponsesOperationFilter : IOperationFilter
	{
		public void Apply(OpenApiOperation operation, OperationFilterContext context)
		{
			operation.Responses.Add(((int) HttpStatusCode.InternalServerError).ToString(),
				new OpenApiResponse {Description = "Internal Server Error"});
		}
	}
}