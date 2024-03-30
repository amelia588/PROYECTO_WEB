using System;
using System.Collections.Generic;

namespace amelia.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Departamento { get; set; }

    public string? Cargo { get; set; }

    public DateOnly? FechaIngreso { get; set; }
}
