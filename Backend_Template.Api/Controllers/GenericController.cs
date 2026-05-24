using Backend_Template.Application.Mappers;
using Backend_Template.Domain.DTOs;
using Backend_Template.Domain.Responses;
using Backend_Template.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Template.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController(ILogger<GenericController> logger, IGenericService service) : BaseController(logger)
    {
        private readonly ILogger<GenericController> _logger = logger;
        private readonly IGenericService _service = service;

        [HttpGet]
        public Task<IActionResult> Get() => ExecuteLoggedAsync(async () => FromAction(await _service.GetEntity()));
    }
}
