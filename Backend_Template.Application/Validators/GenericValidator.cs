using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_Template.Application.Validators
{
    /// <summary>
    /// Clase Generica para crear tus validadores, puedes crearlos en esta misma clase o crear clases especializadas para cada validador dependiendo de su funcionalidad.
    /// </summary>
    public static class GenericValidator
    {
        public static bool ValidateString(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            return true;
        }
    }
}
