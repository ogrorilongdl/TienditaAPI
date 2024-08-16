using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }

    }
}
