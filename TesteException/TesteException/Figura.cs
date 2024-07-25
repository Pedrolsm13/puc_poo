using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteException
{
    public class Figura
    {
        // Implementação da classe Figura
    }

    public static class ConjuntoHelper
    {
        private static int capacidade = 10; // Define a capacidade máxima
        private static List<Figura> figuras = new List<Figura>();

        public static void AdicionarFigura(Figura figura)
        {
            if (figuras.Count >= capacidade)
            {
                throw new FiguraException(1, "Número máximo de objetos extrapolados");
            }
            figuras.Add(figura);
        }

        public static void ExcluirFigura(Figura figura)
        {
            if (figuras.Count == 0)
            {
                throw new FiguraException(2, "Não existem objetos armazenados");
            }
            figuras.Remove(figura);
        }

        public static void ListarFiguras()
        {
            foreach (var figura in figuras)
            {
                Console.WriteLine(figura);
            }
        }
    }

}
