﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaDoubleV;

namespace PruebaDoubleV.Migrations
{
    [DbContext(typeof(DbContextDoubleV))]
    [Migration("20231111021606_Version1.0")]
    partial class Version10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PruebaDoubleV.Domain.Entities.Persona", b =>
                {
                    b.Property<Guid>("Identificador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentificacionCompleta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombresApellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroIdentificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TipoIdentificacion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TipoIdentificacionNavigationID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Identificador");

                    b.HasIndex("TipoIdentificacionNavigationID");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("PruebaDoubleV.Domain.Entities.TipoIdentificacion", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipoIdentificacion");
                });

            modelBuilder.Entity("PruebaDoubleV.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Identificador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Identificador");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("PruebaDoubleV.Domain.Entities.Persona", b =>
                {
                    b.HasOne("PruebaDoubleV.Domain.Entities.TipoIdentificacion", "TipoIdentificacionNavigation")
                        .WithMany("Persona")
                        .HasForeignKey("TipoIdentificacionNavigationID");

                    b.Navigation("TipoIdentificacionNavigation");
                });

            modelBuilder.Entity("PruebaDoubleV.Domain.Entities.TipoIdentificacion", b =>
                {
                    b.Navigation("Persona");
                });
#pragma warning restore 612, 618
        }
    }
}
