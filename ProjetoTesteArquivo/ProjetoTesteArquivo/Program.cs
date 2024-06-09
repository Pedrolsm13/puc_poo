using System.IO;

namespace ProjetoTesteArquivo
{
    public class Program
    {
        static void Main(string[] args)
        {

            StreamReader rd = new StreamReader(@"C:\ATV_POO\customers-100.csv");
            int nlinha = 0;
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                Console.WriteLine(linha);
                nlinha++;
                if(nlinha % 20 == 0)
                {
                    Console.WriteLine("cliqe para continuar");
                    Console.ReadKey();
                }
            }
            rd.Close();
            Console.Write("\n\n\nPressione qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}
