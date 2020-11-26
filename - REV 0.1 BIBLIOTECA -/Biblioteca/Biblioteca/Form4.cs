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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (sender == btnSalvar)
            {
                var validateError = string.Empty;
                if (txtNome.Text.Length == 0)
                    validateError = "- O cadastro precisa de um nome.";
                if (txtTelefone.Text.Length == 0)
                    validateError += "- O cadastro precisa de um telefone.";
                if (txtDataNascimento.Text.Length == 0)
                    validateError += "- O cadastro precisa de uma data de nascimento.";
                if (txtCPF.Text.Length <= 5)
                    validateError += "- O cadastro precisa de um CPF.";
                if (txtEndereco.Text.Length <= 5)
                    validateError += "- O cadastro precisa de um endereço.";
                if (txtDataCadastro.Text.Length <= 5)
                    validateError += "- O cadastro precisa de uma data de nascimento.";
                if (validateError != string.Empty)
                {
                    MessageBox.Show(validateError.Replace('.', '\n'), @"O cadastro está incompleto", MessageBoxButtons.OK);
                    return;
                }
                ListViewItem varItem = new ListViewItem(new string[] { txtNome.Text,
                                                                txtTelefone.Text,
                                                                txtDataNascimento.Text,
                                                                txtCPF.Text,
                                                                txtEndereco.Text,
                                                                txtDataCadastro.Text
                                                               });
                listaDeClientes.Items.Add(varItem);
                listaDeClientes.Items[listaDeClientes.Items.Count - 1].EnsureVisible(); //for autoscroll
                lbRegistros.Text = string.Format("Total de Registros: {0}", listaDeClientes.Items.Count);
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtDataNascimento.Text = "";
                txtCPF.Text = "";
                txtEndereco.Text = "";
                txtDataCadastro.Text = "";
            }
        }

        private void listaDeClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(this);
            frm5.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listaDeClientes.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selecione uma registro.");
            }
            else
            {
                string TEXT_Confirmacao = "Você realmente deseja excluir este cadastro?";
                if (MessageBox.Show(string.Format("Deseja remover o(s) {0} cadastro selecionadas?", listaDeClientes.SelectedIndices.Count), TEXT_Confirmacao, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                MessageBox.Show("Registro(s) selecionado(s) apagado(s)!");
                for (int i = listaDeClientes.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem li = listaDeClientes.SelectedItems[i];
                    listaDeClientes.Items.Remove(li);
                    listaDeClientes.Text = string.Format("Total de Receitas: {0}", listaDeClientes.Items.Count);
                    lbRegistros.Text = string.Format("Total de Registros: {0}", listaDeClientes.Items.Count);
                }
            }
        }
    }
}
