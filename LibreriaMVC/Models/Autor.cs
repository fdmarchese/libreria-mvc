using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibreriaMVC.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima es de 100 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima es de 100 caracteres")]
        public string Apellido { get; set; }

        public virtual ICollection<LibroAutor> LibrosAutor { get; set; }
    }
}
