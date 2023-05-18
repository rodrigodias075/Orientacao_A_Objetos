
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrientacaoAObjetos.Dia2;

namespace OrientacaoAObjetos.WindowsForms
{
    public partial class AulaConstrutores : Form
    {
        public AulaConstrutores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado();
            MessageBox.Show(segurado.Teste());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado("Rodrigo");
            MessageBox.Show(segurado.Nome);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado(1054654656);
            MessageBox.Show(segurado.Id.ToString());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado("Rodrigo", "069554536");
            MessageBox.Show(segurado.Nome);
            MessageBox.Show(segurado.CPF);


        }

        private void btnDia3_Click(object sender, EventArgs e)
        {
            new RevisaoConstrutores().Show();
        }
    }
}
