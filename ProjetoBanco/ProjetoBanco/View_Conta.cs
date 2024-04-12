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

        private void button2_Click(object sender, EventArgs e)
        {
            if (agencia == null)
            {
                agencia = new Agencia(1, "Agência");
            }
            int numero = int.Parse(boxnumero.Text);
            string titular = boxtitulo.Text;
            double saldo = double.Parse(boxsaldo.Text);
            agencia.AdicionarConta(new Conta(numero, titular, saldo));
            MessageBox.Show("Conta:" + agencia, "Cadastro da Conta");
        }
    }
}
