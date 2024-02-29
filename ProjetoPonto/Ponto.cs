using System;
using System.Collections.Generic;

namespace ProjetoPonto
{
    internal class Ponto
    {
        private int x;
        private int y;
        private string desc;
        public Ponto(){ 
            this.x = 0; 
            this.y = 0;
            this.desc = " ";
        } 
        public Ponto(int x, int y){ 
            this.x = x; 
            this.y = y;
            this.desc = " ";
        }
        public Ponto(int x, int y, string desc){ 
            this.x = x; 
            this.y = y;
            this.desc = desc;
        } 
        public void incrementarCoordenadas(int deltaX, int deltaY){ 
            this.x = this.x + deltaX; 
            this.y = this.y + deltaY; 
        } 
        public void imprimirCoordenadas(){ 
        // imprime as coordenadas x e y 
            Console.WriteLine($"(x, y) = ({x}, {y}) {desc}"); 
        } 
        public void zerarCoordenadas(){ 
            x = 0; 
            y = 0; 
        }
        public int getx()
        { return x; }
        public int gety()
        { return y; }
        public void setx(int x)
        { this.x = x; }
        public void sety(int y)
        { this.y = y; }
    }
}