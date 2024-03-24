using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ProjetoPonto
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Início do main...");
            Ponto p1 = new Ponto();
            Conjunto c1 = new Conjunto("c1", 1);
            p1.incrementarCoordenadas(5, 2);
            p1.zerarCoordenadas();
            c1.AdicionarPonto(p1);
            c1.ListarPontos();
            p1.incrementarCoordenadas(5, 2);
            p1.zerarCoordenadas();
            c1.ListarPontos();
            Ponto p2 = new Ponto();
            p2.incrementarCoordenadas(6, 9);
            p2.zerarCoordenadas();
            c1.AdicionarPonto(p2);
            c1.ListarPontos();
            c1.AdicionarPonto(new Ponto(7, 2,"p3"));
            c1.ListarPontos();
        } 
    }
}