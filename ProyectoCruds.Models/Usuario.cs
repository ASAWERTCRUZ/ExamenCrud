using System;
using System.Collections.Generic;

namespace ProeyectoCrud.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime? FechaNacimiento { get; set; }
        public string? Genero { get; set; }
        public string? Ciudad { get; set; }
        public string? Pais { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
