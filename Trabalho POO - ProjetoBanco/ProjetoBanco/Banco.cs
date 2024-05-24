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
    public partial class Banco : Form
    {
        private View_Conta viewConta;

        public Banco()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewConta == null)
            {
                viewConta = new View_Conta();
            }
            viewConta.ShowDialog();
        }
    }
}
