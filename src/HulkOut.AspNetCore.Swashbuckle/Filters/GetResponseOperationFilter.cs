using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HulkOut.AspNetCore.Swashbuckle.Filters
{
  /// <inheritdoc />
  public class GetResponseOperationFilter : IOperationFilter
  {
    public void Apply(Operation operation, OperationFilterContext context)
    {
      var httpGetAttributes = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
        .Union(context.MethodInfo.GetCustomAttributes(true))
        .OfType<HttpGetAttribute>();

      if (!httpGetAttributes.Any())
      {
        return;
      }

      operation.Responses.Add(((int) HttpStatusCode.NotFound).ToString(), new Response {Description = "Not Found"});
    }
  }
}