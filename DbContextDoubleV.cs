using Microsoft.EntityFrameworkCore;
using PruebaDoubleV.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDoubleV
{
    public class DbContextDoubleV : DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TipoIdentificacion> TipoIdentificacion { get; set; }
        public DbContextDoubleV(DbContextOptions<DbContextDoubleV> options) : base(options)
        {

        }
    }
}
