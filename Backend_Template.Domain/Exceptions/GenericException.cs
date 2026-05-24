using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Template.Domain.Exceptions
{
    public class GenericException
    {
        public int Code { get; set; }
        public int Status { get; set; }
        public string Message { get; set; } = null!;
    }
}
