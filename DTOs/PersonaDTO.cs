using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV.DTOs
{
    public class PersonaDTO
    {
        public string NombresDTO { get; set; }
        public string ApellidosDTO { get; set; }
        public string NumeroIdentificacionDTO { get; set; }
        public Guid TipoIdentificacionDTO { get; set; }
        public string TipoIdentificacionCodeDTO { get; set; }
        public string EmailDTO { get; set; }

    }
}
