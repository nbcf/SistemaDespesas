using Controller;
using Entidades;
using SistemaDespesas.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDespesas.Import
{
    public partial class ImportarContaView : Form
    {

        ContaController contaController= new ContaController();
        public ImportarContaView()
        {
            InitializeComponent();
            txtIdconta.Visible = false;
        }

        public void CarregarComboBoxConta() {

            //try
            //{
            //    var lista = contaController.Listar();
            //    var listaD = new Dictionary<int, string>();
            //    listaD.Add(0, "Selecione um Dentista");
            //    foreach (var item in lista)
            //    {
            //        listaD.Add(item.Id, item.NumeroConta);
            //    }
            //    cbConta.DataSource = new BindingSource(listaD, null);
            //    cbConta.DisplayMember = "value";
            //    cbConta.ValueMember = "key";
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Erro ao carregar a lista!" + ex.Message);
            //}



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ImportarContaView_Load(object sender, EventArgs e)
        {

        }
    }
}
