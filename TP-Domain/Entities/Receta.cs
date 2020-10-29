using System.ComponentModel.DataAnnotations;

namespace TP_Domain.Entities
{
    public class Receta
    {
        [Key]
        public int RecetaId { get; set; }
        public string DescripcionReceta { get; set; }

        public int RegistroId { get; set; }
        public Registro Registro { get; set; }
    }
}
