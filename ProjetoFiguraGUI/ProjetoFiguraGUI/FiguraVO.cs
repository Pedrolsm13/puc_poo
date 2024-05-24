﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class FiguraVO
    {
        protected int codigo;
        protected string descricao;
        protected PontoVO ancora;

        public FiguraVO()
        {
            this.ancora = new PontoVO();
        }
        public FiguraVO(int codigo, string descricao): this()
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }
        public FiguraVO(int codigo, string descricao, PontoVO ancora): this(codigo, descricao)
        {
            this.ancora = ancora;
        }


        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getCodigo()
        {
            return codigo;
        }

        public void setAncora(PontoVO ancora)
        {
            this.ancora = ancora;
        }
        public PontoVO getAncora()
        {
            return ancora;
        }

        public String getDescricao()
        {
            return descricao;
        }

        public void setDescricao(String descricao)
        {
            this.descricao = descricao;
        }
        public override string ToString()
        {
            return "Figura{" + "Código=" + codigo + ", descricao=" + descricao + '}';
        }
        public virtual double calcularArea()
        {
            return 0;
        }
        public virtual void imprimirDados()
        {
            Console.Write("\n\nCódigo: "+codigo+", \tdescrição: "+descricao);
        }

    }
}
