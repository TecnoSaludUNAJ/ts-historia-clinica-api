using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TP_Domain.Entities
{
    public class HistoriaClinica
    {
        [Key]
        public int HistoriaClinicaId { get; set; }

        public int PacienteId { get; set; }


        public List<Registro> RegistroNavigator { get; set; }

    }
}
