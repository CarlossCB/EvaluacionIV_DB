using Microsoft.EntityFrameworkCore;

namespace EvaluacionIV_DB.Models
{
    public class EFContext : DbContext
    {
        // Conexión a la BD
        private const string ConnectionString = "server=localhost;port=3306;database=literatura_db;user=root;password=;Connect Timeout=5;";

        // Configuración de la instancia inicial de MySQL en conexión al proyecto
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString,
                new MySqlServerVersion(new Version(8, 0, 11)));
        }

        // Definición de clases que son modelos desde la base de datos
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }

        // Configuración de los modelos 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definir claves primarias
            modelBuilder.Entity<Libro>().HasKey(i => i.Id);
            modelBuilder.Entity<Autor>().HasKey(j => j.Id);

            // Definir relaciones uno a muchos: Libro a Autor
            modelBuilder.Entity<Libro>()
                .HasOne<Autor>(s => s.Autor)
                .WithMany(g => g.Libros)
                .HasForeignKey(c => c.AutorId);

            // Definimos los obligatorios (not null - mandatory) 
            // Libro:
            modelBuilder.Entity<Libro>().Property(s => s.AutorId).IsRequired();
            modelBuilder.Entity<Libro>().Property(s => s.Titulo).IsRequired();
            modelBuilder.Entity<Libro>().Property(s => s.NroPaginas).IsRequired();

            // Autor:
            modelBuilder.Entity<Autor>().Property(s => s.Nombre).IsRequired();
            modelBuilder.Entity<Autor>().Property(s => s.FechaNacimiento)
                .HasDefaultValue(DateTime.Now) 
                .IsRequired();
            modelBuilder.Entity<Autor>().Property(s => s.Edad).IsRequired();
        }

    }
}
