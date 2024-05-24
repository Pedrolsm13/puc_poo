using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class PontoVO{
        private int codigo;
        private string descricao; 
        private double x; 
        private double y;
        public PontoVO(){
            this.descricao = "p"; this.x = 5; this.y = 5;
        }
        public PontoVO(string descricao): this(){            
            this.descricao = descricao;            
        }
        public PontoVO(int codigo, string descricao, double x, double y): this(descricao){
            this.x = x;
            this.y = y;
        }

        public int getCodigo()
        {
            return codigo;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public double getX() { 
            return x; 
        } 
        public void setX(double x) {
            this.x = x;
        }
        public double getY()
        {
            return y;
        }

        public void setY(double y)
        {
            this.y = y;
        }

        public String getDescricao()
        {
            return descricao;
        }

        public void setDescricao(String descricao)
        {
            this.descricao = descricao;
        }

        public void incrementarCoordenadas(int deltaX, int deltaY)
        {
            x = x + deltaX;
            y = y + deltaY;
        }

        public void imprimirCoordenadas()
        {
            // imprime as coordenadas x e y
            Console.WriteLine("(x, y)=" + "(" + x + ", " + y + ")");
        }

        public void zerarCoordenadas()
        {
            x = 0;
            y = 0;
        }
        
        public override string ToString()
        {
            return "Ponto{" + "descricao=" + descricao + ", x=" + x + ", y=" + y + '}';
        }

    }
}
