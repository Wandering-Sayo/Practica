using System;

namespace Primero
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Sayo";
            //Se puede hacer tambien en dos lineas
            string primer_nombre;
            primer_nombre = "Wandering";
            int edad = 29;

            
            Console.WriteLine("What's poppin?");
            Console.WriteLine("Mi nombre es " + primer_nombre + "-" + nombre + ". Tengo " + edad + " años." );
            Console.WriteLine("Cual es tu nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("Bienvendo " + nombre);
            Console.WriteLine("Cuál es tu edad?");
            edad = int.Parse(Console.ReadLine());

            if(edad >= 18)
            {
                Console.WriteLine("Sos mayor de edad.");
            }
            else
            {
                Console.WriteLine("Sos menor de edad.");
            }

            //Switch

            Console.WriteLine("Cantidad de parámetros: " + args.Length);
            switch(args.Length)
            {
                case 0:
                    Console.WriteLine("No tiene parámetros");
                    break;
                case 1:
                    Console.WriteLine("Tiene un parámetro");
                    break;
                default:
                    Console.WriteLine("Tiene " + args.Length + " parámetros");
                    break;
            }





        }
    }
}
