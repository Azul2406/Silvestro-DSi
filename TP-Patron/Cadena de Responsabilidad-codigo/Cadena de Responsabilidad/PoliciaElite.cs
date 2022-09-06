using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadena_de_Responsabilidad
{
    public class PoliciaElite : ManejadorMensaje 
    {

        private string master_key = "F0FEF2";


        public override void manejarMensaje(Mensaje msg)
        {

            Console.WriteLine(msg.desencriptar(master_key));

        }

       
    }

}
