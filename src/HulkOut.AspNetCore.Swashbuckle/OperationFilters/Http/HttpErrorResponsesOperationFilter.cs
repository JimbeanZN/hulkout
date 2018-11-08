using System.Net;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HulkOut.AspNetCore.Swashbuckle.OperationFilters.Http
{
  /// <inheritdoc />
  public class HttpErrorResponsesOperationFilter : IOperationFilter
  {
    public void Apply(Operation operation, OperationFilterContext context)
    {
      operation.Responses.Add(((int) HttpStatusCode.InternalServerError).ToString(),
        new Response {Description = "Internal Server Error"});
    }
  }
}