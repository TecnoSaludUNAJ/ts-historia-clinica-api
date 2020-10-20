using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Domain.DTOs
{
    public class RegistroDto
    {
        public string MotivoConsulta { get; set; }
        public string Diagnostico { get; set; }
        public DateTime ProximaRevision { get; set; }
        public int EspecialistaId { get; set; }
        public int HistoriaClinicaId { get; set; }

    }
}
