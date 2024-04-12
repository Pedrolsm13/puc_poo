using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class ContaCorrente : Conta
    {
        public bool ContaEspecial { get; set; }
        public double LimiteCheque { get; set; }

        public override void Debitar(double valor)
        {
            if (ContaEspecial || valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public double GetSaldoDisponivel()
        {
            return Saldo + LimiteCheque;
        }

        public override string ToString()
        {
            return base.ToString() + $", Conta Especial: {ContaEspecial}, Limite de Cheque: {LimiteCheque}";
        }
    }
}
