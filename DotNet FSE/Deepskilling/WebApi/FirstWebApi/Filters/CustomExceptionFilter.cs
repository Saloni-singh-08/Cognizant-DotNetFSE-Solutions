using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FirstWebApi.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            string errorMessage = context.Exception.Message;

            File.AppendAllText(
                "ErrorLog.txt",
                $"{DateTime.Now} : {errorMessage}{Environment.NewLine}"
            );

            context.Result = new ObjectResult(errorMessage)
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            context.ExceptionHandled = true;
        }
    }
}