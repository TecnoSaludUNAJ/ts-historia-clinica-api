﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP_AccessData;

namespace TP_AccessData.Migrations
{
    [DbContext(typeof(TemplateDbContext))]
    partial class TemplateDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TP_Domain.Entities.Analisis", b =>
                {
                    b.Property<int>("AnalisisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionAnalisis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegistroId")
                        .HasColumnType("int");

                    b.HasKey("AnalisisId");

                    b.HasIndex("RegistroId");

                    b.ToTable("Analisis");
                });

            modelBuilder.Entity("TP_Domain.Entities.HistoriaClinica", b =>
                {
                    b.Property<int>("HistoriaClinicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("HistoriaClinicaId");

                    b.ToTable("HistoriaClinica");
                });

            modelBuilder.Entity("TP_Domain.Entities.Receta", b =>
                {
                    b.Property<int>("RecetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionReceta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegistroId")
                        .HasColumnType("int");

                    b.HasKey("RecetaId");

                    b.HasIndex("RegistroId");

                    b.ToTable("Receta");
                });

            modelBuilder.Entity("TP_Domain.Entities.Registro", b =>
                {
                    b.Property<int>("RegistroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EspecialistaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.Property<string>("MotivoConsulta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProximaRevision")
                        .HasColumnType("datetime2");

                    b.HasKey("RegistroId");

                    b.HasIndex("HistoriaClinicaId");

                    b.ToTable("Registro");
                });

            modelBuilder.Entity("TP_Domain.Entities.Analisis", b =>
                {
                    b.HasOne("TP_Domain.Entities.Registro", "Registro")
                        .WithMany("AnalisisNavigator")
                        .HasForeignKey("RegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP_Domain.Entities.Receta", b =>
                {
                    b.HasOne("TP_Domain.Entities.Registro", "Registro")
                        .WithMany("RecetaNavigator")
                        .HasForeignKey("RegistroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP_Domain.Entities.Registro", b =>
                {
                    b.HasOne("TP_Domain.Entities.HistoriaClinica", "HistoriaClinica")
                        .WithMany("RegistroNavigator")
                        .HasForeignKey("HistoriaClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
