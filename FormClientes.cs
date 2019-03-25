using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema1
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void SalvarCliente(string nome, string telefone, string cidade)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema1\\funcionarios.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine();
            arquivo.WriteLine("Cadastro de Cliente");
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("Telefone: " + telefone);
            arquivo.WriteLine("Cidade: " + cidade);
            arquivo.WriteLine("_____________________________________");
            arquivo.WriteLine();
            arquivo.Close();
            MessageBox.Show("Cliente salvo com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome, cidade, telefone;
            nome = txtNome.Text;
            cidade = cmbCidade.Items[cmbCidade.SelectedIndex].ToString();
            telefone = maskTelefone.Text;
            SalvarCliente(nome, telefone, cidade);
            LimparCliente();
        }

        private void LimparCliente()
        {
            txtNome.Clear();
            maskTelefone.Clear();
            cmbCidade.SelectedIndex = -1;
        }

        private class StreamWriter
        {
            internal void Close()
            {
                throw new NotImplementedException();
            }

            internal void WriteLine()
            {
                throw new NotImplementedException();
            }

            internal void WriteLine(string v)
            {
                throw new NotImplementedException();
            }
        }
    }
}
