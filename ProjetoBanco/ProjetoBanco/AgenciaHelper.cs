using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class AgenciaHelper
    {
        private static AgenciaHelper instance;
        private List<AgenciaVO> agencias;

        private AgenciaHelper()
        {
            agencias = new List<AgenciaVO>();
        }

        public static AgenciaHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AgenciaHelper();
                }
                return instance;
            }
        }

        public void AddAgencia(AgenciaVO agencia)
        {
            agencias.Add(agencia);
        }

        public void AddConta(Conta conta, AgenciaVO agencia)
        {
            agencia.AdicionarConta(conta);
        }

        public int ExcluirConta(Conta conta, AgenciaVO agencia)
        {
            if (agencia.BuscarConta(conta.GetNumero()) != null)
            {
                agencia.ExcluirConta(conta);
                return 1;
            }
            else
            {
                throw new ObjetoNaoEncontradoException("Conta não encontrada.");
            }
        }

        public void ListarContas(AgenciaVO agencia)
        {
            foreach (var conta in agencia.ListarContas())
            {
                Console.WriteLine(conta);
            }
        }

        public List<Conta> GetContas(AgenciaVO agencia)
        {
            return agencia.ListarContas();
        }

        public Conta PesquisarConta(int numeroConta, AgenciaVO agencia)
        {
            Conta conta = agencia.BuscarConta(numeroConta);
            if (conta != null)
            {
                return conta;
            }
            else
            {
                throw new ObjetoNaoEncontradoException("Conta não encontrada.");
            }
        }

        public int AlterarConta(Conta conta, AgenciaVO agencia)
        {
            Conta existingConta = agencia.BuscarConta(conta.GetNumero());
            if (existingConta != null)
            {
                existingConta.SetTitular(conta.GetTitular());
                existingConta.SetSaldo(conta.GetSaldo());
                return 1;
            }
            else
            {
                throw new ObjetoNaoEncontradoException("Conta não encontrada.");
            }
        }
    }

    internal class ObjetoNaoEncontradoException : Exception
    {
        public ObjetoNaoEncontradoException(string message) : base(message)
        {
        }
    }
}

