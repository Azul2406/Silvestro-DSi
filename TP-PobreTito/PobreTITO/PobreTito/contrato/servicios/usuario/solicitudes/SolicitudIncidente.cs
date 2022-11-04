using System.ComponentModel.DataAnnotations;


namespace contrato.servicios.usuario.solicitudes
{
    public class SolicitudIncidente
    {
        public int Id { get; set; }
        [Required]
        [MinLength(4)]
        public string Motivo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")] 
        public string Fecha { get; set; }
        [Required]
        public string Hora{ get; set; }
        [Required]
        public string Ubicacion {get; set;}
        

        public string Observaciones {get; set;}
        
  
    }
}
