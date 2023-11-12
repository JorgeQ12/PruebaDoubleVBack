using AutoMapper;
using PruebaDoubleV.Application.Services.Interfaces;
using PruebaDoubleV.Domain.Entities;
using PruebaDoubleV.Domain.Services.Interfaces;
using PruebaDoubleV.DTOs;
using PruebaDoubleV.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV.Application.Services
{
    public class DoubleVAppService : IDoubleVAppService
    {
        private readonly IMapper _mapper;
        private readonly IDoubleVDomainService _doubleVDomainService;

        public DoubleVAppService(IMapper mapper, IDoubleVDomainService doubleVDomainService)
        {
            _mapper = mapper;
            _doubleVDomainService = doubleVDomainService;
        }

        public ResultResponse<Usuario> GetLoginUser(UsuarioDTO usuario)
        {
            try
            {
                Usuario getUser = _doubleVDomainService.GetLoginUser(usuario);
                if(getUser == null)
                {
                    return new ResultResponse<Usuario>(false, getUser);
                }
                return new ResultResponse<Usuario>(true, getUser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ResultResponse<List<TipoIdentificacion>> GetTypeDocument()
        {
            try
            {
                List<TipoIdentificacion> tipoIdentificacion = _doubleVDomainService.GetTypeDocument();
                if (!tipoIdentificacion.Any())
                {
                    return new ResultResponse<List<TipoIdentificacion>>(false, tipoIdentificacion);
                }
                return new ResultResponse<List<TipoIdentificacion>>(true, tipoIdentificacion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ResultResponse<Persona> InsertPerson(PersonaDTO persona)
        {
            try
            {
                Persona insertPerson = _doubleVDomainService.InsertPerson(_mapper.Map<PersonaDTO, Persona>(persona));
                return new ResultResponse<Persona>(true,insertPerson);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ResultResponse<Usuario> InsertUser(UsuarioDTO usuario)
        {
            try
            {
                Usuario insertUsuario = _doubleVDomainService.InsertUser(_mapper.Map<UsuarioDTO, Usuario>(usuario));
                return new ResultResponse<Usuario>(true, insertUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
