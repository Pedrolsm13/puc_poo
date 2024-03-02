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
            List<Ponto> lista = new List<Ponto>(3);
            Random r = new Random();
            Console.WriteLine("Início do programa principal"); 
            Ponto p1 = new Ponto(); 
            p1.imprimirCoordenadas(); 
            p1.incrementarCoordenadas(5, 2); 
            p1.zerarCoordenadas(); 
            p1.imprimirCoordenadas(); 
            p1.incrementarCoordenadas(5, 2); 
            p1.zerarCoordenadas(); 
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
            Ponto p3 = new Ponto(2, 6);
            p3.imprimirCoordenadas();
            p3.incrementarCoordenadas(6, 9);
            p3.imprimirCoordenadas();
            p3.incrementarCoordenadas(5, 2);
            p3.imprimirCoordenadas();
            p3.zerarCoordenadas();
            
            Ponto p4 = new Ponto();
            p4.imprimirCoordenadas();
            p4.incrementarCoordenadas(6, 9);
            p4.imprimirCoordenadas();
            p4.incrementarCoordenadas(5, 2);
            p4.imprimirCoordenadas();
            p4.zerarCoordenadas();

            Ponto p5 = new Ponto(10,20);
            Ponto p6 = new Ponto(5,8);
            p5.incrementarCoordenadas(2,3);
            p5.imprimirCoordenadas();
            p6.imprimirCoordenadas();

            Console.WriteLine("digite quantos objetos serão implementados e digite x, y respectivamente");
            int qtd = int.Parse(Console.ReadLine());
            Ponto[] objeto = new Ponto[qtd];
            for(int k = 0; k < qtd; k++){
                int v1 = int.Parse(Console.ReadLine());
                int v2 = int.Parse(Console.ReadLine());
                if (v1 < 0 || v2 < 0)
                    break;
                else
                objeto[k] = new Ponto(v1, v2, $"objeto[{k}]");
                objeto[k].imprimirCoordenadas();
            }
            
            Console.WriteLine("digite quantos objetos serão implementados no arraylist e digite x, y respectivamente");
            int qtd1 = int.Parse(Console.ReadLine());
            ArrayList arrayList = new ArrayList(qtd1);
            int c1 = 0, c2 = 0, lm = 0;
            do{
                c1 = int.Parse(Console.ReadLine());
                c2 = int.Parse(Console.ReadLine());
                if (c1 < 0 || c2 < 0){
                    foreach (Ponto item in arrayList){
                        Console.WriteLine(item);
                    }
                    break;
                }
                arrayList.Add(new Ponto(c1, c2, $"objeto[{lm}]"));
                lm++;
            }while (c1 >= 0 || c2 >= 0);
            
            /*for(int k = 0; k < qtd1; k++){
                int v1 = int.Parse(Console.ReadLine());
                int v2 = int.Parse(Console.ReadLine());
                if (v1 < 0 || v2 < 0)
                    for(int l = 0; l < k; l++){
                        Console.WriteLine(arrayList[l]);
                    }
                else
                arrayList.Add(new Ponto(v1, v2, $"objeto[{k}]"));
            }*/
        } 
    }
}