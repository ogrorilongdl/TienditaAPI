using System;
using System.Collections.Generic;

namespace CapaDatos;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public virtual ICollection<DetallesVentum> DetallesVenta { get; set; } = new List<DetallesVentum>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();
}
