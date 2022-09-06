using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadena_de_Responsabilidad
{
    public abstract class ManejadorMensaje
    {

        protected ManejadorMensaje proximo;


        public void establecerProximo(ManejadorMensaje proximo)
        {

            this.proximo = proximo;

        }

        public abstract void manejarMensaje(Mensaje msg);

    }

}
