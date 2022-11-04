using System.ComponentModel.DataAnnotations;

namespace contrato.entidades
{        
    public class Incidente
    {
        public int IdIncidente { get; set; }
        [Required]
        public string Motivo { get; set; }
        [Required]
        public string Ubicacion { get; set; }
        [Required]
        public string Fecha { get; set; }
        [Required]
        public string Hora { get; set; }
        public string Observaciones { get; set; }

        
    }
}