using System;
using System.Collections.Generic;

namespace CapaDatos;

public partial class Inventario
{
    public int InventarioId { get; set; }

    public int? ProductoId { get; set; }

    public int Cantidad { get; set; }

    public DateTime Fecha { get; set; }

    public string TipoMovimiento { get; set; } = null!;

    public virtual Producto? Producto { get; set; }
}
