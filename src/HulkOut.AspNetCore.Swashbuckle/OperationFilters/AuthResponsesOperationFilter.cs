using System.Linq;
using System.Net;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HulkOut.AspNetCore.Swashbuckle.OperationFilters
{
  public class AuthResponsesOperationFilter : IOperationFilter
  {
    public void Apply(Operation operation, OperationFilterContext context)
    {
      var authAttribute = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
        .OfType<Authorization>()
        .FirstOrDefault();

      if (authAttribute == null)
      {
        return;
      }

      operation.Responses.Add(((int) HttpStatusCode.Unauthorized).ToString(),
        new Response {Description = "Unauthorized"});
      operation.Responses.Add(((int) HttpStatusCode.Forbidden).ToString(), new Response {Description = "Forbidden"});
    }
  }
}