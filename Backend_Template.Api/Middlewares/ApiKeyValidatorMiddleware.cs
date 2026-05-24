using Backend_Template.Domain.Responses;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace Backend_Template.Api.Middlewares
{
    /// <summary>
    /// Clase para validar el Api Key configurado en el appsettings.
    /// </summary>
    /// <param name="next"></param>
    public class ApiKeyValidatorMiddleware(RequestDelegate next, IConfiguration configuration)
    {
        private readonly RequestDelegate _next = next;
        private readonly IConfiguration _config = configuration;

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            if (!context.Request.Headers.TryGetValue("x-api-key", out var extractedApiKey))
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                var response = new ApiResponse()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    Message = "El header x-api-key es obligatorio."
                };


                await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                return;
            }

            if (!string.Equals(extractedApiKey, _config["ApiKey"], StringComparison.Ordinal))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                var response = new ApiResponse()
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    Message = "La clave x-api-key proporcionada no es válida."
                };

                await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                return;
            }

            await _next(context);
        }
    }
}
