using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP_Domain.Entities
{
    public class Receta
    {
        [Key]
        public string Id_Receta { get; set; }
        public int Id_Registro { get; set; }
        public Registro Registro { get; set; }
        public string Descripcion { get; set; }
    }
}
