using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP_Domain.Entities
{
    public class Registro
    {
        [Key]
        public int Id_Registro { get; set; }
        public string Motivo_Consulta { get; set; }
        public string Diagnostico { get; set; }
        public int Id_Analisis { get; set; }
        public Analisis Analisis { get; set; }
        public DateTime Proxima_Revision { get; set; }
        public int Id_Receta { get; set; }
        public Receta Receta { get; set; }
        public int Id_Historia_Clinica { get; set; }
        public Historia_Clinica Historia_Clinica { get; set; }
        public int Especialista { get; set; }
    }
}
