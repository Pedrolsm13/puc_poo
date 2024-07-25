using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteException
{
    public class FiguraException : Exception
    {
        public int Codigo { get; private set; }
        public string Mensagem { get; private set; }

        public FiguraException(int codigo, string mensagem) : base(mensagem)
        {
            Codigo = codigo;
            Mensagem = mensagem;
        }

        public override string ToString()
        {
            return $"FiguraException: Código = {Codigo}, Mensagem = {Mensagem}";
        }
    }
}
