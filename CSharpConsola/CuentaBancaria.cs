using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsola
{
    public class CuentaBancaria
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
    }
}
