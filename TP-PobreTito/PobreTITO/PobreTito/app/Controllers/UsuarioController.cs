using System.Threading.Tasks;
using contrato.entidades;
using contrato.servicios.usuario.solicitudes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using contrato.servicios.usuario.respuestas;
using System.Linq;

namespace pobretito.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class UsuarioController : Controller
    {
      

        public List<Usuario> Usuarios {get; set;}
       public List<Incidente> Incidentes {get; set;}


        public UsuarioController()
        {
            this.Usuarios = new List<Usuario>();
            this.Usuarios.Add(new Usuario {Id= 1, Nombre="Sandro", Apellido = "Sandro",
                                        Email = "Sandro@Sandro.com", DNI = "11111111", FechaNacimiento= "11/11/99", 
                                        Tel="1010101010", NombreUsuario= "Sandro11", Contraseña="S111199", ConfirmacionCont="S111199",});
            this.Usuarios.Add(new Usuario {Id= 2, Nombre="Maria", Apellido = "Maria",
                                        Email = "Maria@Maria.com", DNI = "22222222", FechaNacimiento= "02/02/98", 
                                        Tel="2020202020", NombreUsuario= "Maria02", Contraseña="M020298", ConfirmacionCont="M020298"});
            this.Usuarios.Add(new Usuario {Id= 3, Nombre="Carlos", Apellido = "Carlos",
                                        Email = "Carlos@Carlos.com", DNI = "33333333", FechaNacimiento= "13/03/97", 
                                        Tel="0303030303", NombreUsuario= "Carlos03", Contraseña="C130397", ConfirmacionCont="C130397"});
            this.Usuarios.Add(new Usuario {Id= 4, Nombre="Greta", Apellido = "Greta",
                                        Email = "Greta@greta.com", DNI = "44444444", FechaNacimiento= "06/09/99", 
                                        Tel="0404040404", NombreUsuario= "Greta04", Contraseña="G060999", ConfirmacionCont="G060999"});
            this.Usuarios.Add(new Usuario {Id= 5, Nombre="Tomas", Apellido = "Tomas",
                                        Email = "Tomas@Tomas.com", DNI = "55555555", FechaNacimiento= "05/05/83", 
                                        Tel="0505050505", NombreUsuario= "Tomas05", Contraseña="T050583", ConfirmacionCont="T050583"}); 


            this.Incidentes = new List<Incidente>();
            this.Incidentes.Add(new Incidente {IdIncidente= 1, Motivo= "Poste Caido", Ubicacion= "Belgrano 22",
                                            Fecha= "10/10/22", Hora= "9:30", Observaciones = " "});
            this.Incidentes.Add(new Incidente {IdIncidente= 2, Motivo= "Bache", Ubicacion= "Bv. Roca 2000",
                                            Fecha = "11/10/22", Hora= "10:30", Observaciones = " "});
            this.Incidentes.Add(new Incidente {IdIncidente= 3, Motivo= "Luz cortada", Ubicacion= "España 500",
                                            Fecha = "12/10/22 ", Hora= "11:30", Observaciones = "Corte de cables por ramas"});
            this.Incidentes.Add(new Incidente {IdIncidente= 4, Motivo= "Semaforo cortado", Ubicacion= " Av. Universidad ",
                                            Fecha = "15/10/22", Hora=  "9:30", Observaciones = " "});       
        }
        


        [HttpGet]
            public async Task<RespuestaObtener> Obtener([FromQuery] SolicitudObtener solicitud)
            {
                var respuesta = new RespuestaObtener();
                var listaUsuarios = this.Usuarios;
                
 //listaUsuarios.Where(u => u.NombreUsuario.Contains(solicitud.NombreUsuario));
                
                if (!string.IsNullOrEmpty(solicitud.NombreUsuario) && !string.IsNullOrEmpty(solicitud.Contraseña) ) 
                {
                    //listaUsuarios.Where(u => u.NombreUsuario.Contains(solicitud.NombreUsuario));

                    foreach(Usuario usuario in Usuarios)
                    {
   
                        if(usuario.NombreUsuario.CompareTo(solicitud.NombreUsuario)==0){
                            if(solicitud.Contraseña.Equals(usuario.Contraseña)){
                                respuesta.Mensaje="Inicio de sesion correcto";
                            }
                            else{respuesta.Mensaje="Contraseña incorrecta";}
                        }
                        else{respuesta.Mensaje="Usuario incorrecto";}
                    }
                    
                }
        
                return (respuesta);
            }

        [HttpPost]
        [Route("/api/[Controller]/registro")]
            public async Task<RespuestaCrear> Crear([FromBody] SolicitudCrear solicitud)
            {
                var respuesta = new RespuestaCrear();
                
                var usuarioNuevo = new Usuario();
                usuarioNuevo.Id = solicitud.Id;
                usuarioNuevo.Apellido = solicitud.Apellido;
                usuarioNuevo.Nombre = solicitud.Nombre;
                usuarioNuevo.Email = solicitud.Email;
                usuarioNuevo.DNI = solicitud.DNI;
                usuarioNuevo.FechaNacimiento = solicitud.FechaNacimiento;
                usuarioNuevo.Tel = solicitud.Tel;
                usuarioNuevo.NombreUsuario = solicitud.NombreUsuario;
                usuarioNuevo.Contraseña = solicitud.Contraseña;
                usuarioNuevo.ConfirmacionCont = solicitud.ConfirmacionCont;
                respuesta.Usuario = usuarioNuevo;
                respuesta.Mensaje = "Usuario registrado con exito";
                return respuesta;
            }

            [HttpPost]
            [Route("/api/[Controller]/incidentes")]
            public async Task<RespuestaIncidente> RegistrarIncidente([FromQuery] SolicitudIncidente solicitud)
            {
                var respuesta = new RespuestaIncidente();
                
                var incidenteNuevo = new Incidente();
                incidenteNuevo.IdIncidente = solicitud.Id;
                incidenteNuevo.Motivo = solicitud.Motivo;
                incidenteNuevo.Ubicacion = solicitud.Ubicacion;
                incidenteNuevo.Fecha = solicitud.Fecha;
                incidenteNuevo.Hora = solicitud.Hora;
                incidenteNuevo.Observaciones = solicitud.Observaciones;
                
                respuesta.Incidente = incidenteNuevo;
                respuesta.Mensaje = "Incidente registrado con exito, pronto será atendido";
                return respuesta;
            }

    }   
    
}