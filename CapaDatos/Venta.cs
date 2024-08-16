using System;
using System.Collections.Generic;

namespace CapaDatos;

public partial class Venta
{
    public int VentaId { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Total { get; set; }

    public virtual ICollection<DetallesVentum> DetallesVenta { get; set; } = new List<DetallesVentum>();
}
