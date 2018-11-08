using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HulkOut.AspNetCore.Swashbuckle.OperationFilters.Http
{
  public class HttpAllResponsesOperationFilter : IOperationFilter
  {
    public void Apply(Operation operation, OperationFilterContext context)
    {
      var httpGetResponsesOperationFilter = new HttpGetResponsesOperationFilter();
      httpGetResponsesOperationFilter.Apply(operation, context);

      var httpPostResponsesOperationFilter = new HttpPostResponsesOperationFilter();
      httpPostResponsesOperationFilter.Apply(operation, context);

      var httpPutResponsesOperationFilter = new HttpPutResponsesOperationFilter();
      httpPutResponsesOperationFilter.Apply(operation, context);

      var httpDeleteResponsesOperationFilter = new HttpDeleteResponsesOperationFilter();
      httpDeleteResponsesOperationFilter.Apply(operation, context);

      var httpErrorResponsesOperationFilter = new HttpErrorResponsesOperationFilter();
      httpErrorResponsesOperationFilter.Apply(operation, context);
    }
  }
}