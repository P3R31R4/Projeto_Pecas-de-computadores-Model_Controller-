using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_Pichau.View
{
    public partial class MenuTela : Form
    {
        public MenuTela()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroPecas telaCadastrar = new TelaCadastroPecas();
            telaCadastrar.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPecas telaBuscar= new BuscarPecas();
            telaBuscar.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarPecas telaAlterar = new AlterarPecas();  
            telaAlterar.Show();
        }

        private void deletraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletarPecas telaDeletar = new DeletarPecas();
            telaDeletar.Show();
        }
    }
}
