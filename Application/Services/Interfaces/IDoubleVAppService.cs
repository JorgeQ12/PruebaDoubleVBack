using PruebaDoubleV.Domain.Entities;
using PruebaDoubleV.DTOs;
using PruebaDoubleV.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV.Application.Services.Interfaces
{
    public interface IDoubleVAppService
    {
        ResultResponse<Usuario> GetLoginUser(UsuarioDTO usuario);
        ResultResponse<Persona> InsertPerson(PersonaDTO persona);
        ResultResponse<Usuario> InsertUser(UsuarioDTO usuario);
    }
}
