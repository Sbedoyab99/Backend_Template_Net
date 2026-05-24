using Backend_Template.Application.Interfaces;
using Backend_Template.Domain.Entities;
using Backend_Template.Domain.Enums;
using Backend_Template.Domain.Responses;

namespace Backend_Template.Application.Services
{
    /// <summary>
    /// Los servicios son donde se ejecuta la logica del negocio.
    /// </summary>
    public class GenericService : IGenericService
    {
        public Task<ActionResponse<Entity>> GetEntity()
        {
            Entity entity = new()
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                Message = "Has ejecutado una operacion!",
                State = EntityState.created
            };

            return Task.FromResult(ActionResponse<Entity>.Ok(entity, "Has ejecutado una operacion!"));
        }
    }
}
