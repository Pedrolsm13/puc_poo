using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class AgenciaVO
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        private List<Conta> contas;

        public AgenciaVO(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
            contas = new List<Conta>();
        }

        public void AdicionarConta(Conta conta)
        {
            contas.Add(conta);
        }

        public void ExcluirConta(Conta conta)
        {
            contas.Remove(conta);
        }

        public List<Conta> ListarContas()
        {
            return contas;
        }

        public Conta BuscarConta(int numero)
        {
            return contas.Find(c => c.GetNumero() == numero);
        }
    }
}

