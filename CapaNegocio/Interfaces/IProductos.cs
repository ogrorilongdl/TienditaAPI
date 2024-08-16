using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio.Interfaces
{
    public interface IProductos
    {

        List<Producto> GetProductos();
        
    }
}
