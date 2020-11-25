using System;

namespace TP_Domain.DTOs
{
    public class HistoriaClinicaResponseDto
    {
        public int HistoriaClinicaId { get; set; }
        public int PacienteId { get; set; }

        public string DescripcionAnalisis { get; set; }
        public string DescripcionReceta { get; set; }
        public string MotivoConsulta { get; set; }
        public string Diagnostico { get; set; }
        public DateTime ProximaRevision { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
