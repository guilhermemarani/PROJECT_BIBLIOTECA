using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PROJECT_BIBLIOTECA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(txt_email.Text == string.Empty || txt_senha.Text == string.Empty)
            {
                MessageBox.Show("Os campos estão em branco", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_senha.Clear();
                txt_email.Focus();
            }
            else
            {
                Conexao con = new Conexao();

                try
                {
                    con.conectar();

                    string sql = "SELECT * FROM USUARIO where email='" + txt_email.Text + "' and senha='" + txt_senha.Text + "'";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con.conn);
                    DataTable usuario = new DataTable();

                    da.Fill(usuario);

                    if(usuario.Rows.Count < 1)
                    {
                        MessageBox.Show("Usuario inexistente", "Registro não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_senha.Clear();
                        txt_email.Focus();
                    }
                    else
                    {
                        string nome = usuario.Rows[0]["nome"].ToString();
                        MessageBox.Show("Seja bem vindo "+nome,"Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Principal principal = new Principal();
                        principal.ShowDialog();
                    }
                }
                catch(Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro_pessoa cadastro = new Cadastro_pessoa();
            cadastro.ShowDialog();

        }
    }
}
