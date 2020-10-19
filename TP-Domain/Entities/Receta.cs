using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP_Domain.Entities
{
    public class Receta
    {
        [Key]
        public string RecetaId { get; set; }
        public string Descripcion { get; set; }

        public int RegistroId { get; set; }
        public Registro Registro { get; set; }
    }
}
