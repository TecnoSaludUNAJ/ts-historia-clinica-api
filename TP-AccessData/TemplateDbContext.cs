using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;
using TP_Domain.Entities;

namespace TP_AccessData
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        {
        }

        public DbSet<Analisis> AnalisisList { get; set; }
        public DbSet<HistoriaClinica> HistoriaClinicaList { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Registro> Registros { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                entityType.SetTableName(entityType.DisplayName());
            }
     
        }
    }
}
