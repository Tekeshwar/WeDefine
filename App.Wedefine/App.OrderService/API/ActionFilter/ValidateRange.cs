using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace App.OrderService.API.ActionFilter
{
    public class ValidateRange:ActionFilterAttribute
    {
        private readonly int _min;
        private readonly int _max;
        private readonly string _parameterName;
        public ValidateRange(string parameterName, int min, int max)
        {
            _min = min;
            _max = max; 
            _parameterName = parameterName;
        }

        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if(context.ActionArguments.TryGetValue(_parameterName, out var value) && value is int intValue)
            {
                // If the parameter is out of the valid range, return a Bad Request result
                if (intValue < _min || intValue > _max)
                {
                    context.Result = new BadRequestObjectResult(
                        $"{_parameterName} must be between {_min} and {_max}. You entered: {intValue}.");
                }
            }
            return base.OnActionExecutionAsync(context, next);
        }
    }
}
