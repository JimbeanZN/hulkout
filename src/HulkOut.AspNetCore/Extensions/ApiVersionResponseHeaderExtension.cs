using HulkOut.AspNetCore.Middleware;
using Microsoft.AspNetCore.Builder;

namespace HulkOut.AspNetCore.Extensions
{
  public static class ApiVersionResponseHeaderExtension
  {
    public static IApplicationBuilder UseApiVersionResponse(
      this IApplicationBuilder builder)
    {
      return builder.UseMiddleware<ApiVersionResponseHeaderMiddleware>();
    }
  }
}