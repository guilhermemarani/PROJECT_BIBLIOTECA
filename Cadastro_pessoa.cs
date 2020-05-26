using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_BIBLIOTECA
{
    public partial class Cadastro_pessoa : Form
    {
        public Cadastro_pessoa()
        {
            InitializeComponent();

            Conexao con = new Conexao();

            try //Try feito para trazer o código do cliente que será incluso na base de dados
            {
                con.conectar();

                string sql = "SELECT MAX(CODCLIENTE),* FROM CLIENTE";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con.conn);
                DataTable codClientedb = new DataTable();
                da.Fill(codClientedb);

                int conversaoCliente = Convert.ToInt32(codClientedb.Rows[0]["CODCLIENTE"]) + 1;
                codCliente.Text = conversaoCliente.ToString();

            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "Erro: não foi possivel conectar a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.desconectar();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            if(txt_nome.Text == string.Empty || txt_idade.Text == string.Empty || cb_sexo.Text == string.Empty || txt_estado_civil.Text == string.Empty || txt_email.Text == string.Empty)
            {
                MessageBox.Show("Um dos campos de dados pessoais está em branco", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nome.Focus();
            }else if(txt_rua.Text == string.Empty || txt_numero.Text == string.Empty || txt_cep.Text == string.Empty || txt_bairro.Text == string.Empty || txt_cidade.Text == string.Empty || cb_estado.Text == string.Empty){
                MessageBox.Show("Um dos campos do endereço está em branco", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_rua.Focus();
            }
            else
            {
                Conexao conCadastro = new Conexao();

                try //Neste Try estamos tratando os dados inseridos no cadastro de pessoa, aqui associamos o endereço ao cliente na base de dados.
                {
                    conCadastro.conectar();

                    //Comando para inserir um novo endereço
                    string sqlEndereco = "INSERT INTO ENDERECO(RUA, NUMERO, BAIRRO, CIDADE, ESTADO, CEP) VALUES ('" + txt_rua.Text + "','" + txt_numero.Text + "','" + txt_bairro.Text + "','" + txt_cidade.Text + "','" + cb_estado.Text + "','"+ txt_cep.Text +"')";

                    //Executando o comando acima
                    SQLiteCommand cmdEndereco = new SQLiteCommand(sqlEndereco, conCadastro.conn); 
                    cmdEndereco.ExecuteNonQuery();

                    //No bloco abaixo estamos buscando o ultimo endereço cadastrado e armazenando na variavel CodEndereco para associar ao cliente cadastrado.
                    string sqlCodEndereco = "SELECT MAX(CODENDERECO),* FROM ENDERECO";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlCodEndereco, conCadastro.conn);
                    DataTable CodEnderecodb = new DataTable();
                    da.Fill(CodEnderecodb);
                    string CodEndereco = CodEnderecodb.Rows[0]["CODENDERECO"].ToString();

                    //comando para inserir dados do cliente, aqui já incluimos os dados armazenados em CodEndereco
                    string sqlDados = "INSERT INTO CLIENTE(NOME, IDADE, SEXO, ESTADOCIVIL, EMAIL, CODENDERECO) VALUES('" + txt_nome.Text + "','" + txt_idade.Text + "','" + cb_sexo.Text + "','" + txt_estado_civil.Text + "','" + txt_email.Text + "','" + CodEndereco + "')";

                    //Executando o comando acima
                    SQLiteCommand cmdDados = new SQLiteCommand(sqlDados, conCadastro.conn);
                    cmdDados.ExecuteNonQuery();

                    MessageBox.Show("Registro efetuado com sucesso", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } catch(Exception E)
                {
                    MessageBox.Show(E.Message.ToString(), "Erro: não foi possivel conectar a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conCadastro.desconectar();
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
