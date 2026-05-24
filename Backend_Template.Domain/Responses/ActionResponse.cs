using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Template.Domain.Responses
{
    public class ActionResponse<T>(bool wasSuccess, string? message, T? data)
    {
        public bool WasSuccess { get; set; } = wasSuccess;
        public string? Message { get; set; } = message;
        public T? Result { get; set; } = data;
    }
}
