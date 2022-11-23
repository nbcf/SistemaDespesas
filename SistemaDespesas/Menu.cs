using SistemaDespesas.views;

namespace SistemaDespesas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContasView viewContas = ContasView.GetInstanciaContasView();
            viewContas.MdiParent = this;
            viewContas.Text = "Gerenciamento Contas";
            viewContas.Show();
        }

       
    }
}