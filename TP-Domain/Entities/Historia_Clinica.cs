using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP_Domain.Entities
{
    public class Historia_Clinica
    {
        [Key]
        public int Id { get; set; }

        public int Id_Paciente { get; set; }

        public int Id_Registro { get; set; }
        public Registro Registro { get; set; }
    }
}
