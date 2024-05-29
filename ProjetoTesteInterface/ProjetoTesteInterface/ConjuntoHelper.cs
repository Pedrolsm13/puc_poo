using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteInterface
{
    public class ConjuntoHelper
    {
        private static ConjuntoHelper instance;

        private List<PontoVO> listaPontos;

        private List<FiguraVO> ListaFiguras;

        private ConjuntoHelper()
        {
            listaPontos=new List<PontoVO>();
            ListaFiguras=new List<FiguraVO>();
        }
        public static ConjuntoHelper getInstance()
        {
            if (instance == null)
            {
                instance = new ConjuntoHelper();
            }
            return instance;
        }


        public int adicionar(PontoVO ponto)
        {
            listaPontos.Add(ponto);
            return 1;
        }

        public int Adicionarfigura(FiguraVO figura)
        {
            ListaFiguras.Add(figura);
            return 1;
        }


        public void listarPontos()
        {
            PontoVO p = null;
            Console.WriteLine("Início listarPontos...");
            for (int i = 0; i < listaPontos.Count; i++)
            {
                p = (PontoVO) listaPontos[i];
                Console.WriteLine(p);
            }
            Console.WriteLine("Fim listarPontos...");
        }
        public void excluirPonto(PontoVO pontoVO)
        {
            // exclui um objeto do tipo Ponto
        }

        public void listarFiguras()
        {
            FiguraVO p = null;
            Console.WriteLine("Início listarPontos...");
            for (int i = 0; i < ListaFiguras.Count; i++)
            {
                p = (FiguraVO)ListaFiguras[i];
                Console.WriteLine(p);
            }
            Console.WriteLine("Fim listarPontos...");
        }
    }
}
