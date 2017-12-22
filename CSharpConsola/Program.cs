using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = int.Parse(Console.ReadLine());
            int numeroDos = int.Parse(Console.ReadLine());
            int resultado = Geometria.Suma(numeroDos, numeroUno);
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();
        }
    }

    class Matematicas
    {
        public static int Suma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Resta(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiplicacion(int n1, int n2)
        {
            return n1 * n2;
        }

        public static int Division(int n1, int n2)
        {
            return n1 / n2;
        }
    }

    class Geometria : Matematicas
    {
        public static int AreaCuadrado(int lado)
        {
            return Multiplicacion(lado, lado);
        }
    }
}
