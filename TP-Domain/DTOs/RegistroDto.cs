using System;

namespace TP_Domain.DTOs
{
    public class RegistroDTO
    {
        public int EspecialistaId { get; set; }
        public string MotivoConsulta { get; set; }
        public DateTime ProximaRevision { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Diagnostico { get; set; }
        public string Analisis { get; set; }
        public string Receta { get; set; }
        public int pacienteId { get; set; }
    }
}
