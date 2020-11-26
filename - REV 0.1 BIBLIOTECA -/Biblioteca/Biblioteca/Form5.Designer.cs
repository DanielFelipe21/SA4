namespace Biblioteca
{
    partial class Form5
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtLancamento = new System.Windows.Forms.TextBox();
            this.listaDeLivros = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lbEmprestados = new System.Windows.Forms.Label();
            this.lbExemplares = new System.Windows.Forms.Label();
            this.lbDoacao = new System.Windows.Forms.Label();
            this.lbMaisEmprestado = new System.Windows.Forms.Label();
            this.lbMenosEmprestado = new System.Windows.Forms.Label();
            this.lbSaldoFinal = new System.Windows.Forms.Label();
            this.lbMaisExemplares = new System.Windows.Forms.Label();
            this.lbEmprestimoPara = new System.Windows.Forms.Label();
            this.cbEmprestimoPara = new System.Windows.Forms.ComboBox();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tipo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Unidades:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Editora:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Lançamento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Autor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome do Livro:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(221, 62);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 217);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(221, 62);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(109, 115);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(124, 20);
            this.txtUnidades.TabIndex = 20;
            this.txtUnidades.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(109, 89);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(124, 20);
            this.txtEditora.TabIndex = 19;
            this.txtEditora.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(109, 37);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(124, 20);
            this.txtAutor.TabIndex = 17;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(109, 11);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(124, 20);
            this.txtNomeLivro.TabIndex = 16;
            this.txtNomeLivro.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Unidades";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Editora";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lançamento";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Autor";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome do Livro";
            this.columnHeader1.Width = 86;
            // 
            // txtLancamento
            // 
            this.txtLancamento.Location = new System.Drawing.Point(109, 63);
            this.txtLancamento.Name = "txtLancamento";
            this.txtLancamento.Size = new System.Drawing.Size(124, 20);
            this.txtLancamento.TabIndex = 18;
            this.txtLancamento.TextChanged += new System.EventHandler(this.txtDataNascimento_TextChanged);
            // 
            // listaDeLivros
            // 
            this.listaDeLivros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader6});
            this.listaDeLivros.Cursor = System.Windows.Forms.Cursors.Default;
            this.listaDeLivros.HideSelection = false;
            this.listaDeLivros.Location = new System.Drawing.Point(239, 11);
            this.listaDeLivros.Name = "listaDeLivros";
            this.listaDeLivros.Size = new System.Drawing.Size(606, 268);
            this.listaDeLivros.TabIndex = 15;
            this.listaDeLivros.UseCompatibleStateImageBehavior = false;
            this.listaDeLivros.View = System.Windows.Forms.View.Details;
            this.listaDeLivros.SelectedIndexChanged += new System.EventHandler(this.listaDeClientes_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tipo";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Preço";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Emprestimo para:";
            this.columnHeader6.Width = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Preço Únitario:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(109, 167);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(124, 20);
            this.txtPreco.TabIndex = 30;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Venda",
            "Doação",
            "Emprestimo"});
            this.cbTipo.Location = new System.Drawing.Point(109, 140);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(124, 21);
            this.cbTipo.TabIndex = 32;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // lbEmprestados
            // 
            this.lbEmprestados.AutoSize = true;
            this.lbEmprestados.Location = new System.Drawing.Point(236, 282);
            this.lbEmprestados.Name = "lbEmprestados";
            this.lbEmprestados.Size = new System.Drawing.Size(102, 13);
            this.lbEmprestados.TabIndex = 33;
            this.lbEmprestados.Text = "Livros Emprestados:";
            // 
            // lbExemplares
            // 
            this.lbExemplares.AutoSize = true;
            this.lbExemplares.Location = new System.Drawing.Point(463, 282);
            this.lbExemplares.Name = "lbExemplares";
            this.lbExemplares.Size = new System.Drawing.Size(119, 13);
            this.lbExemplares.TabIndex = 34;
            this.lbExemplares.Text = "Número de Exemplares:";
            // 
            // lbDoacao
            // 
            this.lbDoacao.AutoSize = true;
            this.lbDoacao.Location = new System.Drawing.Point(691, 282);
            this.lbDoacao.Name = "lbDoacao";
            this.lbDoacao.Size = new System.Drawing.Size(103, 13);
            this.lbDoacao.TabIndex = 35;
            this.lbDoacao.Text = "Livros para Doação:";
            // 
            // lbMaisEmprestado
            // 
            this.lbMaisEmprestado.AutoSize = true;
            this.lbMaisEmprestado.Location = new System.Drawing.Point(236, 308);
            this.lbMaisEmprestado.Name = "lbMaisEmprestado";
            this.lbMaisEmprestado.Size = new System.Drawing.Size(116, 13);
            this.lbMaisEmprestado.TabIndex = 36;
            this.lbMaisEmprestado.Text = "Livro mais Emprestado:";
            // 
            // lbMenosEmprestado
            // 
            this.lbMenosEmprestado.AutoSize = true;
            this.lbMenosEmprestado.Location = new System.Drawing.Point(463, 308);
            this.lbMenosEmprestado.Name = "lbMenosEmprestado";
            this.lbMenosEmprestado.Size = new System.Drawing.Size(126, 13);
            this.lbMenosEmprestado.TabIndex = 37;
            this.lbMenosEmprestado.Text = "Livro menos Emprestado:";
            // 
            // lbSaldoFinal
            // 
            this.lbSaldoFinal.AutoSize = true;
            this.lbSaldoFinal.Location = new System.Drawing.Point(236, 331);
            this.lbSaldoFinal.Name = "lbSaldoFinal";
            this.lbSaldoFinal.Size = new System.Drawing.Size(62, 13);
            this.lbSaldoFinal.TabIndex = 38;
            this.lbSaldoFinal.Text = "Salvo Final:";
            // 
            // lbMaisExemplares
            // 
            this.lbMaisExemplares.AutoSize = true;
            this.lbMaisExemplares.Location = new System.Drawing.Point(691, 307);
            this.lbMaisExemplares.Name = "lbMaisExemplares";
            this.lbMaisExemplares.Size = new System.Drawing.Size(137, 13);
            this.lbMaisExemplares.TabIndex = 39;
            this.lbMaisExemplares.Text = "Livro com mais Exemplares:";
            // 
            // lbEmprestimoPara
            // 
            this.lbEmprestimoPara.AutoSize = true;
            this.lbEmprestimoPara.Location = new System.Drawing.Point(12, 198);
            this.lbEmprestimoPara.Name = "lbEmprestimoPara";
            this.lbEmprestimoPara.Size = new System.Drawing.Size(89, 13);
            this.lbEmprestimoPara.TabIndex = 41;
            this.lbEmprestimoPara.Text = "Emprestimo Para:";
            // 
            // cbEmprestimoPara
            // 
            this.cbEmprestimoPara.FormattingEnabled = true;
            this.cbEmprestimoPara.Location = new System.Drawing.Point(109, 190);
            this.cbEmprestimoPara.Name = "cbEmprestimoPara";
            this.cbEmprestimoPara.Size = new System.Drawing.Size(124, 21);
            this.cbEmprestimoPara.TabIndex = 42;
            // 
            // lbRegistros
            // 
            this.lbRegistros.AutoSize = true;
            this.lbRegistros.Location = new System.Drawing.Point(463, 331);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Size = new System.Drawing.Size(96, 13);
            this.lbRegistros.TabIndex = 43;
            this.lbRegistros.Text = "Total de Registros:";
            this.lbRegistros.Click += new System.EventHandler(this.lbRegistros_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 354);
            this.Controls.Add(this.lbRegistros);
            this.Controls.Add(this.cbEmprestimoPara);
            this.Controls.Add(this.lbEmprestimoPara);
            this.Controls.Add(this.lbMaisExemplares);
            this.Controls.Add(this.lbSaldoFinal);
            this.Controls.Add(this.lbMenosEmprestado);
            this.Controls.Add(this.lbMaisEmprestado);
            this.Controls.Add(this.lbDoacao);
            this.Controls.Add(this.lbExemplares);
            this.Controls.Add(this.lbEmprestados);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.txtLancamento);
            this.Controls.Add(this.listaDeLivros);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtLancamento;
        private System.Windows.Forms.ListView listaDeLivros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lbEmprestados;
        private System.Windows.Forms.Label lbExemplares;
        private System.Windows.Forms.Label lbDoacao;
        private System.Windows.Forms.Label lbMaisEmprestado;
        private System.Windows.Forms.Label lbMenosEmprestado;
        private System.Windows.Forms.Label lbSaldoFinal;
        private System.Windows.Forms.Label lbMaisExemplares;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lbEmprestimoPara;
        private System.Windows.Forms.ComboBox cbEmprestimoPara;
        private System.Windows.Forms.Label lbRegistros;
    }
}