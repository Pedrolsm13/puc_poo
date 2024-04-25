using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class ContaCorrente : Conta
    {
        private bool contaEspecial;
        private double limiteChequeEspecial;

        public ContaCorrente() : base()
        {

        }

        public ContaCorrente(int numero, string titular, double saldo, bool contaEspecial, double limiteChequeEspecial) : base(numero, titular, saldo)
        {
            this.contaEspecial = contaEspecial;
            this.limiteChequeEspecial = limiteChequeEspecial;
        }

        public double SaldoDisponivel()
        {
            return GetSaldo() + limiteChequeEspecial;
        }

        public void Debitar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido para débito.");
                return;
            }

            if (valor > GetSaldo() + limiteChequeEspecial)
            {
                Console.WriteLine("Saldo insuficiente para debitar o valor especificado.");
                return;
            }

            if (valor > GetSaldo())
            {
                limiteChequeEspecial -= (valor - GetSaldo());
                SetSaldo(0);
            }
            else
            {
                SetSaldo(GetSaldo() - valor);
            }

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

        public void ImprimeLimite()
        {
            Console.WriteLine("Limite de Cheque Especial: " + limiteChequeEspecial);
        }

        public void ImprimeSaldoTotal()
        {
            Console.WriteLine("Saldo Total Disponível: " + SaldoDisponivel());
        }

        public void imprimirDadosConta()
        { 
            base.imprimirDadosConta();
            Console.WriteLine("Conta Especial: " + contaEspecial);
            Console.WriteLine("Limite de Cheque Especial: " + limiteChequeEspecial);
        }
    }
}

