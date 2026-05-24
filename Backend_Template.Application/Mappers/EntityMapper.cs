using Backend_Template.Domain.DTOs;
using Backend_Template.Domain.Entities;

namespace Backend_Template.Application.Mappers
{
    public static class EntityMapper
    {
        public static EntityDto ToEntityDto(Entity entity)
        {
            return new EntityDto
            {
                Message = entity.Message
            };
        }
    }
}
