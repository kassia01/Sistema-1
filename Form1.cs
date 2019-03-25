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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormClientes fClientes = new FormClientes();
            fClientes.ShowDialog();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionario fFuncionario = new FormFuncionario();
            fFuncionario.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
