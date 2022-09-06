using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadena_de_Responsabilidad
{
    public class PoliciaEstandar : ManejadorMensaje
    {

        private string key = "0069A0";



        public override void manejarMensaje(Mensaje msg)
        {
            if (msg.obtenerCodificacion().Equals("base"))
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
