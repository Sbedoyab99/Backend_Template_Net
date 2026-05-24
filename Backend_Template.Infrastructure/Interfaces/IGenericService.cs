using Backend_Template.Domain.Entities;
using Backend_Template.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Template.Infrastructure.Interfaces
{
    public interface IGenericService
    {
        Task<ActionResponse<Entity>> GetEntity();
    }
}
