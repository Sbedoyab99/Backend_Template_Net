using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Template.Domain.Responses
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
    }
}
