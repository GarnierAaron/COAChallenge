using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class UsuarioExceptions : Exception
    {
        public UsuarioExceptions(string mensaje) : base(mensaje)
        {

        }
    }
}
