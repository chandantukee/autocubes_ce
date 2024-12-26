using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AutoCubes.Shared.Api
{
    public class ApiResponseWrapper<TResponse> : IActionResult
    {
        private readonly TResponse _response;
        private readonly int _statusCode;

        public ApiResponseWrapper(TResponse response,HttpStatusCode statusCode)
        {
            _response = response;
            _statusCode = Convert.ToInt32(statusCode);
        }
        public ApiResponseWrapper(TResponse response)
        {
            _response = response;
        }
        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(_response)
            {
                StatusCode = _statusCode > 0 ? _statusCode : context.HttpContext.Response.StatusCode,
                DeclaredType = typeof(HttpResponseMessage)
            };
            context.HttpContext.Response.ContentType = "application/json";
            await objectResult.ExecuteResultAsync(context);
        }
    }
}
