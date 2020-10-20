using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP_Domain.Entities
{
    public class Registro
    {
        [Key]
        public int RegistroId { get; set; }
        public string MotivoConsulta { get; set; }
        public string Diagnostico { get; set; } 
        public DateTime ProximaRevision { get; set; }


        public List<Receta> RecetaNavigator { get; set; }

        public List<Analisis> AnalisisNavigator { get; set; }

        public int EspecialistaId { get; set; }

        public HistoriaClinica HistoriaClinica { get; set; }
        public int HistoriaClinicaId { get; set; }

    }
}
