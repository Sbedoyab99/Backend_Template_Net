using Backend_Template.Application.Mappers;
using Backend_Template.Domain.DTOs;
using Backend_Template.Domain.Responses;
using Backend_Template.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Template.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController(ILogger<GenericController> logger, IGenericService service) : ControllerBase
    {
        private readonly ILogger<GenericController> _logger = logger;
        private readonly IGenericService _service = service;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _logger.LogInformation("GET request received");
            var result = await _service.GetEntity();
            if (result.WasSuccess)
            {
                var response = EntityMapper.ToEntityDto(result.Result!);
                return Ok(new ApiResposeData<EntityDto>() { StatusCode = StatusCodes.Status200OK, Data = response});
            }
            return BadRequest(new ApiResponse() { StatusCode = StatusCodes.Status400BadRequest, Message = result.Message});
        }
    }
}
