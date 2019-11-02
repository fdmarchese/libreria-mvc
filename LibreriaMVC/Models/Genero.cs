using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaMVC.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "requerido")]
        [MaxLength(50, ErrorMessage = "max 50")]
        public string Nombre { get; set; }

        [MaxLength(50, ErrorMessage = "max 50")]
        public string ClaseCss { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
