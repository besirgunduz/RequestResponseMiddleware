using Microsoft.AspNetCore.Http;
using RequestResponseMiddleware.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseMiddleware.Library.Middlewares
{
    public class RequestResponseLoggingMiddleware : BaseRequestResponseMiddleware
    {
        public RequestResponseLoggingMiddleware(RequestDelegate next, ILogWriter logWriter) :
            base(next, logWriter)
        {
        }

        public async Task Invoke(HttpContext context)
        {
            await BaseMiddlewareInvoke(context);
        }
    }
}
