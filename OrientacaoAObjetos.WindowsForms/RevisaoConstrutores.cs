using OrientacaoAObjetos.Dia3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrientacaoAObjetos.WindowsForms
{
    public partial class RevisaoConstrutores : Form
    {
        public RevisaoConstrutores()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.CPF = txtCpf.Text;

            MessageBox.Show(cliente.Nome);
            MessageBox.Show(cliente.CPF);

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
