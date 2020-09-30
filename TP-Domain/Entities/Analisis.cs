 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP_Domain.Entities
{
   public class Analisis
    {
        [Key]
        public int Id_Analisis { get; set; }
        public string Descripcion { get; set; }
    }
}
