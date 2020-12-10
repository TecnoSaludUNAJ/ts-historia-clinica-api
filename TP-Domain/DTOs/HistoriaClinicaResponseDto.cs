using System;

namespace TP_Domain.DTOs
{
    public class HistoriaClinicaResponseDto
    {
        public int HistoriaClinicaId { get; set; }
        public int RegistroId { get; set; }
        public int EspecialistaId { get; set; }
        public string MotivoConsulta { get; set; }
        public DateTime ProximaRevision { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Diagnostico { get; set; }
        public string Analisis { get; set; }
        public string Receta { get; set; }
    }
}
