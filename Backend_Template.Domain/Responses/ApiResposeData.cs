using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Template.Domain.Responses
{
    public class ApiResposeData<T> : ApiResponse
    {
        public T? Data { get; set; }
    }
}
