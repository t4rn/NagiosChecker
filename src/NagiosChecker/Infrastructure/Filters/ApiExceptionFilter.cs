using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NagiosChecker.DataModel;
using System;

namespace NagiosChecker.Infrastructure.Filters
{
    public class ApiExceptionFilter : ExceptionFilterAttribute
    {
        private readonly ILogService _log;

        public ApiExceptionFilter(ILogService log)
        {
            _log = log;
        }

        public override void OnException(ExceptionContext context)
        {
            ApiError apiError = null;
            string controller = context.RouteData.Values["controller"]?.ToString();
            string action = context.RouteData.Values["action"]?.ToString();

            if (context.Exception is UnauthorizedAccessException)
            {
                apiError = new ApiError("Unauthorized Access");
                context.HttpContext.Response.StatusCode = 401;

                _log.Exception(context.Exception.GetBaseException(),
                    $"UnauthorizedAccessException Ex in {controller}/{action}");
            }
            else
            {
                string msg = context.Exception.GetBaseException().Message;

                apiError = new ApiError(msg);
                //apiError.stackTrace = context.Exception.StackTrace;

                context.HttpContext.Response.StatusCode = 500;

                _log.Exception(context.Exception.GetBaseException(),
                    $"Ex in {controller}/{action}");
            }

            context.Result = new JsonResult(apiError);

            base.OnException(context);
        }
    }
}
