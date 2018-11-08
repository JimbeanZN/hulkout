using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HulkOut.AspNetCore.Swashbuckle.OperationFilters.Http
{
  public class HttpPostResponsesOperationFilter : IOperationFilter
  {
    public void Apply(Operation operation, OperationFilterContext context)
    {
      var postAttribute = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
        .OfType<HttpPostAttribute>()
        .FirstOrDefault();

      if (postAttribute == null)
      {
        return;
      }

      operation.Responses.Add(((int) HttpStatusCode.BadRequest).ToString(), new Response {Description = "Bad Request"});
    }
  }
}