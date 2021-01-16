using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_Ecommerce.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class LoginMiddleware
    {
        private readonly RequestDelegate _next;

        public LoginMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var path = httpContext.Request.Path;
            if (path.HasValue && ((path.Value.StartsWith("/admin") || path.Value.StartsWith("/Admin"))))
            {
                if (httpContext.Session.GetString("user") == null)
                {
                    httpContext.Response.Redirect("/Login");
                }
                else
                {
                    JObject us = JObject.Parse(httpContext.Session.GetString("user"));
                    // Rule = 0 is User
                    if (Int32.Parse(us.SelectToken("QuyenHan").ToString()) == 0)
                        httpContext.Response.Redirect("/");
                    // Rule = 1 is Admin
                    else
                        return _next(httpContext);
                }
            }
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LoginMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoginMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoginMiddleware>();
        }
    }
}
