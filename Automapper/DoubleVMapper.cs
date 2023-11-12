using AutoMapper;
using PruebaDoubleV.Domain.Entities;
using PruebaDoubleV.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV.Automapper
{
    public class DoubleVMapper : Profile
    {
        public DoubleVMapper()
        {
            CreateMap<PersonaDTO, Persona>()
                .ForMember(target => target.Identificador, opt => opt.MapFrom(source => Guid.NewGuid()))
                .ForMember(target => target.Nombres, opt => opt.MapFrom(source => source.NombresDTO))
                .ForMember(target => target.Apellidos, opt => opt.MapFrom(source => source.ApellidosDTO))
                .ForMember(target => target.NumeroIdentificacion, opt => opt.MapFrom(source => source.NumeroIdentificacionDTO))
                .ForMember(target => target.Email, opt => opt.MapFrom(source => source.EmailDTO))
                .ForMember(target => target.FechaCreacion, opt => opt.MapFrom(source => DateTime.Now))
                .ForMember(target => target.TipoIdentificacion, opt => opt.MapFrom(source => source.TipoIdentificacionDTO))
                .ForMember(target => target.IdentificacionCompleta, opt => opt.MapFrom(source => $"{source.TipoIdentificacionCodeDTO} - {source.NumeroIdentificacionDTO}"))
                .ForMember(target => target.NombresApellidos, opt => opt.MapFrom(source => $"{source.NombresDTO} - {source.ApellidosDTO}"));

            CreateMap<UsuarioDTO, Usuario>()
                .ForMember(target => target.Identificador, opt => opt.MapFrom(source => Guid.NewGuid()))
                .ForMember(target => target.NombreUsuario, opt => opt.MapFrom(source => source.NombreUsuarioDTO))
                .ForMember(target => target.Contraseña, opt => opt.MapFrom(source => source.ContraseñaDTO))
                .ForMember(target => target.FechaCreacion, opt => opt.MapFrom(source => DateTime.Now));
        }
    }
}
