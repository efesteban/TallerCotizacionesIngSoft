﻿// <auto-generated />
using Cotizaciones.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace Cotizaciones.Migrations
{
    [DbContext(typeof(CotizacionesContext))]
    [Migration("20180104002125_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Cotizaciones.Models.Cotizacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteID");

                    b.Property<string>("Descripcion");

                    b.Property<bool>("Estado");

                    b.Property<string>("Fecha");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Cotizaciones");
                });

            modelBuilder.Entity("Cotizaciones.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Materno");

                    b.Property<string>("Nombre");

                    b.Property<string>("Paterno");

                    b.Property<string>("Rut");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Cotizaciones.Models.Cliente", b =>
                {
                    b.HasBaseType("Cotizaciones.Models.Persona");


                    b.ToTable("Cliente");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("Cotizaciones.Models.Usuario", b =>
                {
                    b.HasBaseType("Cotizaciones.Models.Persona");

                    b.Property<string>("Contraseña");

                    b.Property<int>("Perfil");

                    b.ToTable("Usuario");

                    b.HasDiscriminator().HasValue("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
