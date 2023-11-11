using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV.Domain.Entities
{
    public class Persona
    {
        [Key]
        public Guid Identificador { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroIdentificacion { get; set; }
        public Guid TipoIdentificacion { get; set; }

        [ForeignKey("TipoIdentificacion")]
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string IdentificacionCompleta { get; set; }
        public string NombresApellidos { get; set; }


        public virtual TipoIdentificacion TipoIdentificacionNavigation { get; set; }
    }
}
