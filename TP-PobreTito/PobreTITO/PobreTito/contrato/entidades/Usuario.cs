
using System.ComponentModel.DataAnnotations;

namespace contrato.entidades
{        
    public class Usuario
    {
       public int Id { get; set; }
        [Required]
        [MinLength(4)]
        public string Nombre { get; set; }
        [Required]
        [MinLength(2)]
        public string Apellido { get; set; }
        [Required]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "El formato del correo es inválido")]
        public string Email {get; set;}
        [Required]
        [MinLength(7)]
        public string DNI {get; set;}
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")] 
        //public DateTime? FechaNacimiento { get; set; }
        public string FechaNacimiento {get; set;}
        [Required]
        public string Tel {get; set;}
        [Required]
        [Range(8, 10, ErrorMessage = "El usuario debe ser de 8 a 10 caracteres")]
        public string NombreUsuario {get; set;}
        public string Contraseña {get; set;}

        [Required]
        [Compare("Usuario.Contraseña", 
        ErrorMessage = "La clave y la verificación de la clave no son correctas")]
        public string ConfirmacionCont {get; set;}
    }
}