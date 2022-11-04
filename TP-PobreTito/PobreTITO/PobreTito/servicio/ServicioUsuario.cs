using System.Collections.Generic;
using contrato.servicios.usuario;
using contrato.entidades;
using contrato.servicios.usuario.respuestas;
using contrato.servicios.usuario.solicitudes;
using System.Threading.Tasks;
using System.Linq;

namespace servicio
{
    public class ServicioUsuario : IServicioUsuario
    {
        public List<Usuario> Usuarios {get; set;}

        public Task<RespuestaObtener> Obtener(SolicitudObtener solicitud)
        {
            throw new System.NotImplementedException();
        }
    }
}
