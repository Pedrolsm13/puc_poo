using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class ContaPoupanca : Conta
    {
        public double Rendimento { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Rendimento: {Rendimento}";
        }
    }
}
