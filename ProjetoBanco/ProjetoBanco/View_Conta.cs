using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBanco
{
    public partial class View_Conta : Form
    {
        private Agencia agencia;

        public View_Conta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(boxnumero.Text);
            Conta conta = agencia.BuscarConta(numero);
            if (conta != null)
                MessageBox.Show($"Conta: {conta} agencia Busca da Conta");
            else
                MessageBox.Show("Conta não encontrada.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (agencia == null)
            {
                agencia = new Agencia(1, "Agência");
            }
            int numero = int.Parse(boxnumero.Text);
            string titular = boxtitulo.Text;
            double saldo = double.Parse(boxsaldo.Text);
            Conta conta = agencia.BuscarConta(numero);
            if (conta != null)
            {
                MessageBox.Show("Conta já cadastrada.");
                return;
            }
            else
            {
                agencia.AdicionarConta(new Conta(numero, titular, saldo));
            }
            conta = agencia.BuscarConta(numero);
            MessageBox.Show($"Conta: {conta} agencia Cadastro da Conta");
        }

        private void button3_Click(object sender, EventArgs e)
        {         
            int numero = int.Parse(boxnumero.Text);
            string titular = boxtitulo.Text;
            double saldo = double.Parse(boxsaldo.Text);
            Conta conta = agencia.BuscarConta(numero);
            if(conta != null)
            {
                conta.SetTitular(titular);
                conta.SetSaldo(saldo);
            }
            else
            {
                MessageBox.Show("Conta não encontrada.");
            }  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(boxnumero.Text);
            Conta conta = agencia.BuscarConta(numero);
            agencia.ExcluirConta(conta);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            agencia.ListarContas();
        }
    }
}
