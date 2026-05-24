using Backend_Template.Domain.Entities;
using Backend_Template.Domain.Enums;
using Backend_Template.Domain.Responses;
using Backend_Template.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Template.Infrastructure.Services
{
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

            return Task.FromResult<ActionResponse<Entity>>(new ActionResponse<Entity>(true, null, entity));
        }
    }
}
