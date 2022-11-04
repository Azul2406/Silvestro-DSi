namespace contrato.servicios.usuario.respuestas
{
    public class RespuestaIncidente
    {
        public string Mensaje {get; set; }
        public contrato.entidades.Incidente Incidente { get; set; }
    }
}