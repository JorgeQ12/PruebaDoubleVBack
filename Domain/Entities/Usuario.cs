using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV.Domain.Entities
{
    public class Usuario
    {
        [Key]
        public Guid Identificador { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
