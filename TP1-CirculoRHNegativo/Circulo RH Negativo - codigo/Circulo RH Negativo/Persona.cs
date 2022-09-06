using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo_RH_Negativo
{
    public class Persona
    {
       
        protected long dni;
        protected string nombre, apellido, domicilio, localidad, email,
                            grupoSanguineo, tipoMedicacion;
        protected DateTime fechaNacimiento;
        protected bool medicacion;

        //public Persona()
        //{
        //    Console.WriteLine("Ingrese el nombre: ");
        //    Nombre = Console.ReadLine();
        //    Console.WriteLine("Ingrese el apellido: ");
        //    Apellido = Console.ReadLine();
        //    Console.WriteLine("Ingrese el DNI: ");
        //    string linea = Console.ReadLine();
        //    Dni = long.Parse(linea);
        //    Console.WriteLine("Ingrese la localidad: ");
        //    Localidad = Console.ReadLine();
        //    Console.WriteLine("Ingrese el domicilio: ");
        //    Domicilio = Console.ReadLine();
        //    Console.WriteLine("Ingrese el email: ");
        //    Email = Console.ReadLine();
        //    Console.WriteLine("Ingrese la fecha de nacimiento (aa-mm-dd): ");
        //    linea = Console.ReadLine();
        //    FechaNacimiento = DateTime.Parse(linea);
        //    Console.WriteLine("Ingrese el grupo sanguineo: ");
        //    GrupoSanguineo = Console.ReadLine();
        //    Console.WriteLine("¿Toma alguna medicacion?: ");
        //    linea = Console.ReadLine();
        //    if (linea.Equals("si"))
        //    {
        //        Medicacion = true;
        //    }
        //    else
        //    {
        //        Medicacion = false;
        //    }
        //    Console.WriteLine("Si toma medicacion, ingrese cual: ");
        //    TipoMedicacion = Console.ReadLine();

        //}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public string Email { get; set; }
        public string TipoMedicacion { get; set; }
        public string GrupoSanguineo { get; set; }
        public long Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Medicacion { get; set; }

    }
}
