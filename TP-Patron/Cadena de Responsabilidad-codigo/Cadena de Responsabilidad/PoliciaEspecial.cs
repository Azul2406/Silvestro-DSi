using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadena_de_Responsabilidad
{
    public class PoliciaEspecial : ManejadorMensaje 
    {

        private string key = "0A89E4";


        public override void manejarMensaje(Mensaje msg)
        {
            if (msg.obtenerCodificacion().Equals("especial"))
            {
                Console.WriteLine(msg.desencriptar(key));
            }
            else
            {
                proximo.manejarMensaje(msg);
            }
        }
    }

}
