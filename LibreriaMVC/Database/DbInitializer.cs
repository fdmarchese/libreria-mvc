using LibreriaMVC.Models;
using System.Linq;

namespace LibreriaMVC.Database
{
    public static class DbInitializer
    {
        public static void Initialize(LibreriaDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Libros.Any())
            {
                return;   // DB has been seeded
            }

            byte[] data = System.Text.Encoding.ASCII.GetBytes("123456");
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);

            Usuario usuario1 = new Usuario()
            {
                Nombre = "Federico",
                Apellido = "Marchese",
                Email = "fdmarchese@hotmail.com",
                Contrasenia = data
            };
            context.Usuarios.Add(usuario1);

            var terror = new Genero()
            {
                Nombre = "Terror",
                ClaseCss = "bg-danger"
            };
            context.Generos.Add(terror);

            var scifi = new Genero()
            {
                Nombre = "Ciencia ficción",
                ClaseCss = "bg-warning"
            };
            context.Generos.Add(scifi);

            var aventura = new Genero()
            {
                Nombre = "Aventura",
                ClaseCss = "bg-success"
            };
            context.Generos.Add(aventura);

            var autor1 = new Autor()
            {
                Nombre = "José",
                Apellido = "Aventurero"
            };
            context.Autores.Add(autor1);

            var autor2 = new Autor()
            {
                Nombre = "Roberto",
                Apellido = "Sobrio"
            };
            context.Autores.Add(autor2);

            var autor3 = new Autor()
            {
                Nombre = "Andrea",
                Apellido = "González"
            };
            context.Autores.Add(autor3);

            var editorial = new Editorial() { Nombre = "Planeta" };
            context.Editoriales.Add(editorial);

            var libro1 = new Libro()
            {
                Titulo = "Un libro de aventuras",
                Editorial = editorial,
                Genero = aventura,
                AnioPublicado =1997,
                Stock = 20
            };
            context.Libros.Add(libro1);

            var libro2 = new Libro()
            {
                Titulo = "Un libro de terror",
                Editorial = editorial,
                Genero = terror,
                AnioPublicado = 2003,
                Stock = 10
            };
            context.Libros.Add(libro1);

            var libro3 = new Libro()
            {
                Titulo = "Un libro de Sci-fi",
                Editorial = editorial,
                Genero = scifi,
                AnioPublicado = 2015,
                Stock = 3
            };
            context.Libros.Add(libro1);

            context.LibrosAutores.Add(new LibroAutor() { Autor = autor1, Libro = libro1 });
            context.LibrosAutores.Add(new LibroAutor() { Autor = autor3, Libro = libro3 });
            context.LibrosAutores.Add(new LibroAutor() { Autor = autor2, Libro = libro3 });
            context.LibrosAutores.Add(new LibroAutor() { Autor = autor2, Libro = libro2 });
            context.LibrosAutores.Add(new LibroAutor() { Autor = autor1, Libro = libro2 });


            context.SaveChanges();
        }
    }
}
