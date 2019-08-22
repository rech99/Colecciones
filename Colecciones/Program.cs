using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> alumnos =
                new List<Alumno>();
            alumnos.Add(
                new Alumno("Jose", "123456"));
            alumnos.Add(
                new Alumno("Ana", "741852"));

            foreach(Alumno alumno in alumnos)
            {
                Console.WriteLine("Nombre: " +
                    alumno.Nombre);
            }
            Console.Read();
        }
    }
}
