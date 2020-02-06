using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ingrese cantidad de votos por a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese cantidad de votos por b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese cantidad de votos en blanco: ");
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese cantidad de votos nulos: ");
            int nulo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese poblacion total: ");
            int poblacionTotal = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese porcentaje poblacion con posibilidad de votar: ");
            double porcentajePoblacionMayor = double.Parse(Console.ReadLine());

            int totalVotos = a + b + blanco + nulo;
            int difernciaVotos = 0;
            if (a - b < 0)
                difernciaVotos = -(a - b);
            else
                difernciaVotos = a - b;

            bool A = (totalVotos > poblacionTotal);
            bool B = (difernciaVotos < 0.1 * totalVotos);
            bool C = (totalVotos < 0.3 * poblacionTotal);

            //bool A = false;
            //bool B = false;
            //bool C = false;


            if ((A || B) && C)
                Console.WriteLine("las elecciones deben ser ejecutadas nuevamente");
            else if (a < b)
                Console.WriteLine("gano b");
            else if (a == b)
                Console.WriteLine("empate");
            else
                Console.WriteLine("gano a");

        }
    }
}
