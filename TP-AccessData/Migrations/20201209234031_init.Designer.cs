﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP_AccessData;

namespace TP_AccessData.Migrations
{
    [DbContext(typeof(TemplateDbContext))]
    [Migration("20201209234031_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TP_Domain.Entities.HistoriaClinica", b =>
                {
                    b.Property<int>("HistoriaClinicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("RegistroId")
                        .HasColumnType("int");

                    b.HasKey("HistoriaClinicaId");

                    b.ToTable("HistoriaClinica");
                });

            modelBuilder.Entity("TP_Domain.Entities.Registro", b =>
                {
                    b.Property<int>("RegistroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Analisis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EspecialistaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("MotivoConsulta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProximaRevision")
                        .HasColumnType("datetime2");

                    b.Property<string>("Receta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegistroId");

                    b.ToTable("Registros");
                });
#pragma warning restore 612, 618
        }
    }
}
