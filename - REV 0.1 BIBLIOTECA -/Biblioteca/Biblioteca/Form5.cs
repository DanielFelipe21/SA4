using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form5 : Form
    {
        Form4 instanciaDoForm4;
        public Form5(Form4 frm4)
        {
            instanciaDoForm4 = frm4;
            InitializeComponent();
            cbEmprestimoPara.Enabled = false;
            for (int i = 0; i < instanciaDoForm4.listaDeClientes.Items.Count; i++)
            {
                cbEmprestimoPara.Items.Add(instanciaDoForm4.listaDeClientes.Items[i].SubItems[3].Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (sender == btnSalvar)
            {
                if (txtPreco.Text == "")
                {
                    txtPreco.Text = "0";
                }
                var validateError = string.Empty;
                if (txtNomeLivro.Text.Length == 0)
                    validateError = "- O livro precisa de um nome para ser cadastrado.";
                if (txtAutor.Text.Length == 0)
                    validateError = "- O livro precisa de um autor para ser cadastrado.";
                if (txtEditora.Text.Length == 0)
                    validateError = "- O livro precisa de uma editora para ser cadastrado.";
                if (txtUnidades.Text.Length == 0)
                    validateError = "- O livro precisa de alguma unidade para ser cadastrado.";
                if (cbTipo.Text.Length == 0)
                    validateError = "- O livro precisa de um tipo para ser cadastrado.";
                if (validateError != string.Empty)
                {
                    MessageBox.Show(validateError.Replace('.', '\n'), @"O cadastro está incompleto", MessageBoxButtons.OK);
                    return;
                }
                if (cbTipo.Text == "Emprestimo")
                {
                    ListViewItem varItem = new ListViewItem(new string[] { txtNomeLivro.Text,
                                                                txtAutor.Text,
                                                                txtLancamento.Text,
                                                                txtEditora.Text,
                                                                txtUnidades.Text,
                                                                cbTipo.Text,
                                                                txtPreco.Text,
                                                                cbEmprestimoPara.Text
                                                               });
                    listaDeLivros.Items.Add(varItem);
                    listaDeLivros.Items[listaDeLivros.Items.Count - 1].EnsureVisible();
                }
                else
                {
                    ListViewItem varItem = new ListViewItem(new string[] { txtNomeLivro.Text,
                                                                txtAutor.Text,
                                                                txtLancamento.Text,
                                                                txtEditora.Text,
                                                                txtUnidades.Text,
                                                                cbTipo.Text,
                                                                txtPreco.Text,
                                                                "############"
                                                               });
                    listaDeLivros.Items.Add(varItem);
                    listaDeLivros.Items[listaDeLivros.Items.Count - 1].EnsureVisible();
                }
                ////////////////////////////////////////////////////////////////////////////////////
                for (int i = 0; i < listaDeLivros.Items.Count; i++)
                {
                    var max = listaDeLivros.Items.Cast<ListViewItem>().Max(x => int.Parse(x.SubItems[4].Text));
                    if (listaDeLivros.Items[i].SubItems[4].Text == max.ToString())
                    {
                    string maisExemplares = listaDeLivros.Items[i].SubItems[0].Text;
                    lbMaisExemplares.Text = string.Format("Livro com mais Exemplares: {0}", maisExemplares);
                    }
                }
                ////////////////////////////////////////////////////////////////////////////////////
                var totalDeExemplares = 0m;
                for (int i = 0; i < listaDeLivros.Items.Count; i++)
                {
                    totalDeExemplares += decimal.Parse(listaDeLivros.Items[i].SubItems[4].Text);
                }
                lbExemplares.Text = string.Format("Número de Exemplares: {0}", totalDeExemplares);
                ////////////////////////////////////////////////////////////////////////////////////
                int totalDeEmprestados = 0;
                for (int i = 0; i < listaDeLivros.Items.Count; i++)
                {
                    if (listaDeLivros.Items[i].SubItems[5].Text == "Emprestimo")
                    {
                        totalDeEmprestados = totalDeEmprestados + 1;
                    }
                }
                lbEmprestados.Text = string.Format("Livros Emprestados: {0}", totalDeEmprestados);
                ////////////////////////////////////////////////////////////////////////////////////
                int totalDeDoacao = 0;
                for (int i = 0; i < listaDeLivros.Items.Count; i++)
                {
                    if (listaDeLivros.Items[i].SubItems[5].Text == "Doação")
                    {
                        totalDeDoacao = totalDeDoacao + 1;
                    }
                }
                lbDoacao.Text = string.Format("Livros para Doação: {0}", totalDeDoacao);
                ////////////////////////////////////////////////////////////////////////////////////
                var saldoFinal = 0m;
                for (int i = 0; i < listaDeLivros.Items.Count; i++)
                {
                    var quantidadeDeLivros = decimal.Parse(listaDeLivros.Items[i].SubItems[4].Text);
                    var precoDoLivro = decimal.Parse(listaDeLivros.Items[i].SubItems[6].Text);

                    saldoFinal += (quantidadeDeLivros * precoDoLivro);
                }
                lbSaldoFinal.Text = string.Format("Saldo Final: R${0}", saldoFinal.ToString("N2"));
                ////////////////////////////////////////////////////////////////////////////////////
                for (int i = 0; i < listaDeLivros.Items.Count; i++)
                {
                    if (listaDeLivros.Items[i].SubItems[5].Text == "Emprestimo")
                    {
                        var max = listaDeLivros.Items.Cast<ListViewItem>().Max(x => int.Parse(x.SubItems[4].Text));
                        if (listaDeLivros.Items[i].SubItems[4].Text == max.ToString())
                        {
                            string maisEmprestado = listaDeLivros.Items[i].SubItems[0].Text;
                            lbMaisEmprestado.Text = string.Format("Livro mais Emprestado: {0}", maisEmprestado);
                        }
                    }
                }
                ////////////////////////////////////////////////////////////////////////////////////
                for (int i = 0; i < listaDeLivros.Items.Count; i++)
                {
                    if (listaDeLivros.Items[i].SubItems[5].Text == "Emprestimo")
                    {
                        var min = listaDeLivros.Items.Cast<ListViewItem>().Min(x => int.Parse(x.SubItems[4].Text));
                        if (listaDeLivros.Items[i].SubItems[4].Text == min.ToString())
                        {
                            string menosEmprestado = listaDeLivros.Items[i].SubItems[0].Text;
                            lbMenosEmprestado.Text = string.Format("Livro menos Emprestado: {0}", menosEmprestado);
                        }
                    }
                }
                txtNomeLivro.Text = "";
                txtAutor.Text = "";
                txtLancamento.Text = "";
                txtEditora.Text = "";
                txtUnidades.Text = "";
                cbTipo.Text = "";
                txtPreco.Text = "";
                lbRegistros.Text = string.Format("Total de Registros: {0}", listaDeLivros.Items.Count);
            }
        }
         
        private void txtDataCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaDeClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.Text == "Emprestimo")
            {
                cbEmprestimoPara.Enabled = true;
            }
            else
            {
                cbEmprestimoPara.Enabled = false;
            }
        }

        private void lbRegistros_Click(object sender, EventArgs e)
        {

        }
    }
}
