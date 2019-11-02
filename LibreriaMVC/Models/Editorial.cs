using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaMVC.Models
{
    public class Editorial
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        [MaxLength(100, ErrorMessage = "se superaron los 100 caracteres")]
        public string Nombre { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
