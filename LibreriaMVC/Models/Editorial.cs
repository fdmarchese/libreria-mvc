using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibreriaMVC.Models
{
    public class Editorial
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima es de 100 caracteres")]
        public string Nombre { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
