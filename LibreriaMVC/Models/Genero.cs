using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibreriaMVC.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(50, ErrorMessage = "La longitud máxima es de 50 caracteres")]
        public string Nombre { get; set; }

        [MaxLength(50, ErrorMessage = "La longitud máxima es de 50 caracteres")]
        [Display(Description = "Clase de css")]
        public string ClaseCss { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
