using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema1
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

       
        public void SalvarFuncionario(string nome, string estadoCivil)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema1\\funcionarios.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine();
            arquivo.WriteLine("Cadastro de Funcionário");
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("Estado civil: " + estadoCivil);
            arquivo.WriteLine("_____________________________________");
            arquivo.WriteLine();
            arquivo.Close();
            MessageBox.Show("Cliente salvo com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimparFuncionario()
        {
            txtNome.Clear();
            rbCasado.Checked = false;
            rbSolteiro.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome, estadoCivil;
            nome = txtNome.Text;
            if (rbCasado.Checked == true)
            {
                estadoCivil = "Casado(a)";
            }
            else if (rbSolteiro.Checked == true)
            {
                estadoCivil = "Solteiro(a)";
            }
            else
            {
                MessageBox.Show("Escolha um estado civil");
                return;
            }
            SalvarFuncionario(nome, estadoCivil);
            LimparFuncionario();
        }
    }
}
