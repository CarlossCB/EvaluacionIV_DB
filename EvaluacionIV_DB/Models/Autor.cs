using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionIV_DB.Models
{
    [Table("Autor")] // Indicar la tabla al que pertenecerá la clase POCO
    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public bool? Activo { get; set; }

        // Relaciones
        public virtual ICollection<Libro> Libros { get; set; }
    }
}

