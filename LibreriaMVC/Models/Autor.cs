using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaMVC.Models
{
    public class Autor
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public virtual ICollection<LibroAutor> LibrosAutor { get; set; }
    }
}
