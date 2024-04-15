using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class ContaPoupanca : Conta
    {
        private double rendimento;

        public ContaPoupanca() : base()
        {

        }

        public ContaPoupanca(int numero, string titular, double saldo, double rendimento) : base(numero, titular, saldo)
        {
            this.rendimento = rendimento;
        }

        public void Debitar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido para débito.");
                return;
            }

            if (valor > GetSaldo())
            {
                Console.WriteLine("Saldo insuficiente para debitar o valor especificado.");
                return;
            }

            SetSaldo(GetSaldo() - valor);
            Console.WriteLine("Débito de " + valor + " realizado com sucesso.");
        }

        public void Creditar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido para crédito.");
                return;
            }

            SetSaldo(GetSaldo() + valor);
            Console.WriteLine("Crédito de " + valor + " realizado com sucesso.");
        }

        public override string ToString()
        {
            return base.ToString() + ", Rendimento: " + rendimento;
        }

        public void ImprimeRendimento()
        {
            Console.WriteLine("Rendimento da conta: " + rendimento);
        }

        public void ImprimeDadosConta()
        {
            base.imprimirDadosConta();
            Console.WriteLine("Rendimento: " + rendimento);
        }
    }
}
