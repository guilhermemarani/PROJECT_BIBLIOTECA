namespace PROJECT_BIBLIOTECA
{
    partial class consulta_cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_estado_civil = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.codCliente = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta Cliente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 63;
            this.label14.Text = "Filtro:";
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(16, 364);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(184, 29);
            this.btn_editar.TabIndex = 61;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(319, 256);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(27, 20);
            this.txt_numero.TabIndex = 60;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(69, 307);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.ReadOnly = true;
            this.txt_cidade.Size = new System.Drawing.Size(100, 20);
            this.txt_cidade.TabIndex = 59;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(205, 281);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.ReadOnly = true;
            this.txt_bairro.Size = new System.Drawing.Size(100, 20);
            this.txt_bairro.TabIndex = 58;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(56, 281);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.ReadOnly = true;
            this.txt_cep.Size = new System.Drawing.Size(100, 20);
            this.txt_cep.TabIndex = 57;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(56, 256);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.ReadOnly = true;
            this.txt_rua.Size = new System.Drawing.Size(221, 20);
            this.txt_rua.TabIndex = 56;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "RS",
            "PR",
            "AM",
            "RR"});
            this.cb_estado.Location = new System.Drawing.Point(224, 306);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(39, 21);
            this.cb_estado.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(175, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Cidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "CEP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Nº:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Rua:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 29);
            this.label7.TabIndex = 48;
            this.label7.Text = "Endereço";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(56, 189);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(194, 20);
            this.txt_email.TabIndex = 47;
            // 
            // txt_estado_civil
            // 
            this.txt_estado_civil.Location = new System.Drawing.Point(82, 164);
            this.txt_estado_civil.Name = "txt_estado_civil";
            this.txt_estado_civil.ReadOnly = true;
            this.txt_estado_civil.Size = new System.Drawing.Size(100, 20);
            this.txt_estado_civil.TabIndex = 46;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(56, 136);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.ReadOnly = true;
            this.txt_idade.Size = new System.Drawing.Size(29, 20);
            this.txt_idade.TabIndex = 45;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(56, 110);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(274, 20);
            this.txt_nome.TabIndex = 44;
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Não informar"});
            this.cb_sexo.Location = new System.Drawing.Point(145, 135);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(121, 21);
            this.cb_sexo.TabIndex = 43;
            this.cb_sexo.SelectedIndexChanged += new System.EventHandler(this.cb_sexo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Email: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Estado civil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Sexo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Idade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Nome:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(299, 48);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(184, 22);
            this.btnConsultar.TabIndex = 64;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(193, 49);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtConsulta.TabIndex = 65;
            // 
            // cb_filtro
            // 
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "Nome",
            "Código",
            "Email"});
            this.cb_filtro.Location = new System.Drawing.Point(53, 47);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(121, 21);
            this.cb_filtro.TabIndex = 66;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 68;
            this.label15.Text = "Código: ";
            // 
            // codCliente
            // 
            this.codCliente.AutoSize = true;
            this.codCliente.Location = new System.Drawing.Point(59, 94);
            this.codCliente.Name = "codCliente";
            this.codCliente.Size = new System.Drawing.Size(16, 13);
            this.codCliente.TabIndex = 67;
            this.codCliente.Text = "...";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(206, 364);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(184, 29);
            this.btn_salvar.TabIndex = 69;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(396, 364);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(184, 29);
            this.btn_excluir.TabIndex = 70;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // consulta_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.codCliente);
            this.Controls.Add(this.cb_filtro);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_estado_civil);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "consulta_cliente";
            this.Text = "consulta_cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_estado_civil;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label codCliente;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
    }
}