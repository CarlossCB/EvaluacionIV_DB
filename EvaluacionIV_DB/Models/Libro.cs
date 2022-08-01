using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionIV_DB.Models
{
    [Table("Libro")]
    public class Libro
    {
        public int Id { get; set; }
        public int AutorId { get; set; }
        public string Titulo { get; set; }
        public int NroPaginas { get; set; }

        // Relaciones
        public virtual Autor Autor { get; set; }
    }
}
