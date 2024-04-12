using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }
        public Agencia Agencia { get; set; } // Referência para a Agência

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        
        public virtual void Debitar(double valor)
        {
            Saldo -= valor;
        }

        public virtual void Creditar(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return $"Número: {Numero}, Titular: {Titular}, Saldo: {Saldo}, Agência: {Agencia.Codigo}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Conta outraConta = (Conta)obj;
            return Numero == outraConta.Numero;
        }
    }
}
