using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
namespace SistemaDespesas.views
{
    public partial class ContasView : Form
    {
        public bool finalPaginaBol = false;
        public bool inicioPaginaBol = true;
        public bool estadoBotaoDesbloqueio = false;
        public bool edicaoDaPesquisa = false;
        public bool estadoBotaoDesbloqueioPesquisa = false;
        public bool edicaoDaPesquisaPesquisa = false;
        public bool finalPaginaBolPesquisa = false;
        public bool inicioPaginaBolPesquisa = true;
        public bool actBehaviorSerarch = false;
        public string strNome;
        public string strBanco;
        public string strNumeroConta;
        public string strDigi;
        public string strAgencia;
        public string strSaldo;

        public string porteiro = "fechado";
        public string switchSalvarFlag = "vazio";
        public string name = "";
        public string gender = "";
        public string programmingLanguage = "";
        public string Subject = "";
        public string excelImagePath = "";
        public string operationType = "newInsertion";
        public string typeEdition = "insert";
        public string pegaDirPadrao;
        public string parametroCodigoAlfabeto = "null";
        public string parametroASCDESC = "null";
        public string stringPapel;
        public int paginaAtual = 0;
        public int paginar = 0;
        public int paginarListagemGrid = 0;
        public int deslocado = 0;
        public int ultimaPagina = 0;
        public int deslocamento1;
        public int fimDePagina = 0;
        public int resultado = 0;
        public int totalPaginas = 0;
        public int memoria = 1;
        public int countBttnToggle = 1;
        public int offsettPag = 0;
        public int countBttnToggleTools = 1;
        public int paginaAtualPesquisa = 0;
        public int paginarPesquisa = 0;
        public int deslocadoPesquisa = 0;
        public int ultimaPaginaPesquisa = 0;
        public int posicaoTamanhoFontePesquisa = 1;
        public int getOffSettPesquisa;
        public int fimDePaginaPesquisa = 0;
        public int resultadoPesquisa = 0;
        public int totalPaginasPesquisa = 0;
        public int memoriaPesquisa = 1;

        public string strIDImport;
        public string strNomeImport;
        public string strBancoImport;
        public string strNumeroContaImport;
        public string strDigiImport;
        public string strAgenciaImport;
        public double strSaldoImport;
        public string strModo = "Gerenciador";

        public string modoVO
        {
            get { return strModo; }
            set { strModo = value; }
        }

        public string IdVO
        {
            get { return strIDImport; }
            set { strIDImport = value; }
        }
        public string NomeVO
        {
            get { return strNomeImport; }
            set { strNomeImport = value; }
        }
        public string BancoVO
        {
            get { return strBancoImport; }
            set { strBancoImport = value; }
        }
        public string AgenciaVO
        {
            get { return strAgenciaImport; }
            set { strAgenciaImport = value; }
        }
        public string NumeroContaVO
        {
            get { return strNumeroContaImport; }
            set { strNumeroContaImport = value; }
        }
        public string DigitoVO
        {
            get { return strDigiImport; }
            set { strDigiImport = value; }
        }

        public double SaldoVO
        {
            get { return strSaldoImport; }
            set { strSaldoImport = value; }
        }


        ContaController contaController = new ContaController();

        private static ContasView _InstanciaContasView;

        public static ContasView GetInstanciaContasView()
        {
            if (_InstanciaContasView == null)
            {
                _InstanciaContasView = new ContasView();
            }
            else if (_InstanciaContasView != null)
            {

                MessageBox.Show("O Gerênciador de Constas já se encontra aberto!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return _InstanciaContasView;

        }
        public ContasView()
        {
            InitializeComponent();
            carregarEstadoPadrao("CarregaPadraoIDTodosUltimos", 0);
        }

   
        private void ContasView_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void ContasView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _InstanciaContasView = null;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            countBttnToggle++;
            if (countBttnToggle % 2 == 0)
            {
                cbButtonPesquisarEm.SelectedIndex = 0;
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                bttnEdit.Enabled = false;
                bttnNew.Enabled = false;
                bttnRefresh.Enabled = false;
                actBehaviorSerarch = true;
                cbButtonPesquisarEm.SelectedIndex = 0;
                radioBttnComeca.Checked = true;
                txtBoxPesquisar.Text = "";
                bttnBeginPages.Visible = false;
                bttnOnePageLeft.Visible = false;
                labelTextPageFrom.Visible = false;
                lbseparador.Visible = false;
                labelTextTotalPages.Visible = false;
                lbseparadortraco.Visible = false;
                labelTextTotalRegFould.Visible = false;
                bttnOnePageRight.Visible = false;
                bttnEndPages.Visible = false;
                lbtitulototalencontrados.Visible = true;
                lbTotalEncontrados.Visible = true;
                txtBoxPesquisar.Text = "";
                txtBoxPesquisar.Focus();
          //     txtBoxPesquisar.Text = "";
                txtBoxPesquisar.Focus();
                radioBttnComeca.Checked = true;
                gridCrudContas.DataSource = contaController.PesquisarComecaCom("nome", "@nome", "");
                DataGridModel();
                typeEdition = "search";
                cbButtnQuantPage.Visible = false;
                cbOrdemParam.Visible = false;
                cbOrdenarPor.Visible = false;
                lblistarpor.Visible = false;
                lbordem.Visible = false;
                lbquantpg.Visible = false;
              //  groupBoxFormulario.Enabled = false;
              //  groupBoxFormulario.Visible = false;
            }
            else
            {
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                bttnEdit.Enabled = false;
                bttnNew.Enabled = true;
                bttnRefresh.Enabled = true;
                actBehaviorSerarch = false;
                bttnBeginPages.Visible = true;
                bttnOnePageLeft.Visible = true;
                labelTextPageFrom.Visible = true;
                lbseparador.Visible = true;
                labelTextTotalPages.Visible = true;
                lbseparadortraco.Visible = true;
                labelTextTotalRegFould.Visible = true;
                bttnOnePageRight.Visible = true;
                bttnEndPages.Visible = true;
                lbtitulototalencontrados.Visible = false;
                lbTotalEncontrados.Visible = false;
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
                txtBoxId.Text = "";
                typeEdition = "insert";
                cbButtnQuantPage.Visible = true;
                cbOrdemParam.Visible = true;
                cbOrdenarPor.Visible = true;
                lblistarpor.Visible = true;
                lbordem.Visible = true;
                lbquantpg.Visible = true;

            }

        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            behaviorNewInsert();
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            behaviorRefresh();
        }
        public void carregarEstadoPadrao(string pesquisa, int offsett)
        {
            cbButtnQuantPage.SelectedIndex = 0;
            int quantRegPage = Convert.ToInt32(cbButtnQuantPage.SelectedItem);
            cbOrdenarPor.SelectedIndex = 1;
            cbOrdemParam.SelectedIndex = 0;
            resetarPonteiros();
           this.puxarparametro(0, quantRegPage, "Nao");
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            gridCrudContas.Visible = true;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = false;
            groupBoxFormulario.Visible = false;
            bttnBeginPages.Visible = true;
            bttnOnePageLeft.Visible = true;
            labelTextPageFrom.Visible = true;
            lbseparador.Visible = true;
            labelTextTotalPages.Visible = true;
            lbseparadortraco.Visible = true;
            labelTextTotalRegFould.Visible = true;
            bttnOnePageRight.Visible = true;
            bttnEndPages.Visible = true;
            lbtitulototalencontrados.Visible = false;
            lbTotalEncontrados.Visible = false;
            clearFieldsFormulario();
            disableFieldsFormulario();

        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            behaviorSave();
        }

        private void behaviorNewInsert()
        {
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = false;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = true;
            bttnNew.Enabled = false;
            bttnBeginPages.Visible = false;
            bttnOnePageLeft.Visible = false;
            labelTextPageFrom.Visible = false;
            lbseparador.Visible = false;
            labelTextTotalPages.Visible = false;
            lbseparadortraco.Visible = false;
            labelTextTotalRegFould.Visible = false;
            bttnOnePageRight.Visible = false;
            bttnEndPages.Visible = false;
            lbTotalEncontrados.Visible = false;
            lbquantpg.Visible = false;
            cbButtnQuantPage.Visible = false;
            lblistarpor.Visible = false;
            cbOrdemParam.Visible = false;
            lbordem.Visible = false;
            toolStrip2.Visible = false;
            gridCrudContas.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
          //  clearFieldsFormulario();
          //  enableFieldsFormulario();
            operationType = "newInsertion";
            txtBoxId.Enabled = false;
        }
        private void behaviorRefresh()
        {
            if (operationType == "updateData" && typeEdition == "search")
            {
                gridCrudContas.Visible = true;
                tabControlAssets.Visible = true;
                tabControlAssets.TabPages.Insert(0, tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                bttnEdit.Enabled = true;
                bttnSave.Enabled = false;
                bttnSearch.Enabled = true;
                puxarparametroPesquisa();

            }
            else if (operationType == "" ||
                operationType == "newInsertion" ||
                operationType == "updateData" ||
                operationType == "search" &&
                typeEdition == "insert")
            {
                bttnDel.Enabled = false;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;
                radioBttnComeca.Checked = false;
                radioBttnContem.Checked = false;
                radioBttnTermina.Checked = false;
                gridCrudContas.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                clearFieldsFormulario();
                 disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
                  
                gridCrudContas.ClearSelection();
                bttnBeginPages.Visible = true;
                bttnOnePageLeft.Visible = true;
                labelTextPageFrom.Visible = true;
                lbseparador.Visible = true;
                labelTextTotalPages.Visible = true;
                lbseparadortraco.Visible = true;
                labelTextTotalRegFould.Visible = true;
                bttnOnePageRight.Visible = true;
                bttnEndPages.Visible = true;
                lbTotalEncontrados.Visible = false;
                lbquantpg.Visible = true;
                cbButtnQuantPage.Visible = true;
                lblistarpor.Visible = true;
                cbOrdemParam.Visible = true;
                lbordem.Visible = true;
                toolStrip2.Visible = true;

            }
            else if (operationType == "" ||
                operationType == "newInsertion" ||
                operationType == "updateData" ||
                operationType == "search" &&
                typeEdition == "search")
            {
                bttnDel.Enabled = false;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;
                radioBttnComeca.Checked = false;
                radioBttnContem.Checked = false;
                radioBttnTermina.Checked = false;
                gridCrudContas.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
               clearFieldsFormulario();
               disableFieldsFormulario();
                 puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
                gridCrudContas.ClearSelection();
                lbTotalEncontrados.Visible = false;
                bttnBeginPages.Visible = true;
                bttnOnePageLeft.Visible = true;
                labelTextPageFrom.Visible = true;
                lbseparador.Visible = true;
                labelTextTotalPages.Visible = true;
                lbseparadortraco.Visible = true;
                labelTextTotalRegFould.Visible = true;
                bttnOnePageRight.Visible = true;
                bttnEndPages.Visible = true;
                lbquantpg.Visible = true;
                cbButtnQuantPage.Visible = true;
                lblistarpor.Visible = true;
                cbOrdemParam.Visible = true;
                lbordem.Visible = true;
                toolStrip2.Visible = true;
            }
        }

        private void DataGridModel()
        {
            gridCrudContas.Columns[0].HeaderText = "ID";
            gridCrudContas.Columns[1].HeaderText = "NOME";
            gridCrudContas.Columns[2].HeaderText = "BANCO";
            gridCrudContas.Columns[3].HeaderText = "AGÊNCIA";
            gridCrudContas.Columns[4].HeaderText = "N°. CONTA";
            gridCrudContas.Columns[5].HeaderText = "DIGITO";
            gridCrudContas.Columns[6].HeaderText = "SALDO";
            gridCrudContas.Columns[7].HeaderText = "DESDE";
            gridCrudContas.Columns[8].HeaderText = "DESCRIÇÃO";

            gridCrudContas.Columns[0].Width = 60;
            gridCrudContas.Columns[1].Width = 150;
            gridCrudContas.Columns[2].Width = 180;
            gridCrudContas.Columns[3].Width = 100;
            gridCrudContas.Columns[4].Width = 110;
            gridCrudContas.Columns[5].Width = 100;
            gridCrudContas.Columns[6].Width = 100;
            gridCrudContas.Columns[7].Width = 100;
            gridCrudContas.Columns[8].Width = 200;
            gridCrudContas.Columns[8].DisplayIndex = 1;
            gridCrudContas.Columns[1].DisplayIndex = 2;
            gridCrudContas.Columns[2].DisplayIndex = 3;
            gridCrudContas.Columns[3].DisplayIndex = 4;
            gridCrudContas.Columns[4].DisplayIndex = 5;
            gridCrudContas.Columns[5].DisplayIndex = 6;
            gridCrudContas.Columns[6].DisplayIndex = 7;
            gridCrudContas.Columns[7].DisplayIndex = 8;
        }

        private void acoesBehaviorSave()
        {

            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            gridCrudContas.Visible = true;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            tabControlAssets.Visible = false;
         
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = false;
            groupBoxFormulario.Visible = false;
            clearFieldsFormulario();
            disableFieldsFormulario();
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
        }

        private void behaviorEdit()
        {

            typeEdition = "insert";
            operationType = "updateData";
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = false;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = true;
            bttnNew.Enabled = false;
            gridCrudContas.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Enabled = false;
            setaGridEmCampos();
        }

        private void behaviorEditPesquisa()
        {
            typeEdition = "search";
            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = false;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = true;
            bttnNew.Enabled = false;
            gridCrudContas.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Enabled = false;
            setaGridEmCampos();
        }



        private void behaviorClickGrid()
        {

            if (operationType == "updateData" && typeEdition == "search")
            {
                bttnNew.Enabled = false;
                bttnDel.Enabled = true;
                bttnEdit.Enabled = true;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;

                radioBttnComeca.Checked = true;
                enableFieldsFormulario();
                clearFieldsFormulario();
                setaGridEmCampos();

            }
            else if (operationType == "" ||
                operationType == "newInsertion" ||
                operationType == "updateData" ||
                operationType == "search" &&
                typeEdition == "insert")
            {
                bttnNew.Enabled = false;
                bttnDel.Enabled = true;
                bttnEdit.Enabled = true;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;

                radioBttnComeca.Checked = false;
                radioBttnContem.Checked = false;
                radioBttnTermina.Checked = false;
                enableFieldsFormulario();
                clearFieldsFormulario();
                setaGridEmCampos();

            }
            else if (operationType == "" ||
                operationType == "newInsertion" ||
                operationType == "updateData" ||
                operationType == "search" &&
                typeEdition == "search")
            {
                bttnNew.Enabled = false;
                bttnDel.Enabled = true;
                bttnEdit.Enabled = true;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;

                radioBttnComeca.Checked = false;
                radioBttnContem.Checked = false;
                radioBttnTermina.Checked = false;
                enableFieldsFormulario();
                clearFieldsFormulario();
                setaGridEmCampos();
            }
        }

        private void setaGridEmCampos()
        {
            txtBoxId.Text = gridCrudContas.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = gridCrudContas.CurrentRow.Cells[1].Value.ToString();
            cbBanco.SelectedItem = gridCrudContas.CurrentRow.Cells[2].Value.ToString();
            txtAgencia.Text = gridCrudContas.CurrentRow.Cells[3].Value.ToString();
            txtNumero.Text = gridCrudContas.CurrentRow.Cells[4].Value.ToString();
            txtDigito.Text = gridCrudContas.CurrentRow.Cells[5].Value.ToString();
            txtSaldo.Text = gridCrudContas.CurrentRow.Cells[6].Value.ToString();
            dtDeste.Value = Convert.ToDateTime(gridCrudContas.CurrentRow.Cells[7].Value.ToString()) ;
            txtDescricao.Text = gridCrudContas.CurrentRow.Cells[8].Value.ToString();
         //  
            //txtUf.Text = gridCrudContas.CurrentRow.Cells[8].Value.ToString();
            //txtCep.Text = gridCrudContas.CurrentRow.Cells[9].Value.ToString();
        }

        private void behaviorClickGridPesquisa()
        {
            bttnNew.Enabled = false;
            bttnDel.Enabled = true;
            bttnEdit.Enabled = true;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = false;
            bttnSave.Enabled = false;
            enableFieldsFormulario();
            clearFieldsFormulario();
            setaGridEmCampos();
        }


        private void bttnEdit_Click(object sender, EventArgs e)
        {
            var gridVazia = gridCrudContas.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia))
            {
            }


            else if (gridVazia.Length > 0)
            {
                if (typeEdition.Equals("insert") && operationType.Equals("newInsertion"))
                {
                    behaviorEdit();
                }
                else if (typeEdition.Equals("search") && operationType.Equals("updateData"))
                {

                    behaviorEditPesquisa();
                }


            }
        }

        private void bttnDel_Click(object sender, EventArgs e)
        {
            behaviorDel();
        }

        private void gridCrudContas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridVazia = gridCrudContas.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia))
            {

            }
            else if (gridVazia.Length > 0)
            {
                if (typeEdition.Equals("insert"))
                {
                    operationType = "newInsertion";
                    behaviorClickGrid();
                }
                else if (typeEdition.Equals("search"))
                {
                    operationType = "updateData";
                    behaviorClickGridPesquisa();

                }

            }
        }

        public void clearFieldsFormulario()
        {
            txtBoxId.Text = "";
            txtNome.Text = "";
            txtNumero.Text = "";
            txtDigito.Text = "";
            txtAgencia.Text = "";
            txtSaldo.Text = "";
            txtDescricao.Text = "";
            dtDeste.Value = DateTime.Now;
       
        }

        private void behaviorDel()
        {
            if (operationType == "updateData" && typeEdition == "search")
            {
                contaController.Deletar(Convert.ToInt32(gridCrudContas.CurrentRow.Cells[0].Value));

                puxarparametroPesquisa();
                radioBttnComeca.Checked = true;
                bttnDel.Enabled = true;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;


                int tamanho_lista = gridCrudContas.RowCount;
                MessageBox.Show(tamanho_lista.ToString());
                if (tamanho_lista == 0)
                {
                    bttnDel.Enabled = false;
                    bttnEdit.Enabled = false;
                    bttnRefresh.Enabled = false;
                    bttnSearch.Enabled = true;
                }

            }
            else if (operationType == "" ||
                operationType == "newInsertion" ||
                operationType == "updateData" ||
                operationType == "search" &&
                typeEdition == "insert")
            {
                bttnDel.Enabled = true;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;

             contaController.Deletar(Convert.ToInt32(gridCrudContas.CurrentRow.Cells[0].Value));
                if ("DEL".Equals(contaController.AcaoCrudContaController()))
                {
                    MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
                    behaviorRefresh();

                }
                else if ("NDEL".Equals(contaController.AcaoCrudContaController()))
                {
                    MessageBox.Show("Exclusão Cancelada", "Registro Não Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
                    behaviorRefresh();
                }

            }
            else if (operationType == "" ||
              operationType == "newInsertion" ||
              operationType == "updateData" ||
              operationType == "search" &&
              typeEdition == "search")
            {
                bttnDel.Enabled = true;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;
              contaController.Deletar(Convert.ToInt32(gridCrudContas.CurrentRow.Cells[0].Value));
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");

            }
        }


        private void behaviorSave()
        {
            string retiraEspacos = txtNome.Text;
            string rem = retiraEspacos.Trim();
            if (txtBoxId.Text.Trim().Equals("") || txtBoxId.Text.Trim() == null)
            {
                if (operationType.Equals("newInsertion") && typeEdition.Equals("insert"))
                {
                    if (rem.Length <= 3)
                    {
                        var resultado = MessageBox.Show("A Inserção não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            txtNome.Text = "";
                            txtNome.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (rem.Length >= 3)
                    {
                       
                        contaController.Cadastrar(txtNome.Text,
                            cbBanco.SelectedItem.ToString(),
                            txtAgencia.Text,
                            txtNumero.Text,
                            txtDigito.Text,
                            Convert.ToDouble(txtSaldo.Text),
                           dtDeste.Value,
                            txtDescricao.Text);
                        if ("NS".Equals(contaController.AcaoCrudContaController()))
                        {
                            txtNome.Focus();
                            txtNome.Text = "";

                        }
                        else if ("S!".Equals(contaController.AcaoCrudContaController()))
                        {
                            operationType = "newInsertion";
                            typeEdition = "insert";
                            behaviorRefresh();

                        }
                        else if ("S!!".Equals(contaController.AcaoCrudContaController()))
                        {
                            //bttnNew
                            acoesBehaviorSave();

                        }
                    }
                }
            }
            else if (!txtBoxId.Text.Trim().Equals("") || txtBoxId.Text.Trim() != null)
            {

                if (operationType.Equals("updateData") && typeEdition.Equals("insert"))
                {
                    if (rem.Length <= 3)
                    {

                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {

                            txtNome.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {

                            behaviorRefresh();
                        }

                    }
                    else if (rem.Length >= 3)
                    {
                        contaController.Editar(Convert.ToInt32(txtBoxId.Text.Trim()),
                            txtNome.Text, 
                            cbBanco.SelectedItem.ToString(),
                            txtAgencia.Text, 
                            txtNumero.Text,
                            txtDigito.Text,
                            Convert.ToDouble(txtSaldo.Text),
                            dtDeste.Value,
                            txtDescricao.Text);
                    
                        if ("AT".Equals(contaController.AcaoCrudContaController()))
                        {
                            operationType = "newInsertion";
                            typeEdition = "insert";
                            behaviorRefresh();
                        }
                    }
                }
                else if (operationType.Equals("updateData") && typeEdition.Equals("search"))
                {

                    if (rem.Length <= 3)
                    {
                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            txtNome.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {
                            operationType = "updateData";
                            typeEdition = "search";
                            behaviorRefresh();
                        }

                    }
                    else if (rem.Length >= 3)
                    {
                        
                        contaController.Editar(Convert.ToInt32(txtBoxId.Text.Trim()),
                              txtNome.Text,
                              cbBanco.SelectedItem.ToString(),
                              txtAgencia.Text,
                              txtNumero.Text,
                              txtDigito.Text,
                              Convert.ToDouble(txtSaldo.Text),
                             dtDeste.Value,
                            txtDescricao.Text);
                        if ("AT".Equals(contaController.AcaoCrudContaController()))
                        {
                            behaviorRefresh();
                            puxarparametroPesquisa();

                        }
                    }
                }
            }
        }

     
        private void puxarparametroPesquisa()
        {

            string estadoPesquisa = "";
            string pesquisarEmColuna = Convert.ToString(cbButtonPesquisarEm.SelectedItem);


            if (radioBttnComeca.Checked == true)
            {
                estadoPesquisa = "ComecaCom";
            }
            else if (radioBttnContem.Checked == true)
            {
                estadoPesquisa = "Contem";
            }
            else if (radioBttnTermina.Checked == true)
            {
                estadoPesquisa = "TerminaCom";
            }
            else if (radioBttnComeca.Checked == false)
            {
                estadoPesquisa = "";
            }
            else if (radioBttnContem.Checked == false)
            {
                estadoPesquisa = "";
            }
            else if (radioBttnTermina.Checked == false)
            {
                estadoPesquisa = "";
            }

            if (actBehaviorSerarch == true)
            {


                if (estadoPesquisa.Equals("ComecaCom") && pesquisarEmColuna.Equals("Nome"))
                {
                    gridCrudContas.DataSource = contaController.PesquisarComecaCom("nome", "@nome", txtBoxPesquisar.Text);
                      DataGridModel();
                    lbTotalEncontrados.Text = Convert.ToString(contaController.ListarPesquisados());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Nome"))
                {
                    gridCrudContas.DataSource = contaController.PesquisarContemCom("nome", "@nome", txtBoxPesquisar.Text);
                     DataGridModel();
                    lbTotalEncontrados.Text = Convert.ToString(contaController.ListarPesquisados());
                }
                else
                if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Nome"))
                {
                    gridCrudContas.DataSource = contaController.PesquisarTerminaCom("nome", "@nome", txtBoxPesquisar.Text);
                    DataGridModel();
                    lbTotalEncontrados.Text = Convert.ToString(contaController.ListarPesquisados());
                }
            }
        }

        private void puxarparametro(int deslocamento, int limiteregistro, string inicioDeslocamento)
        {

            string jcbOrdem = Convert.ToString(cbOrdemParam.SelectedItem);
            string ordem = "";
            if (Convert.ToString(cbOrdenarPor.SelectedItem).Equals("Primeiros"))
            {
                ordem = "primeiros";
            }
            else if (Convert.ToString(cbOrdenarPor.SelectedItem).Equals("Ultimos"))
            {
                ordem = "ultimos";
            }

            if (actBehaviorSerarch == false)

                if (jcbOrdem.Equals("Codigo") && ordem.Equals("primeiros"))
                {
                    parametroCodigoAlfabeto = "Codigo";
                    parametroASCDESC = "primeiros";

                    if (cbButtnQuantPage.SelectedText == "Todos") { }
                    else
                    {
                        if (inicioDeslocamento.Equals("Sim"))
                        {
                            resetarPonteiros();
                            this.EnviaModelo("CarregaPadraoIDTodosPrimeiros", deslocamento, limiteregistro);
                        }
                        else if (inicioDeslocamento.Equals("Nao"))
                        {

                            this.EnviaModelo("CarregaPadraoIDTodosPrimeiros", deslocamento, limiteregistro);
                        }
                    }
                }
                else if (jcbOrdem.Equals("Codigo") && ordem.Equals("ultimos"))
                {
                    parametroCodigoAlfabeto = "Codigo";
                    parametroASCDESC = "ultimos";

                    if (cbButtnQuantPage.SelectedText == "Todos")
                    {
                    }
                    else
                    {

                        paginar = Convert.ToInt32(cbButtnQuantPage.SelectedItem);
                        ultimaPagina = paginar;
                        if (inicioDeslocamento.Equals("Sim"))
                        {
                            resetarPonteiros();
                            this.EnviaModelo("CarregaPadraoIDTodosUltimos", deslocamento, limiteregistro);
                        }
                        else if (inicioDeslocamento.Equals("Nao"))
                        {
                            this.EnviaModelo("CarregaPadraoIDTodosUltimos", deslocamento, limiteregistro);
                        }
                    }
                }
                else if (jcbOrdem.Equals("Alfabeto") && ordem.Equals("primeiros"))
                {
                    parametroCodigoAlfabeto = "Alfabeto";
                    parametroASCDESC = "primeiros";

                    if (cbButtnQuantPage.SelectedText == "Todos")
                    {
                    }
                    else
                    {
                        if (inicioDeslocamento.Equals("Sim"))
                        {
                            resetarPonteiros();
                            this.EnviaModelo("CarregaPadraoNomeTodosPrimeiros", deslocamento, limiteregistro);
                        }
                        else if (inicioDeslocamento.Equals("Nao"))
                        {
                            this.EnviaModelo("CarregaPadraoNomeTodosPrimeiros", deslocamento, limiteregistro);
                        }
                    }
                }
                else if (jcbOrdem.Equals("Alfabeto") && ordem.Equals("ultimos"))
                {
                    parametroCodigoAlfabeto = "Alfabeto";
                    parametroASCDESC = "ultimos";
                    if (cbButtnQuantPage.SelectedText == "Todos")
                    {
                    }
                    else
                    {

                        if (inicioDeslocamento.Equals("Sim"))
                        {
                            resetarPonteiros();
                            this.EnviaModelo("CarregaPadraoNomeTodosUltimos", deslocamento, limiteregistro);
                        }
                        else if (inicioDeslocamento.Equals("Nao"))
                        {
                            this.EnviaModelo("CarregaPadraoNomeTodosUltimos", deslocamento, limiteregistro);
                        }
                    }
                }
        }

        public void EnviaModelo(string pesquisa, int offset, int limitt)
        {

            if (pesquisa.Equals("CarregaPadraoIDTodosUltimos") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudContas.DataSource = contaController.ListarPaginada("id", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(contaController.ListarTudoController());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudContas.DataSource = contaController.ListarPaginada("id", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(contaController.ListarTudoController());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudContas.DataSource = contaController.ListarPaginada("nome", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(contaController.ListarTudoController());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudContas.DataSource = contaController.ListarPaginada("nome", "asc", offset, limitt);
                 DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(contaController.ListarTudoController());
                carregarInformacoes();
            }

        }


        public void somar()
        {
            int pagina1 = Convert.ToInt32(labelTextTotalPages.Text);
            int pg = Convert.ToInt32(cbButtnQuantPage.SelectedItem);
            if (memoria < pagina1 && finalPaginaBol == false)
            {
                deslocamento1 = paginaAtual + pg;
                paginarPesquisa = deslocamento1;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                memoria++;
                labelTextPageFrom.Text = memoria.ToString();
                bttnBeginPages.Enabled = true;
                bttnBeginPages.Enabled = true;
                this.puxarparametro(deslocamento1, pg, "Nao");
                if (memoria == pagina1)
                {
                    bttnOnePageRight.Enabled = false;
                    bttnEndPages.Enabled = false;
                    finalPaginaBol = true;
                    inicioPaginaBol = false;
                }
            }
            else if (memoria < pagina1 && finalPaginaBol == true)
            {
                deslocamento1 = paginaAtual + pg;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                memoria++;
                labelTextPageFrom.Text = memoria.ToString();
                bttnBeginPages.Enabled = true;
                bttnBeginPages.Enabled = true;
                this.puxarparametro(deslocamento1, paginar, "Nao");
                if (memoria == pagina1)
                {
                    bttnOnePageRight.Enabled = false;
                    bttnEndPages.Enabled = false;
                    finalPaginaBol = true;
                    inicioPaginaBol = false;
                }
            }
        }

        public void descontar()
        {
            int pagina1 = Convert.ToInt32(labelTextTotalPages.Text);
            int pg = Convert.ToInt32(cbButtnQuantPage.SelectedItem);
            if (memoria > 1 && memoria <= pagina1 && inicioPaginaBol == true)
            {
                deslocamento1 = deslocamento1 - pg;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                --memoria;
                labelTextPageFrom.Text = Convert.ToString(memoria);
                bttnOnePageRight.Enabled = true;
                bttnEndPages.Enabled = true;
                this.puxarparametro(deslocamento1, pg, "Nao");
                if (memoria == 1)
                {
                    bttnOnePageRight.Enabled = true;
                    bttnEndPages.Enabled = true;
                    inicioPaginaBol = true;
                    finalPaginaBol = false;
                    MessageBox.Show("Início da Paginação", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (memoria > 1 && memoria <= pagina1 && inicioPaginaBol == false)
            {
                deslocamento1 = deslocamento1 - pg;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                --memoria;
                labelTextPageFrom.Text = Convert.ToString(memoria);
                this.puxarparametro(deslocamento1, pg, "Nao");
                bttnOnePageRight.Enabled = true;
                bttnEndPages.Enabled = true;
                if (finalPaginaBol == true)
                {
                    bttnOnePageRight.Enabled = true;
                    bttnEndPages.Enabled = true;
                }
                if (memoria == 1)
                {
                    inicioPaginaBol = true;
                    finalPaginaBol = false;
                }
            }
        }


        public void inicioPagina()
        {

            resetarPonteiros();
            this.puxarparametro(deslocamento1, paginar, "Nao");
        }


        public void finalDaPagina()
        {
            int pagina1 = Convert.ToInt32(labelTextTotalPages.Text);
            int ajustaPaginacao = pagina1 - 1;
            int pg = Convert.ToInt32(cbButtnQuantPage.SelectedItem);
            for (int i = memoria; memoria <= ajustaPaginacao; i++)
            {
                deslocamento1 = paginaAtual + pg;
                deslocado = deslocamento1;
                paginaAtual = deslocado;
                memoria++;
                if (memoria == pagina1)
                {
                    bttnOnePageRight.Enabled = false;
                    bttnEndPages.Enabled = false;
                    bttnBeginPages.Enabled = true;
                    bttnBeginPages.Enabled = true;
                    labelTextPageFrom.Text = Convert.ToString(memoria);
                    inicioPaginaBol = false;
                    finalPaginaBol = true;
                    this.puxarparametro(deslocamento1, pg, "Nao");
                }
            }
        }


        public void resetarPonteiros()
        {
            finalPaginaBol = false;
            inicioPaginaBol = true;
            bttnOnePageRight.Enabled = true;
            bttnEndPages.Enabled = true;
            labelTextPageFrom.Text = Convert.ToString(1);
            paginaAtual = 0;
            paginar = Convert.ToInt32(cbButtnQuantPage.SelectedItem);
            deslocado = 0;
            memoria = 1;
            deslocamento1 = 0;
            paginarPesquisa = 0;
            actBehaviorSerarch = false;
        }



        public void carregarInformacoes()
        {
            resultado = 0;
            int quantidadeReg = 0;
            quantidadeReg = Convert.ToInt32(contaController.ListarTudoController());
            int jcbPaginas = Convert.ToInt32(cbButtnQuantPage.SelectedItem);

            resultado = quantidadeReg / jcbPaginas;
            int resto = quantidadeReg % jcbPaginas;
            if (resto >= 1)
            {
                labelTextTotalPages.Text = Convert.ToString(resultado + 1);
            }
            else if (resto == 0)
            {
                labelTextTotalPages.Text = Convert.ToString(resultado);
            }
        }




        public void disableFieldsFormulario() { txtBoxId.Enabled = false;  }
        public void enableFieldsFormulario() { txtBoxId.Enabled = true;  }
        public void clearFieldsPesquisar() { txtBoxPesquisar.Text = ""; cbButtonPesquisarEm.SelectedValue = 0; }
        public void disableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }
        public void enableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }

        private void cbButtnQuantPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
        }

        private void cbOrdemParam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
        }

        private void cbOrdenarPor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
        }

        private void bttnBeginPages_Click(object sender, EventArgs e)
        {
            inicioPagina();
        }

        private void bttnOnePageLeft_Click(object sender, EventArgs e)
        {
            descontar();
        }

        private void bttnOnePageRight_Click(object sender, EventArgs e)
        {
            somar();
        }

        private void bttnEndPages_Click(object sender, EventArgs e)
        {
            finalDaPagina();
        }

        private void cbButtnQuantPage_Click(object sender, EventArgs e)
        {

        }

        private void radioBttnTermina_CheckedChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void cbButtonPesquisarEm_SelectedIndexChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void txtBoxPesquisar_TextChanged(object sender, EventArgs e)
        {
            puxarparametroPesquisa();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            _InstanciaContasView = null;
            Close();
        }

        private void ContasView_Load_1(object sender, EventArgs e)
        {

        }
    }


}
