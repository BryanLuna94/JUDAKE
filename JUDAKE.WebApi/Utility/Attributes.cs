using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace JUDAKE.WebApi.Utility
{
    public class Attributes
    {
        public class ExcepcionAttribute : ExceptionFilterAttribute
        {
            public override void OnException(HttpActionExecutedContext context)
            {
                Functions.MessageError(context.Exception);
                if (context.Exception is NotImplementedException)
                {
                    context.Response = new HttpResponseMessage(HttpStatusCode.NotImplemented);
                }
                context.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
    }
}