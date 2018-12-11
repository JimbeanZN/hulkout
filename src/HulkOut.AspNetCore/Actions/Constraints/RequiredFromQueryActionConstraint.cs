using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace HulkOut.AspNetCore.Actions.Constraints
{
  /// <summary>
  /// Credit: https://www.strathweb.com/2016/09/required-query-string-parameters-in-asp-net-core-mvc/
  /// </summary>
  public class RequiredFromQueryActionConstraint : IActionConstraint
  {
    private readonly string _parameter;
 
    public RequiredFromQueryActionConstraint(string parameter)
    {
      _parameter = parameter;
    }
 
    public int Order => 999;
 
    public bool Accept(ActionConstraintContext context)
    {
      return context.RouteContext.HttpContext.Request.Query.ContainsKey(_parameter);
    }
  }
}
