﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Domain.DTOs
{
    public class HistoriaClinicaResponseDto
    {
        public int HistoriaClinicaId { get; set; }
        public int PacienteId { get; set; }

        public string AnalisisDescripcion { get; set; }
        public string RecetaDescripcion { get; set; }
        public string MotivoConsulta { get; set; }
        public string Diagnostico { get; set; }
        public DateTime ProximaRevision { get; set; }
    }
}
