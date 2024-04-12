using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class Agencia
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        private List<Conta> contas = new List<Conta>();

        public Agencia(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public void AdicionarConta(Conta conta)
        {
            contas.Add(conta);
        }

        public void ExcluirConta(Conta conta)
        {
            contas.Remove(conta);
        }

        public void ListarContas()
        {
            foreach (var conta in contas)
            {
                Console.WriteLine(conta);
            }
        }
    }
}
