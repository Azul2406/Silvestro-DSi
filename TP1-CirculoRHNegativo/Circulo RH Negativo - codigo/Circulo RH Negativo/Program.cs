using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo_RH_Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            //Persona persona2 = new Persona();
            //Persona persona3 = new Persona();

            Console.WriteLine("Ingrese el nombre: ");
            persona1.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            persona1.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI: ");
            string linea = Console.ReadLine();
            persona1.Dni = long.Parse(linea);
            Console.WriteLine("Ingrese la localidad: ");
            persona1.Localidad = Console.ReadLine();
            Console.WriteLine("Ingrese el domicilio: ");
            persona1.Domicilio = Console.ReadLine();
            Console.WriteLine("Ingrese el email: ");
            persona1.Email = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento (aa-mm-dd): ");
            linea = Console.ReadLine();
            persona1.FechaNacimiento = DateTime.Parse(linea);
            Console.WriteLine("Ingrese el grupo sanguineo: ");
            persona1.GrupoSanguineo = Console.ReadLine();
            Console.WriteLine("¿Toma alguna medicacion?: ");
            linea = Console.ReadLine();
            if (linea.Equals("si"))
            {
                persona1.Medicacion = true;
            }
            else
            {
                persona1.Medicacion = false;
            }
            Console.WriteLine("Si toma medicacion, ingrese cual: ");
            persona1.TipoMedicacion = Console.ReadLine();


            //persona1.Nombre = "Juan";
            //persona1.Apellido = "Juan";
            //persona1.Dni = 44444444;
            //persona1.DomicilioCalle = "Cabrera";
            //persona1.DomicilioNro = "2222";
            //persona1.Email = "Juan@juan.com";
            //persona1.FechaNacimiento = new DateTime (2016, 4, 2) ;
            //persona1.GrupoSanguineo= "A+";
            //persona1.Localidad= "San Fco.";
            //persona1.Medicacion = false;
            //persona1.TipoMedicacion = " ";

            //persona2.Nombre = "Pablo";
            //persona2.Apellido = "Pablo";
            //persona2.Dni = 88888888;
            //persona2.DomicilioCalle = "Cabrera";
            //persona2.DomicilioNro = "224";
            //persona2.Email = "Pablo@pablo.com";
            //persona2.FechaNacimiento = new DateTime(2001, 6, 24);
            //persona2.GrupoSanguineo = "B-";
            //persona2.Localidad = "San Fco.";
            //persona2.Medicacion = true;
            //persona2.TipoMedicacion = "mmmm";

            //persona3.Nombre = "Sofia";
            //persona3.Apellido = "Sofua";
            //persona3.Dni = 55555555;
            //persona3.DomicilioCalle = "Cabrera";
            //persona3.DomicilioNro = "77222";
            //persona3.Email = "Sofia@sofia.com";
            //persona3.FechaNacimiento = new DateTime(2000, 8, 26);
            //persona3.GrupoSanguineo = "AB-";
            //persona3.Localidad = "San Fco.";
            //persona3.Medicacion = false;
            //persona3.TipoMedicacion = " ";

            Asociado asociado1 = new Asociado();
            asociado1.DefinirCategoria(persona1.FechaNacimiento, persona1.Medicacion);

            //Asociado asociado2 = new Asociado();
            //asociado2.DefinirCategoria(persona2.FechaNacimiento, persona2.Medicacion);

            //Asociado asociado3 = new Asociado();
            //asociado3.DefinirCategoria(persona3.FechaNacimiento, persona3.Medicacion);


            Console.ReadKey();

        }
    }
}
