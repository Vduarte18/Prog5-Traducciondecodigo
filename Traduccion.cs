using System;

namespace Actividad4

{
    class Program
    {
        static void Main(string [] args)
        {
            float pi = 3.14f;
            while (true)
            {
                for (int i=0;i<50;i++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine(" Programa Para Geometria ");
                for (int i=0;i<50;i++)

                {
                    System.Console.Write("*");
                    
                }
                System.Console.WriteLine("¿Que area desea Calcular? \n(c) Circulo \n(r) Rectangulo \n(t) triangulo \n(s) Salir");
                char opcion = Char.Parse(Console.ReadLine());
                if (opcion == 's')
                {
                    break;
                }
                float resultado = 0f;
                if (opcion== 'c')
                {
                    System.Console.WriteLine("Ingrese el Radio: ");
                    int vradio = Int32.Parse(Console.ReadLine());
                    resultado = pi*(vradio*vradio);                                
                }
                else if (opcion == 'r')
                {
                    System.Console.WriteLine("Ingrese la Base: ");
                    int vbase = Int32.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la Altura: ");
                    int valtura = Int32.Parse(Console.ReadLine());
                    resultado = vbase * valtura;
                }
                else
                {
                    System.Console.WriteLine("Ingrese la Base: ");
                    int vbase = Int32.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la Altura: ");
                    int valtura = Int32.Parse(Console.ReadLine());
                    resultado = (vbase*valtura)/2;

                }
                System.Console.WriteLine($"El Resultado es: (resultado)");
             

            }
            System.Console.WriteLine("Gracias por usar nuestro Programa de Geometría");
        }

    }
}