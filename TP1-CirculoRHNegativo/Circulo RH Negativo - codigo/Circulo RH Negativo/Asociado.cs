using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo_RH_Negativo
{
    class Asociado: Persona
    {
        private string categoria;
        //private int id; 

        public void DefinirCategoria(DateTime fecha, bool medicacion)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fecha.Year;
            if (fechaActual.Month < fecha.Month)
            {
                --edad;
            }
            else
            {
                if (fechaActual.Month == fecha.Month && fechaActual.Day > fecha.Day)
                {
                    --edad;
                }
            }
            
            if (edad >= 18 && edad <= 56 && medicacion==false)
            {
                categoria = "Activo";
            }
            else
            {
                categoria = "Pasivo";
            }
            Console.WriteLine("El asociado " + Nombre + " de " + edad + " pertenece a la categoria " + categoria);

        }
    }
}
