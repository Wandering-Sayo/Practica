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
           
           //corte de control
           while(!nombre.Equals("salir")) //para comparar Strings se usa siempre Equals y no ==
           {
                //mientras se cumple la condición entra
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

                 Console.WriteLine("Cual es tu nombre?");
                 nombre = Console.ReadLine();
           }
           
           //se ejecuta 5 veces
           for(int i=0;i<5;i++)
           {
               Console.WriteLine("Hola");
           } 

           /* Se podría hacer tambien con while: 
           int j=0;
           while(j<5)
           {
               Console.WriteLine("Hola");
               j++;
           }
            */


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


            //Array
            string color = "rojo";
            string[] colores = new string []{ "verde" , "blanco" , color , "violeta" };
            Console.WriteLine("El tercer color es el: " + colores[2]);
            colores[0] = "negro"; //cambia el item en posición 0


            //iteramos items
            for(int k=0; k < colores.Length ; k++)
            {
                Console.WriteLine("Color: " + colores[k]);
            }

            foreach(string item in colores)
            {
                Console.WriteLine("Color: " + item);
            }

            //arrays multidimensionales
            int [,] multi = {{1,3,4}, {2,4,2}, {1,3,4}};
            for(int l=0; l< 3; l++ )
            {
                for(int m=0; m< 3; m++ )
                {
                    Console.WriteLine(multi[l,m]);
                }
            }



            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();

        }
    }
}
