using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Testando adicionar figuras
                for (int i = 0; i < 11; i++)
                {
                    ConjuntoHelper.AdicionarFigura(new Figura());
                }
            }
            catch (FiguraException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                // Testando excluir figuras quando lista está vazia
                ConjuntoHelper.ExcluirFigura(new Figura());
            }
            catch (FiguraException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
