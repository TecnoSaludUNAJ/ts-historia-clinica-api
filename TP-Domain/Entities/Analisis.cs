 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP_Domain.Entities
{
   public class Analisis
    {
        [Key]
        public int AnalisisId { get; set; }
        public string Descripcion { get; set; }

        public Registro Registro { get; set; }

    }
}
