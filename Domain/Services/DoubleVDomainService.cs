using PruebaDoubleV.Domain.Entities;
using PruebaDoubleV.Domain.Services.Interfaces;
using PruebaDoubleV.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV.Domain.Services
{
    public class DoubleVDomainService : IDoubleVDomainService
    {
        private readonly DbContextDoubleV _context;
        public DoubleVDomainService(DbContextDoubleV context)
        {
            _context = context;
        }
      public Usuario GetLoginUser(UsuarioDTO usuario)
        {
            try
            {
                return _context.Usuario.Where(x => x.NombreUsuario.Equals(usuario.NombreUsuarioDTO) && x.Contraseña.Equals(usuario.ContraseñaDTO)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TipoIdentificacion> GetTypeDocument()
        {
            try
            {
                return _context.TipoIdentificacion.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Persona InsertPerson(Persona persona)
        {
            try
            {
                _context.Add(persona);
                _context.SaveChanges();
                return persona;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario InsertUser(Usuario usuario)
        {
            try
            {
                _context.Add(usuario);
                _context.SaveChanges();
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
