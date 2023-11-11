using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV.Domain.Entities
{
    public class TipoIdentificacion
    {
        [Key]
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Persona> Persona { get; set; }
    }
}
