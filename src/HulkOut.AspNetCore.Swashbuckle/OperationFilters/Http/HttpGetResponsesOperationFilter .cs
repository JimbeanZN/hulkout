using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HulkOut.AspNetCore.Swashbuckle.OperationFilters.Http
{
  public class HttpGetResponsesOperationFilter : IOperationFilter
  {
    public void Apply(Operation operation, OperationFilterContext context)
    {
      var getAttribute = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
        .OfType<HttpGetAttribute>()
        .FirstOrDefault();

      var getSingleItem = context.ApiDescription
        .ParameterDescriptions.Any();

      if (getAttribute == null || !getSingleItem)
      {
        return;
      }

      operation.Responses.Add(((int) HttpStatusCode.NotFound).ToString(), new Response {Description = "Not Found"});
    }
  }
}