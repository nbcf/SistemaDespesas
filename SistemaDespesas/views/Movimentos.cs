using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDespesas.views
{
    public partial class Movimentos : Form
    {
        private static Movimentos _InstanciaMovimentos;
        public static Movimentos GetInstanciaMovimentos()
        {
            if (_InstanciaMovimentos == null)
            {
                _InstanciaMovimentos = new Movimentos();
            }
            else if (_InstanciaMovimentos != null)
            {

                MessageBox.Show("O Gerênciador de Constas já se encontra aberto!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return _InstanciaMovimentos;

        }
        public Movimentos()
        {
            InitializeComponent();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
