using System.Linq;
using HulkOut.AspNetCore.Actions.Constraints;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace HulkOut.AspNetCore.Attributes
{
  /// <summary>
  /// Credit: https://www.strathweb.com/2016/09/required-query-string-parameters-in-asp-net-core-mvc/
  /// </summary>
  public class RequiredFromQueryAttribute : FromQueryAttribute, IParameterModelConvention
  {
    public void Apply(ParameterModel parameter)
    {
      if (parameter.Action.Selectors != null && parameter.Action.Selectors.Any())
      {
        parameter.Action.Selectors.Last().ActionConstraints.Add(new RequiredFromQueryActionConstraint(parameter.BindingInfo?.BinderModelName ?? parameter.ParameterName));
      }
    }
  }
}
