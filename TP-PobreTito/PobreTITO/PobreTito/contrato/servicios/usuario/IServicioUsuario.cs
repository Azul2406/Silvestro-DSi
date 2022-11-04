using System.Threading.Tasks;

namespace contrato.servicios.usuario
{
    public interface IServicioUsuario
    {
        Task<respuestas.RespuestaObtener> Obtener(solicitudes.SolicitudObtener solicitud);
    }
}

