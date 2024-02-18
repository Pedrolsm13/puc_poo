using System;
using System.Collections.Generic;

namespace ProjetoPonto
{
    internal class Ponto
    {
        public int x;
        public int y;
        public void incrementarCoordenadas(int deltaX, int deltaY){ 
            this.x = this.x + deltaX; 
            this.y = this.y + deltaY; 
        } 
        public void imprimirCoordenadas(){ 
        // imprime as coordenadas x e y 
            Console.WriteLine($"(x, y) = ({x}, {y})"); 
        } 
        public void zerarCoordenadas(){ 
            x = 0; 
            y = 0; 
        }
    }
}