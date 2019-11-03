using LibreriaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace LibreriaMVC.Database
{
    public class LibreriaDbContext : DbContext
    {
        public LibreriaDbContext(DbContextOptions<LibreriaDbContext> options) : base(options)
        {

        }

        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<LibroAutor> LibrosAutores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
