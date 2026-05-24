using Backend_Template.Domain.Entities;
using Backend_Template.Domain.Responses;

namespace Backend_Template.Application.Interfaces
{
    public interface IGenericService
    {
        Task<ActionResponse<Entity>> GetEntity();
    }
}
