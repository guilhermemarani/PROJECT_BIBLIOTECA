using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_BIBLIOTECA
{
    public partial class consulta_cliente : Form
    {
        public consulta_cliente()
        {
            InitializeComponent();

        }

        public void btnConsultar_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();

            con.conectar();

            if (txtConsulta.Text == string.Empty)
            {
                MessageBox.Show("Um dos campos de dados pessoais está em branco", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConsulta.Focus();
            }
            else
            {
                if (cb_filtro.Text == "Nome") // quando o filtro estiver como nome será executado esse comando
                {
                    try
                    {
                        //buscando os dados do cliente informado na base de dados
                        string sql = "SELECT * FROM CLIENTE WHERE NOME='" + txtConsulta.Text + "'";
                        SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con.conn);
                        DataTable cliente = new DataTable();
                        da.Fill(cliente);

                        //transferindo os dados do banco para os textbox do sistema
                        codCliente.Text = cliente.Rows[0]["CODCLIENTE"].ToString();
                        txt_nome.Text = cliente.Rows[0]["NOME"].ToString();
                        txt_idade.Text = cliente.Rows[0]["IDADE"].ToString();
                        cb_sexo.Text = cliente.Rows[0]["SEXO"].ToString();
                        txt_estado_civil.Text = cliente.Rows[0]["ESTADOCIVIL"].ToString();
                        txt_email.Text = cliente.Rows[0]["EMAIL"].ToString();

                        //armazenando o codEndereco encontrado para utilizar na busca do endereço do cliente
                        string codEndereco = cliente.Rows[0]["CODENDERECO"].ToString();

                        //buscando os dados do endereco com o codendereco do cliente
                        string sqlEnd = "SELECT * FROM ENDERECO WHERE CODENDERECO='" + codEndereco + "'";
                        SQLiteDataAdapter daEnd = new SQLiteDataAdapter(sqlEnd, con.conn);
                        DataTable endereco = new DataTable();
                        daEnd.Fill(endereco);

                        //transferindo os dados do endereço para os textbox do sistema
                        txt_rua.Text = endereco.Rows[0]["RUA"].ToString();
                        txt_numero.Text = endereco.Rows[0]["NUMERO"].ToString();
                        txt_bairro.Text = endereco.Rows[0]["BAIRRO"].ToString();
                        txt_cidade.Text = endereco.Rows[0]["CIDADE"].ToString();
                        cb_estado.Text = endereco.Rows[0]["ESTADO"].ToString();
                        txt_cep.Text = endereco.Rows[0]["CEP"].ToString();

                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message.ToString(), "Erro: não foi possivel conectar a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cb_filtro.Text == "Email") // ao escolher o filtro email será executado esse bloco
                {
                    try
                    {

                        string sql = "SELECT * FROM CLIENTE WHERE EMAIL='" + txtConsulta.Text + "'";
                        SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con.conn);
                        DataTable cliente = new DataTable();
                        da.Fill(cliente);

                        codCliente.Text = cliente.Rows[0]["CODCLIENTE"].ToString();
                        txt_nome.Text = cliente.Rows[0]["NOME"].ToString();
                        txt_idade.Text = cliente.Rows[0]["IDADE"].ToString();
                        cb_sexo.Text = cliente.Rows[0]["SEXO"].ToString();
                        txt_estado_civil.Text = cliente.Rows[0]["ESTADOCIVIL"].ToString();
                        txt_email.Text = cliente.Rows[0]["EMAIL"].ToString();

                        string codEndereco = cliente.Rows[0]["CODENDERECO"].ToString();

                        string sqlEnd = "SELECT * FROM ENDERECO WHERE CODENDERECO='" + codEndereco + "'";
                        SQLiteDataAdapter daEnd = new SQLiteDataAdapter(sqlEnd, con.conn);
                        DataTable endereco = new DataTable();
                        daEnd.Fill(endereco);

                        txt_rua.Text = endereco.Rows[0]["RUA"].ToString();
                        txt_numero.Text = endereco.Rows[0]["NUMERO"].ToString();
                        txt_bairro.Text = endereco.Rows[0]["BAIRRO"].ToString();
                        txt_cidade.Text = endereco.Rows[0]["CIDADE"].ToString();
                        cb_estado.Text = endereco.Rows[0]["ESTADO"].ToString();
                        txt_cep.Text = endereco.Rows[0]["CEP"].ToString();

                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message.ToString(), "Erro: não foi possivel conectar a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cb_filtro.Text == "Código") // ao escolher o filtro código será executado esse bloco
                {
                    try
                    {

                        string sql = "SELECT * FROM CLIENTE WHERE CODCLIENTE='" + txtConsulta.Text + "'";
                        SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con.conn);
                        DataTable cliente = new DataTable();
                        da.Fill(cliente);

                        codCliente.Text = cliente.Rows[0]["CODCLIENTE"].ToString();
                        txt_nome.Text = cliente.Rows[0]["NOME"].ToString();
                        txt_idade.Text = cliente.Rows[0]["IDADE"].ToString();
                        cb_sexo.Text = cliente.Rows[0]["SEXO"].ToString();
                        txt_estado_civil.Text = cliente.Rows[0]["ESTADOCIVIL"].ToString();
                        txt_email.Text = cliente.Rows[0]["EMAIL"].ToString();

                        string codEndereco = cliente.Rows[0]["CODENDERECO"].ToString();

                        string sqlEnd = "SELECT * FROM ENDERECO WHERE CODENDERECO='" + codEndereco + "'";
                        SQLiteDataAdapter daEnd = new SQLiteDataAdapter(sqlEnd, con.conn);
                        DataTable endereco = new DataTable();
                        daEnd.Fill(endereco);

                        txt_rua.Text = endereco.Rows[0]["RUA"].ToString();
                        txt_numero.Text = endereco.Rows[0]["NUMERO"].ToString();
                        txt_bairro.Text = endereco.Rows[0]["BAIRRO"].ToString();
                        txt_cidade.Text = endereco.Rows[0]["CIDADE"].ToString();
                        cb_estado.Text = endereco.Rows[0]["ESTADO"].ToString();
                        txt_cep.Text = endereco.Rows[0]["CEP"].ToString();

                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message.ToString(), "Erro: não foi possivel conectar a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            con.desconectar();
        }

        private void cb_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //bloco executado ao clicar em Editar

            //nesse bloco só altero o modo leitura para que os campos sejam editados
            txt_nome.ReadOnly = false;
            txt_idade.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_estado_civil.ReadOnly = false;
            txt_rua.ReadOnly = false;
            txt_numero.ReadOnly = false;
            txt_bairro.ReadOnly = false;
            txt_cidade.ReadOnly = false;
            txt_cep.ReadOnly = false;


        }

        private void btn_salvar_Click(object sender, EventArgs e)  //bloco executado ao clicar em salvar
        {
            Conexao con = new Conexao();

            try
            {
                con.conectar();

                //utilizando os dados já expostos nos textbox aqui será feito o update
                string sql = "UPDATE CLIENTE SET NOME='" + txt_nome.Text + "', IDADE='" + txt_idade.Text + "', SEXO='" + cb_sexo.Text + "', EMAIL='" + txt_email.Text + "' WHERE CODCLIENTE='" + codCliente.Text + "'";
                SQLiteCommand cmd = new SQLiteCommand(sql, con.conn);
                

                //buscando o codEndereco do cliente
                string sqlEnd = "SELECT CODENDERECO FROM CLIENTE WHERE CODCLIENTE='" + codCliente.Text + "'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlEnd, con.conn);
                DataTable endereco = new DataTable();
                da.Fill(endereco);

                //atualizando os dados do endereço
                string atualizaEndereco = "UPDATE ENDERECO SET RUA='" + txt_rua.Text + "', NUMERO='" + txt_numero.Text + "', BAIRRO='" + txt_bairro.Text + "', CEP='" + txt_cep.Text + "', CIDADE='" + txt_cidade.Text + "', ESTADO='" + cb_estado.Text + "' WHERE CODENDERECO='" + endereco.Rows[0]["CODENDERECO"] + "'";
                SQLiteCommand cmdEnd = new SQLiteCommand(atualizaEndereco, con.conn);

                //execução dos comandos na base de dados.
                cmd.ExecuteNonQuery();
                cmdEnd.ExecuteNonQuery();

                MessageBox.Show("Dados atualizados com sucesso", "Alterando dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch(Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "Erro: não foi possivel conectar a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.desconectar();
        }

        private void btn_excluir_Click(object sender, EventArgs e) //bloco executado ao clicar em Excluir
        {
            Conexao con = new Conexao();

            con.conectar();

            try
            {
                //Comando para deletar o registro selecionado
                string delCliente = "DELETE FROM CLIENTE WHERE CODCLIENTE='" + codCliente.Text + "'";
                SQLiteCommand cmdCliente = new SQLiteCommand(delCliente, con.conn);
                
                //buscando codEndereco do cliente
                string encontraEnd = "SELECT CODENDERECO FROM CLIENTE WHERE CODCLIENTE='" + codCliente.Text + "'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(encontraEnd, con.conn);
                DataTable endereco = new DataTable();
                da.Fill(endereco);

                //Comando para deletar registro selecionado
                string delEndereco = "DELETE FROM ENDERECO WHERE CODENDERECO='" + endereco.Rows[0]["CODENDERECO"] + "'";
                SQLiteCommand cmdEndereco = new SQLiteCommand(delEndereco, con.conn);


                //Comandos estou passando a executar por ultimo, neste caso estava sendo excluido o registro do cliente e não conseguindo buscar o codendereco do mesmo
                cmdCliente.ExecuteNonQuery();
                cmdEndereco.ExecuteNonQuery();


                MessageBox.Show("Registro excluido com sucesso", "Exclusão de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch(Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "Erro: não foi possivel conectar a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.desconectar();
        }
    }
}
