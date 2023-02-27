using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Net5Middlewares.Logging
{
    public class LoggingMiddleware
    {
        readonly RequestDelegate _next;                 // we create a constructor that can get RequesDelegate Object as parameter
       //this object can handle the request and with HttpContext, it protects the lifecycle of Request/Response Pipeline
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context) // this method will executed when we call the middlewares 
        {
            try
            {
                await _next(context);
            }
            finally
            {
                string logText = $"";//"Hello MiddleWare";//{context.Request?.Method} {context.Request?.Path.Value} => {context.Response?.StatusCode}{Environment.NewLine}
                File.AppendAllText("log.txt", logText);
            }
        }
    }
}
