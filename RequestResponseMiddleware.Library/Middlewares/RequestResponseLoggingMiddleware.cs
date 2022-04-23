using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseMiddleware.Library.Middlewares
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate next;

        public async Task Invoke(HttpContext context)
        {
            //no response
            await next(context);
            //response
        }
    }
}
