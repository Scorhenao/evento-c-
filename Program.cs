using System;

namespace evento
{
    internal class Program
    {
        public class Persona
        {
            public string Nombre { get; set; }
            public string Estado { get; set; }
        }

        static void Main(string[] args)
        {
            // Array de personas inscritas
            Persona[] personas = new Persona[]
            {
                new Persona { Nombre = "Manolo", Estado = "Activo" },
                new Persona { Nombre = "Laura", Estado = "Inactivo" }
            };

            Console.WriteLine("Bienvenido al evento de la Universidad de La Sabana");
            Console.WriteLine("Por favor, ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Por favor, ingrese su edad: ");
            int edad;
            while (!int.TryParse(Console.ReadLine(), out edad))
            {
                Console.WriteLine("Edad inválida. Intente nuevamente:");
            }

            // Verificar si la persona está en la lista y está activa
            Persona personaEncontrada = Array.Find(personas, p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) && p.Estado == "Activo");

            if (personaEncontrada != null && edad >= 18 && edad <= 25)
            {
                Console.WriteLine($"Puede pasar, tienes {edad} años.");
            }
            else
            {
                Console.WriteLine($"No puedes pasar. Solo tienes {edad} años o no estás inscrito en el evento.");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
