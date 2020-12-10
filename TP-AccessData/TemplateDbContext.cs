using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TP_Domain.Entities;

namespace TP_AccessData
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        {
        }

        public DbSet<HistoriaClinica> HistoriaClinica { get; set; }
        public DbSet<Registro> Registros { get; set; }
    }
}
