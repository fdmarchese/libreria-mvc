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

            context.SaveChanges();
        }
    }
}
