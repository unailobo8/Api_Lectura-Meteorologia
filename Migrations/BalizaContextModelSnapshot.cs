﻿// <auto-generated />
using Api_base.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api_base.Migrations
{
    [DbContext(typeof(BalizaContext))]
    partial class BalizaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Api_base.Models.Balizas", b =>
                {
                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Humedad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precipitacion_acumulada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Velocidad_Viento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ultimaHora")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Municipio");

                    b.ToTable("Balizas");
                });
#pragma warning restore 612, 618
        }
    }
}