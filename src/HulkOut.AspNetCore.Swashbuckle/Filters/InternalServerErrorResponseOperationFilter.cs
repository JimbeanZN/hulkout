using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HulkOut.AspNetCore.Swashbuckle.Filters
{
  /// <inheritdoc />
  public class InternalServerErrorResponseOperationFilter : IOperationFilter
  {
    public void Apply(Operation operation, OperationFilterContext context)
    {
      operation.Responses.Add(((int) HttpStatusCode.InternalServerError).ToString(),
        new Response {Description = "Internal Server Error"});
    }
  }
}