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
            Matematicas.Suma(12, 12);

            Console.ReadLine();
        }

        static void AgregarBalance(ICuentaBancaria cuentaBancaria, double balance)
        {
            cuentaBancaria.AgregarABalance(balance);

            Console.WriteLine($"{cuentaBancaria.Balance}");
        }
    }

    class Matematicas
    {
        public static int Suma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Suma(int[] valores)
        {
            int resultado = 0;
            foreach(int i in valores)
            {
                resultado += i;
            }

            return resultado;
        }

        public virtual int Resta(int n1, int n2)
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

        public override int Resta(int n1, int n2)
        {
            return n2 - n1;
        }
    }
}
