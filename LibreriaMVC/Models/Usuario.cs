using System;
using System.ComponentModel.DataAnnotations;

namespace LibreriaMVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima es de 100 caracteres")]
        [Display(Name = "Correo electrónico")]
        [EmailAddress(ErrorMessage = "El campo debe ser una dirección de correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima es de 100 caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [MaxLength(100, ErrorMessage = "La longitud máxima es de 100 caracteres")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }


        [Display(Name = "Contraseña")]
        public byte[] Contrasenia { get; set; }

        [Display(AutoGenerateField = false)]
        public DateTime? FechaUltimoAcceso { get; set; }
    }
}
