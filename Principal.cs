using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_BIBLIOTECA
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulta_cliente consulta_Cliente = new consulta_cliente();
            consulta_Cliente.ShowDialog();
        }
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_pessoa cadastro_Pessoa = new Cadastro_pessoa();
            cadastro_Pessoa.ShowDialog();
        }
    }
}
