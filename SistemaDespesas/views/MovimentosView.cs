using Controller;
using EFController.Repositories;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaDespesas.views
{
    public partial class MovimentosView : Form
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

        public static Movimento moviModel;
        public static Movimento MoimentoVO
        {
            get { return moviModel; }
            set { moviModel = value; }
        }
 
        ContaController contaController = new ContaController();
        MovimentoController movimentoController = new MovimentoController();
  
        private static MovimentosView _InstanciaMovimentos;

        public static MovimentosView GetInstanciaMovimentos()
        {
            if (_InstanciaMovimentos == null)
            {
                _InstanciaMovimentos = new MovimentosView();
            }
            else if (_InstanciaMovimentos != null)
            {

                MessageBox.Show("O Gerênciador de Movimentos já se encontra aberto!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return _InstanciaMovimentos;

        }


        public MovimentosView()
        {
            InitializeComponent();
            carregarEstadoPadrao("CarregaPadraoIDTodosUltimos", 0);
            
        }

        private void bttnNew_Click(object sender, EventArgs e)
        {
            behaviorNewInsert();
        }


        public void CarregarComboBoxConta() {
            try{

                cbConta.DataSource = contaController.Listar();
                cbConta.ValueMember = "Id";
                cbConta.DisplayMember = "NumeroConta";


            }
            catch (Exception ex){

                MessageBox.Show("Erro ao carregar a lista!" + ex.Message);
            }

        }

        private void cbConta_SelectedIndexChanged(object sender, EventArgs e)
        {

            //DataRowView dataRowView = (DataRowView)cbConta.SelectedItem;
            //   txtAgencia.Text =  Convert.ToString(dataRowView.Row.ItemArray[2]);

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
            gridCrudMovimentos.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            clearFieldsFormulario();
            enableFieldsFormulario();
            operationType = "newInsertion";
            txtIdconta.Enabled = false;
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
            gridCrudMovimentos.Visible = true;
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
            txtIdconta.Visible = false;
            label1.Visible = false;


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
            //txtBoxId.Text = gridCrudMovimentos.CurrentRow.Cells[0].Value.ToString();
            //txtNome.Text = gridCrudMovimentos.CurrentRow.Cells[1].Value.ToString();
            //cbBanco.SelectedItem = gridCrudMovimentos.CurrentRow.Cells[2].Value.ToString();
            //txtAgencia.Text = gridCrudMovimentos.CurrentRow.Cells[3].Value.ToString();
            //txtNumero.Text = gridCrudMovimentos.CurrentRow.Cells[4].Value.ToString();
            //txtDigito.Text = gridCrudMovimentos.CurrentRow.Cells[5].Value.ToString();
            //txtSaldo.Text = gridCrudMovimentos.CurrentRow.Cells[6].Value.ToString();
            //dtDeste.Value = Convert.ToDateTime(gridCrudMovimentos.CurrentRow.Cells[7].Value.ToString());
            //txtDescricao.Text = gridCrudMovimentos.CurrentRow.Cells[8].Value.ToString();

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
            var gridVazia = gridCrudMovimentos.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(gridVazia) || gridVazia.Length == 0)
            {
            }
            else if (gridVazia.Length > 0)
            {
                if (typeEdition.Equals("insert") && operationType.Equals("newInsertion"))
                {
                    operationType = "newInsertion";
                    behaviorEdit();
                }
                else if (typeEdition.Equals("search") && operationType.Equals("updateData"))
                {
                    operationType = "updateData";
                    behaviorEditPesquisa();
                }


            }
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
            gridCrudMovimentos.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Enabled = false;
            setaGridEmCampos();
            toolStrip2.Visible = false;
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
            gridCrudMovimentos.Visible = false;
            tabControlAssets.Visible = false;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = true;
            groupBoxFormulario.Visible = true;
            enableFieldsFormulario();
            clearFieldsFormulario();
            txtBoxId.Enabled = false;
            setaGridEmCampos();
        }

        private void bttnDel_Click(object sender, EventArgs e)
        {
            behaviorDel();
        }

        private void gridCrudMovimentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int tamanhoLista = gridCrudMovimentos.RowCount;
            if (tamanhoLista > 0)
            {
                var gridVazia = gridCrudMovimentos.CurrentRow.Cells[0].Value.ToString();
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

            else { }
        }

        public void clearFieldsFormulario()
        {
            //txtBoxId.Text = "";
            //txtNome.Text = "";
            //txtNumero.Text = "";
            //txtDigito.Text = "";
            //txtAgencia.Text = "";
            //txtSaldo.Text = "";
            //txtDescricao.Text = "";
            //dtDeste.Value = DateTime.Now;

        }

        private void behaviorDel()
        {
            if (operationType == "updateData" && typeEdition == "search")
            {
                movimentoController.Deletar(Convert.ToInt32(gridCrudMovimentos.CurrentRow.Cells[0].Value));

                puxarparametroPesquisa();
                radioBttnComeca.Checked = true;
                bttnDel.Enabled = true;
                bttnEdit.Enabled = false;
                bttnSearch.Enabled = true;
                bttnRefresh.Enabled = true;
                bttnSave.Enabled = false;
                bttnNew.Enabled = true;


                int tamanho_lista = gridCrudMovimentos.RowCount;
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

                movimentoController.Deletar(Convert.ToInt32(gridCrudMovimentos.CurrentRow.Cells[0].Value));
                if ("DEL".Equals(movimentoController.AcaoCrudMovimentoController()))
                {
                    MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
                    behaviorRefresh();

                }
                else if ("NDEL".Equals(movimentoController.AcaoCrudMovimentoController()))
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
                movimentoController.Deletar(Convert.ToInt32(gridCrudMovimentos.CurrentRow.Cells[0].Value));
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");

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
                    gridCrudMovimentos.DataSource = movimentoController.PesquisarComecaCom("nome", "@nome", txtBoxPesquisar.Text);
                    DataGridModel();
                    lbTotalEncontrados.Text = Convert.ToString(movimentoController.ListarPesquisados());
                }
                else if (estadoPesquisa.Equals("Contem") && pesquisarEmColuna.Equals("Nome"))
                {
                    gridCrudMovimentos.DataSource = movimentoController.PesquisarContemCom("nome", "@nome", txtBoxPesquisar.Text);
                    DataGridModel();
                    lbTotalEncontrados.Text = Convert.ToString(movimentoController.ListarPesquisados());
                }
                else
                if (estadoPesquisa.Equals("TerminaCom") && pesquisarEmColuna.Equals("Nome"))
                {
                    gridCrudMovimentos.DataSource = movimentoController.PesquisarTerminaCom("nome", "@nome", txtBoxPesquisar.Text);
                    DataGridModel();
                    lbTotalEncontrados.Text = Convert.ToString(movimentoController.ListarPesquisados());
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
                gridCrudMovimentos.DataSource = movimentoController.ListarPaginada("id", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(movimentoController.ListarTudoController());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoIDTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Codigo") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudMovimentos.DataSource = movimentoController.ListarPaginada("id", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(movimentoController.ListarTudoController());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosUltimos") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("ultimos"))
            {
                gridCrudMovimentos.DataSource = movimentoController.ListarPaginada("nome", "desc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(movimentoController.ListarTudoController());
                carregarInformacoes();
            }
            else if (pesquisa.Equals("CarregaPadraoNomeTodosPrimeiros") && parametroCodigoAlfabeto.Equals("Alfabeto") && parametroASCDESC.Equals("primeiros"))
            {
                gridCrudMovimentos.DataSource = movimentoController.ListarPaginada("nome", "asc", offset, limitt);
                DataGridModel();
                labelTextTotalRegFould.Text = Convert.ToString(movimentoController.ListarTudoController());
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
            quantidadeReg = Convert.ToInt32(movimentoController.ListarTudoController());
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

        private void behaviorRefresh()
        {
            if (operationType == "updateData" && typeEdition == "search")
            {
                gridCrudMovimentos.Visible = true;
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
                gridCrudMovimentos.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
                gridCrudMovimentos.ClearSelection();
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
                gridCrudMovimentos.Visible = true;
                tabControlAssets.Visible = false;
                tabControlAssets.TabPages.Remove(tabPagePesquisar);
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
                clearFieldsFormulario();
                disableFieldsFormulario();
                puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
                gridCrudMovimentos.ClearSelection();
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

        public void disableFieldsFormulario() { txtBoxId.Enabled = false; }
        public void enableFieldsFormulario() { txtBoxId.Enabled = true; }
        public void clearFieldsPesquisar() { txtBoxPesquisar.Text = ""; cbButtonPesquisarEm.SelectedValue = 0; }
        public void disableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }
        public void enableFieldsPesquisar() { txtBoxPesquisar.Enabled = true; }


        private void acoesBehaviorSave()
        {

            bttnDel.Enabled = false;
            bttnEdit.Enabled = false;
            bttnSearch.Enabled = true;
            bttnRefresh.Enabled = true;
            bttnSave.Enabled = false;
            bttnNew.Enabled = true;
            gridCrudMovimentos.Visible = true;
            radioBttnComeca.Checked = false;
            radioBttnContem.Checked = false;
            radioBttnTermina.Checked = false;
            tabControlAssets.Visible = false;
            gridCrudMovimentos.Visible = true;
            tabControlAssets.TabPages.Remove(tabPagePesquisar);
            groupBoxFormulario.Enabled = false;
            groupBoxFormulario.Visible = false;
            clearFieldsFormulario();
            disableFieldsFormulario();
            puxarparametro(0, Convert.ToInt32(cbButtnQuantPage.SelectedItem), "Sim");
        }

        private void DataGridModel()
        {
            //gridCrudContas.Columns[0].HeaderText = "ID";
            //gridCrudContas.Columns[1].HeaderText = "NOME";
            //gridCrudContas.Columns[2].HeaderText = "BANCO";
            //gridCrudContas.Columns[3].HeaderText = "AGÊNCIA";
            //gridCrudContas.Columns[4].HeaderText = "N°. CONTA";
            //gridCrudContas.Columns[5].HeaderText = "DIGITO";
            //gridCrudContas.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //gridCrudContas.Columns[6].HeaderText = "SALDO";
            //gridCrudContas.Columns[6].DefaultCellStyle.Format = "C2";
            //gridCrudContas.Columns[7].HeaderText = "DESDE";
            //gridCrudContas.Columns[8].HeaderText = "DESCRIÇÃO";
            //gridCrudContas.Columns[0].Width = 60;
            //gridCrudContas.Columns[1].Width = 180;
            //gridCrudContas.Columns[2].Width = 180;
            //gridCrudContas.Columns[3].Width = 110;
            //gridCrudContas.Columns[4].Width = 110;
            //gridCrudContas.Columns[5].Width = 110;
            //gridCrudContas.Columns[6].Width = 110;
            //gridCrudContas.Columns[7].Width = 130;
            //gridCrudContas.Columns[8].Width = 200;
            //gridCrudContas.Columns[8].DisplayIndex = 1;
            //gridCrudContas.Columns[1].DisplayIndex = 2;
            //gridCrudContas.Columns[2].DisplayIndex = 3;
            //gridCrudContas.Columns[3].DisplayIndex = 4;
            //gridCrudContas.Columns[4].DisplayIndex = 5;
            //gridCrudContas.Columns[5].DisplayIndex = 6;
            //gridCrudContas.Columns[6].DisplayIndex = 7;
            //gridCrudContas.Columns[7].DisplayIndex = 8;
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            behaviorSave();
        }

        private void behaviorSave()
        {
            string retiraEspacos = txtBoxId.Text;
            string rem = retiraEspacos.Trim();
            if (txtIdconta.Text.Trim().Equals("") || txtIdconta.Text.Trim() == null)
            {
                if (operationType.Equals("newInsertion") && typeEdition.Equals("insert"))
                {
                    if (rem.Length <= 3)
                    {
                        var resultado = MessageBox.Show("A Inserção não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            txtIdconta.Text = "";
                            txtIdconta.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {
                            behaviorRefresh();
                        }
                    }
                    else if (rem.Length >= 3)
                    {
                        //movimentoController.Cadastrar(txtIdconta.Text,
                        //    cbBanco.SelectedItem.ToString(),
                        //    txtAgencia.Text,
                        //    txtNumero.Text,
                        //    txtDigito.Text,
                        //    Convert.ToDouble(txtSaldo.Text, CultureInfo.CurrentCulture),
                        //   dtData.Value,
                        //    txtDescricao.Text);
                        if ("NS".Equals(movimentoController.AcaoCrudMovimentoController()))
                        {
                            txtIdconta.Focus();
                            txtIdconta.Text = "";

                        }
                        else if ("S!".Equals(movimentoController.AcaoCrudMovimentoController()))
                        {
                            operationType = "newInsertion";
                            typeEdition = "insert";
                            acoesBehaviorSave();

                        }
                        else if ("S!!".Equals(movimentoController.AcaoCrudMovimentoController()))
                        {
                            //bttnNew
                            acoesBehaviorSave();

                        }
                    }
                }
            }
            else if (!txtIdconta.Text.Trim().Equals("") || txtIdconta.Text.Trim() != null)
            {

                if (operationType.Equals("updateData") && typeEdition.Equals("insert"))
                {
                    if (rem.Length <= 3)
                    {

                        var resultado = MessageBox.Show("A Edição não alcançou o número mínimo de 3 caracteres.\nPara tentar novamente clique no botão 'Sim'. E no botão 'Não' para cancelar e sair do modo de Inserção.", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {

                            txtIdconta.Focus();
                        }
                        else if (resultado == DialogResult.No)
                        {

                            behaviorRefresh();
                        }

                    }
                    else if (rem.Length >= 3)
                    {
                        //movimentoController.Editar(Convert.ToInt32(txtIdconta.Text.Trim()),
                        //    txtIdconta.Text,
                        //    cbBanco.SelectedItem.ToString(),
                        //    txtAgencia.Text,
                        //    txtNumero.Text,
                        //    txtDigito.Text,
                        //    Convert.ToDouble(txtSaldo.Text, CultureInfo.CurrentCulture),
                        //    dtData.Value,
                        //    txtDescricao.Text);
                        if ("AT".Equals(movimentoController.AcaoCrudMovimentoController()))
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
                            txtIdconta.Focus();
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
                        //movimentoController.Editar(Convert.ToInt32(txtIdconta.Text.Trim()),
                        //    txtIdconta.Text,
                        //    cbBanco.SelectedItem.ToString(),
                        //    txtAgencia.Text,
                        //    txtNumero.Text,
                        //    txtDigito.Text,
                        //    Convert.ToDouble(txtSaldo.Text, CultureInfo.CurrentCulture),
                        //    dtData.Value,
                        //    txtDescricao.Text);
                        if ("AT".Equals(movimentoController.AcaoCrudMovimentoController()))
                        {
                            behaviorRefresh();
                            puxarparametroPesquisa();

                        }
                    }
                }
            }
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            behaviorRefresh();
        }

        private void bttnSearch_Click(object sender, EventArgs e)
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
                txtBoxPesquisar.Text = "";
                txtBoxPesquisar.Focus();
                radioBttnComeca.Checked = true;
                gridCrudMovimentos.DataSource = movimentoController.PesquisarComecaCom("descricao", "@descricao", "");
                DataGridModel();
                typeEdition = "search";
                cbButtnQuantPage.Visible = false;
                cbOrdemParam.Visible = false;
                cbOrdenarPor.Visible = false;
                lblistarpor.Visible = false;
                lbordem.Visible = false;
                lbquantpg.Visible = false;
                groupBoxFormulario.Enabled = false;
                groupBoxFormulario.Visible = false;
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
                txtIdconta.Text = "";
                typeEdition = "insert";
                cbButtnQuantPage.Visible = true;
                cbOrdemParam.Visible = true;
                cbOrdenarPor.Visible = true;
                lblistarpor.Visible = true;
                lbordem.Visible = true;
                lbquantpg.Visible = true;

            }
        }

        private void MovimentosView_Load(object sender, EventArgs e)
        {
            CarregarComboBoxConta();
        }

       
    }
}
