using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início do Main...");
            ConjuntoHelper conjuntoHelper = ConjuntoHelper.getInstance();

            PontoVO obj1 = new PontoVO(1, "p1", 1, 5);
            conjuntoHelper.adicionar(obj1);

            PontoVO obj2 = new PontoVO(2, "p2", 3, 7);
            conjuntoHelper.adicionar(obj2); 

            ConjuntoHelper.getInstance().adicionar(new PontoVO(3, "p3", 2, 18));
            ConjuntoHelper.getInstance().listarPontos();  
            
            Console.WriteLine("Início do Main...");

            PontoVO obj3 = new PontoVO(2, "p2", 3, 7);
            conjuntoHelper.adicionar(obj3);

            FiguraVO Obj4 = new FiguraVO(1, "f1", obj1);
            conjuntoHelper.Adicionarfigura(Obj4);

            FiguraVO Obj5 = new FiguraVO(2, "f2", obj2);
            conjuntoHelper.Adicionarfigura(Obj5);

            ConjuntoHelper.getInstance().Adicionarfigura(new FiguraVO(3, "p3", obj3));
            ConjuntoHelper.getInstance().listarFiguras();

            FiguraVO.quantidade();

        }
    }
}
