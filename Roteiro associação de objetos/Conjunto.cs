using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoPonto
{
    internal class Conjunto
    {
        private int cod;
        private string desc;
        private ArrayList lPonto;
        public Conjunto(string desc, int cod)
        {
            this.desc = desc;
            this.cod = cod;
            lPonto = new ArrayList();
        }
        public int GetCod()
        { return cod; }

        public string GetDesc()
        { return desc; }

        public void SetCod(int cod)
        { this.cod = cod; }

        public void SetDescricao(string desc)
        { this.desc = desc; }

        public override string ToString()
        {
            return $"Conjunto(Código= {cod} Descrição= {desc} Total de Pontos= {lPonto.Count}";
        }
        
         public int AdicionarPonto(Ponto ponto)
        {
            lPonto.Add(ponto);
            return lPonto.Count;
        }

        public int ExcluirPonto(Ponto ponto)
        {
            lPonto.Remove(ponto);
            return lPonto.Count;
        }

        public void ListarPontos()
        {
            Console.WriteLine($"Pontos do Conjunto {desc}:");

            foreach (Ponto ponto in lPonto)
            {
                Console.WriteLine(ponto);
            }
        }
    }
}