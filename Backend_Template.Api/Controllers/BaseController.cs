using Backend_Template.Domain.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Backend_Template.Api.Controllers
{
    public abstract class BaseController(ILogger logger) : ControllerBase
    {
        private readonly ILogger _logger = logger;

        protected async Task<IActionResult> ExecuteLoggedAsync(Func<Task<IActionResult>> action, [CallerMemberName] string actionName = "")
        {
            var endpointName = $"{ControllerContext.ActionDescriptor.ControllerName}.{actionName}";
            var stopwatch = Stopwatch.StartNew();

            _logger.LogInformation("Executing endpoint {Endpoint}", endpointName);

            try
            {
                var result = await action();
                _logger.LogInformation("Finished endpoint {Endpoint} in {ElapsedMs} ms", endpointName, stopwatch.ElapsedMilliseconds);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Endpoint {Endpoint} failed after {ElapsedMs} ms", endpointName, stopwatch.ElapsedMilliseconds);
                throw;
            }
        }

        protected IActionResult FromAction<T>(ActionResponse<T> response)
        {
            if (response.Success && response.Data is not null)
            {
                return StatusCode(response.StatusCode, new ApiResponseData<T>
                {
                    StatusCode = response.StatusCode,
                    Message = response.Message,
                    Data = response.Data
                });
            }

            return StatusCode(response.StatusCode, new ApiResponse
            {
                StatusCode = response.StatusCode,
                Message = response.Message
            });
        }
    }
}