using CapaDatos;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public  class CProducto: IProductos
    {

        private TiendaVideojuegosContext db;

        public CProducto(TiendaVideojuegosContext db)
        {
            
            this.db = db;
        }

        public List<Producto>GetProductos()
        {


            return db.Productos.ToList();
        }

        

    }
}
