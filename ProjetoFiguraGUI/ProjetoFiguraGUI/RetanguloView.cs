using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controller;
using model;

namespace view
{
    public partial class RetanguloView : Form
    {
        private ConjuntoHelper conjuntoHelper;

        public RetanguloView()
        {
            InitializeComponent();
            conjuntoHelper = ConjuntoHelper.getInstance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConjuntoHelper conjuntoHelper = ConjuntoHelper.getInstance();
            RetanguloVO retanguloVO = null;
            double comprimento = 0, altura = 0;
            int codigo = 0;

            try
            {
                comprimento = double.Parse(txtBase.Text);

            }
            catch (Exception e2)
            {
                MessageBox.Show("Comprimento inválido!");
                return;
            }
            try
            {
                altura = double.Parse(txtAltura.Text);

            }
            catch (Exception e2)
            {
                MessageBox.Show("Altura inválida!");
                return;
            }

            try
            {
                codigo = int.Parse(txtCodigo.Text);

            }
            catch (Exception e2)
            {
                MessageBox.Show("Cogigo inválido!");
                return;
            }

            retanguloVO = new RetanguloVO(codigo, "retângulo 1", comprimento, altura);
            if (conjuntoHelper.adicionar(retanguloVO) > 0)
            {
                MessageBox.Show("Objeto inserido com sucesso!");                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            RetanguloVO retanguloVO = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            ConjuntoHelper conjuntoHelper = ConjuntoHelper.getInstance();
            FiguraVO retangulo = conjuntoHelper.visualizar(codigo);
            if (retangulo != null)
            {
                MessageBox.Show($"{retangulo}");
            }
            else
            {
                MessageBox.Show("nao encontrado");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            double comprimento = double.Parse(txtBase.Text);
            double altura = double.Parse(txtAltura.Text);
            ConjuntoHelper conjuntoHelper = ConjuntoHelper.getInstance();
            FiguraVO retanguloVO = new RetanguloVO(codigo, "retângulo", comprimento, altura);
            bool resp = conjuntoHelper.alterar(codigo, retanguloVO);
            if (resp) { MessageBox.Show($"Alterado!!!"); }
            else { MessageBox.Show("Conta alterado."); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            ConjuntoHelper conjuntoHelper = ConjuntoHelper.getInstance();
            FiguraVO retanguloVO = conjuntoHelper.pesquisar(codigo);
            if (retanguloVO != null) { 
                conjuntoHelper.excluir(retanguloVO);
                MessageBox.Show("obj excluido");
            }
            else
            {
                MessageBox.Show("obj nao encontrado");
            }
        }
    }
}
