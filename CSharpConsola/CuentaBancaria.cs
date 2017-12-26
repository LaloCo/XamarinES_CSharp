using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsola
{
    interface ICuentaBancaria
    {
        double Balance { get; set; }

        double AgregarABalance(double balanceAAgregar);
    }

    public class CuentaBancaria : ICuentaBancaria
    {
        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        public double AgregarABalance(double balanceAAgregar)
        {
            Balance = Balance + balanceAAgregar;
            return Balance;
        }
    }

    public class CuentaBancariaKids : ICuentaBancaria
    {
        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        public double AgregarABalance(double balanceAAgregar)
        {
            if (balanceAAgregar <= 2000)
                Balance = Balance + balanceAAgregar;
            return Balance;
        }
    }
}
