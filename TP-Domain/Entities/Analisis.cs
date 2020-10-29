using System.ComponentModel.DataAnnotations;

namespace TP_Domain.Entities
{
    public class Analisis
    {
        [Key]
        public int AnalisisId { get; set; }
        public string DescripcionAnalisis { get; set; }

        public Registro Registro { get; set; }
        public int RegistroId { get; set; }




    }
}
