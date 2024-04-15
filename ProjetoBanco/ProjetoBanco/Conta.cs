using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class Conta
    {
        private int numero;
        private string titular;
        private double saldo;

        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public Conta()
        {
        }

        public int GetNumero()
        { return numero; }

        public void SetNumero(int numero)
        { this.numero = numero; }

        public string GetTitular()
        { return titular; }

        public void SetTitular(string titular)
        { this.titular = titular; }

        public double GetSaldo()
        { return saldo; }

        public void SetSaldo(double saldo)
        { this.saldo = saldo; }

        public override string ToString()
        { return "Numero: " + numero + ", Titular: " + titular + ", Saldo: " + saldo; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Conta outraConta = (Conta)obj;
            return this.numero == outraConta.numero;
        }
        
        public void imprimirDadosConta() 
        {
            Console.Write("\nNumero: " + numero + "\nTitular: " + titular + "\nSaldo: " + saldo);
        }
    }
}
