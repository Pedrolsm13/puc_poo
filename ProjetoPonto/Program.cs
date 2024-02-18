using System;
using System.Collections.Generic;
using System.Data;

namespace ProjetoPonto
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Ponto> lista = new List<Ponto>(3);
            Random r = new Random();
            Console.WriteLine("Início do programa principal"); 
            Ponto p1 = new Ponto(); 
            p1.imprimirCoordenadas(); 
            p1.incrementarCoordenadas(5, 2); 
            //p1.zerarCoordenadas(); 
            p1.imprimirCoordenadas(); 
            p1.incrementarCoordenadas(5, 2); 
            //p1.zerarCoordenadas(); 
            p1.imprimirCoordenadas(); 
            Ponto p2 = new Ponto(); 
            p2.imprimirCoordenadas(); 
            p2.incrementarCoordenadas(6, 9); 
            p2.imprimirCoordenadas(); 
            p2.incrementarCoordenadas(5, 2); 
            p2.imprimirCoordenadas(); 
            p2.zerarCoordenadas();
            for (int i = 0; i < lista.Capacity; i++)
            {
                lista.Add(new Ponto());
                int a = r.Next(0,21);
                int b = r.Next(0,21);
                lista[i].incrementarCoordenadas(a, b);
            }
            foreach(Ponto j in lista)
            {
                j.imprimirCoordenadas();
            }
        } 
    }
}