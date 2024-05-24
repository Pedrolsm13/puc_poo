using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{

    public class RetanguloVO : FiguraVO
    {
        private double comprimento;
        private double altura;

        public RetanguloVO(int codigo, string descricao, double comprimento, double altura) : base(codigo, descricao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.comprimento = comprimento;
            this.altura = altura;
        }


        public override double calcularArea()
        {
            return (comprimento * altura);
        }
        public override void imprimirDados()
        {
            base.imprimirDados();
            Console.Write("\nComprimento: " + comprimento + " \nAltura: " + altura);
        }
    }
}
