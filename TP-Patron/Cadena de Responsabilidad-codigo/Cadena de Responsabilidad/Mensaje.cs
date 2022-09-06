using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadena_de_Responsabilidad
{
    public class Mensaje
    {
        string codificacion;
        string text;
        
        public Mensaje (string codificacion, string text)
        {
            this.codificacion = codificacion;
            this.text = text;

        }
        public string obtenerCodificacion()
        {
            
            return codificacion;
        }

        public string desencriptar(string key)
        {
            
            return text;
        }


    }
}
