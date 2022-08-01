using EvaluacionIV_DB.Models;

Console.WriteLine("Evidencias de utilización de LinQ para BD:");

using (EFContext db = new EFContext())
{
    /* 1) Obtener Autores cuya Edad estén entre 60 y 80,
          ordenados por Edad de forma descendente */

    var autores = db.Autores
        .Where(x => x.Edad >= 60 && x.Edad <= 80)
        .OrderByDescending(x => x.Edad)
        .ToList();

    Console.WriteLine("\nLista de autores: ");
    foreach (var autor in autores)
    {
        Console.WriteLine($"ID: {autor.Id} - Nombre: {autor.Nombre} - Edad: {autor.Edad} - Fecha Nacimiento: {autor.FechaNacimiento.ToString("dd-MM-yyyy")}");
    }

    /* 2) Obtener el promedio de la edad de los autores */
    double promedio = db.Autores.Average(x => x.Edad);
    Console.WriteLine($"\nEl promedio de la edad de los autores es: {promedio} ");

    /* 3) Obtener un sólo Autor a través de su FechaNacimiento (1947-09-21 00:00:00) */
    var primerDato = db.Autores.FirstOrDefault(x => x.FechaNacimiento == DateTime.Parse("1947-09-21 00:00:00"));
    Console.WriteLine($"\nEl primer registro es: ");
    Console.WriteLine($"ID: {primerDato.Id} - Nombre: {primerDato.Nombre} - Edad: {primerDato.Edad} - Fecha Nacimiento: {primerDato.FechaNacimiento.ToString("dd-MM-yyyy")}");

    /* 4) Insertar un nuevo Autor sin un ID existente aun, que posea
          las siguientes características:
          Nombre: "Gabriel García Márquez", Edad: 95, FechaNacimiento: 6 de marzo de 1927
          No se poseen datos si esta Activo o no. 

    Autor nuevoAutor = new Autor()
    {
        Id = 0,
        Nombre = "Gabriel García Márquez",
        Edad = 95,
        FechaNacimiento = Convert.ToDateTime("1927-03-06"),
        Activo = null
    };

    db.Autores.Add(nuevoAutor);
    db.SaveChanges();
    */

    /* 5) Actualizar el titulo del Libro "El resplandor" a "Skeleton Crew" y NroPaginas de 643 a 512 NroPaginas
          a través de la búsqueda de su Id (2) 
    var libroActualizar = db.Libros.FirstOrDefault(x => x.Id == 2);
    libroActualizar.Titulo = "Skeleton Crew";
    libroActualizar.NroPaginas = 512;

    db.Libros.Update(libroActualizar);
    db.SaveChanges();
    */

    /* 6) Eliminar el Libro "El balcón del Frangipani" 
        a través de la búsqueda de su Id (15) 
    var libroEliminar = db.Libros.FirstOrDefault(x => x.Id == 15);

    db.Libros.Remove(libroEliminar);
    db.SaveChanges();
    */
}