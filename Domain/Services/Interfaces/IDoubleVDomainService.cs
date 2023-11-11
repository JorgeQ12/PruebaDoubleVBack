using PruebaDoubleV.Domain.Entities;
using PruebaDoubleV.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV.Domain.Services.Interfaces
{
    public interface IDoubleVDomainService
    {
        Usuario GetLoginUser(UsuarioDTO usuario);
        Persona InsertPerson(Persona persona);
        Usuario InsertUser(Usuario usuario);

    }
}
