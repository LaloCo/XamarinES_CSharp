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
            int resultado = Suma(numeroDos, numeroUno);
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();
        }

        static int Suma(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
