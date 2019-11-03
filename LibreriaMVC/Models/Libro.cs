using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaMVC.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        [MaxLength(100, ErrorMessage = "Se supero la long max")]
        public string Titulo { get; set; }
        public int? AnioPublicado { get; set; }

        [Required(ErrorMessage = "campo requerido")]
        public int Stock { get; set; }

        public int EditorialId { get; set; }
        public Editorial Editorial { get; set; }

        public int GeneroId { get; set; }
        public Genero Genero { get; set; }

        public ICollection<LibroAutor> Autores { get; set; }
    }
}
