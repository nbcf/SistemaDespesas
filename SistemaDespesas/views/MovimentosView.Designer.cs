namespace SistemaDespesas.views
{
    partial class MovimentosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bttnNew = new System.Windows.Forms.ToolStripButton();
            this.bttnSave = new System.Windows.Forms.ToolStripButton();
            this.bttnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bttnEdit = new System.Windows.Forms.ToolStripButton();
            this.bttnSearch = new System.Windows.Forms.ToolStripButton();
            this.bttnDel = new System.Windows.Forms.ToolStripButton();
            this.tabControlAssets = new System.Windows.Forms.TabControl();
            this.tabPagePesquisar = new System.Windows.Forms.TabPage();
            this.radioBttnTermina = new System.Windows.Forms.RadioButton();
            this.radioBttnContem = new System.Windows.Forms.RadioButton();
            this.radioBttnComeca = new System.Windows.Forms.RadioButton();
            this.cbButtonPesquisarEm = new System.Windows.Forms.ComboBox();
            this.txtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.bttnBeginPages = new System.Windows.Forms.ToolStripButton();
            this.bttnOnePageLeft = new System.Windows.Forms.ToolStripButton();
            this.labelTextPageFrom = new System.Windows.Forms.ToolStripLabel();
            this.lbseparador = new System.Windows.Forms.ToolStripLabel();
            this.labelTextTotalPages = new System.Windows.Forms.ToolStripLabel();
            this.lbseparadortraco = new System.Windows.Forms.ToolStripLabel();
            this.labelTextTotalRegFould = new System.Windows.Forms.ToolStripLabel();
            this.bttnOnePageRight = new System.Windows.Forms.ToolStripButton();
            this.bttnEndPages = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbtitulototalencontrados = new System.Windows.Forms.ToolStripLabel();
            this.lbTotalEncontrados = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbquantpg = new System.Windows.Forms.ToolStripLabel();
            this.cbButtnQuantPage = new System.Windows.Forms.ToolStripComboBox();
            this.lblistarpor = new System.Windows.Forms.ToolStripLabel();
            this.cbOrdemParam = new System.Windows.Forms.ToolStripComboBox();
            this.lbordem = new System.Windows.Forms.ToolStripLabel();
            this.cbOrdenarPor = new System.Windows.Forms.ToolStripComboBox();
            this.gridCrudMovimentos = new System.Windows.Forms.DataGridView();
            this.groupBoxFormulario = new System.Windows.Forms.GroupBox();
            this.txtIdconta = new System.Windows.Forms.TextBox();
            this.cbConta = new System.Windows.Forms.ComboBox();
            this.lbdigito = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.lbvalor = new System.Windows.Forms.Label();
            this.txtDescricaoConta = new System.Windows.Forms.TextBox();
            this.cbTipoMovimento = new System.Windows.Forms.ComboBox();
            this.lbagencia = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tabControlAssets.SuspendLayout();
            this.tabPagePesquisar.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrudMovimentos)).BeginInit();
            this.groupBoxFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttnNew,
            this.bttnSave,
            this.bttnRefresh,
            this.bttnEdit,
            this.bttnSearch,
            this.bttnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(975, 51);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bttnNew
            // 
            this.bttnNew.AutoSize = false;
            this.bttnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnNew.Image = global::SistemaDespesas.Properties.Resources.add48;
            this.bttnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnNew.Name = "bttnNew";
            this.bttnNew.Size = new System.Drawing.Size(80, 48);
            this.bttnNew.Text = "toolStripButton5";
            this.bttnNew.Click += new System.EventHandler(this.bttnNew_Click);
            // 
            // bttnSave
            // 
            this.bttnSave.AutoSize = false;
            this.bttnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnSave.Image = global::SistemaDespesas.Properties.Resources.save48;
            this.bttnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(80, 48);
            this.bttnSave.Text = "toolStripButton6";
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.AutoSize = false;
            this.bttnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnRefresh.Image = global::SistemaDespesas.Properties.Resources.refresh48;
            this.bttnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(80, 48);
            this.bttnRefresh.Text = "toolStripButton7";
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            // 
            // bttnEdit
            // 
            this.bttnEdit.AutoSize = false;
            this.bttnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnEdit.Image = global::SistemaDespesas.Properties.Resources.editForm48;
            this.bttnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(80, 48);
            this.bttnEdit.Text = "toolStripButton8";
            // 
            // bttnSearch
            // 
            this.bttnSearch.AutoSize = false;
            this.bttnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnSearch.Image = global::SistemaDespesas.Properties.Resources.search48;
            this.bttnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(80, 48);
            this.bttnSearch.Text = "toolStripButton9";
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // bttnDel
            // 
            this.bttnDel.AutoSize = false;
            this.bttnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnDel.Image = global::SistemaDespesas.Properties.Resources.del48;
            this.bttnDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bttnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnDel.Name = "bttnDel";
            this.bttnDel.Size = new System.Drawing.Size(80, 48);
            this.bttnDel.Text = "toolStripButton10";
            // 
            // tabControlAssets
            // 
            this.tabControlAssets.Controls.Add(this.tabPagePesquisar);
            this.tabControlAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAssets.Location = new System.Drawing.Point(0, 51);
            this.tabControlAssets.Name = "tabControlAssets";
            this.tabControlAssets.SelectedIndex = 0;
            this.tabControlAssets.Size = new System.Drawing.Size(975, 77);
            this.tabControlAssets.TabIndex = 3;
            // 
            // tabPagePesquisar
            // 
            this.tabPagePesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePesquisar.Controls.Add(this.radioBttnTermina);
            this.tabPagePesquisar.Controls.Add(this.radioBttnContem);
            this.tabPagePesquisar.Controls.Add(this.radioBttnComeca);
            this.tabPagePesquisar.Controls.Add(this.cbButtonPesquisarEm);
            this.tabPagePesquisar.Controls.Add(this.txtBoxPesquisar);
            this.tabPagePesquisar.Controls.Add(this.txtBoxId);
            this.tabPagePesquisar.Controls.Add(this.label1);
            this.tabPagePesquisar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPagePesquisar.Location = new System.Drawing.Point(4, 24);
            this.tabPagePesquisar.Name = "tabPagePesquisar";
            this.tabPagePesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesquisar.Size = new System.Drawing.Size(967, 49);
            this.tabPagePesquisar.TabIndex = 0;
            this.tabPagePesquisar.Text = "Pesquisar";
            // 
            // radioBttnTermina
            // 
            this.radioBttnTermina.AutoSize = true;
            this.radioBttnTermina.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBttnTermina.Location = new System.Drawing.Point(498, 12);
            this.radioBttnTermina.Name = "radioBttnTermina";
            this.radioBttnTermina.Size = new System.Drawing.Size(74, 21);
            this.radioBttnTermina.TabIndex = 4;
            this.radioBttnTermina.TabStop = true;
            this.radioBttnTermina.Text = "Termina";
            this.radioBttnTermina.UseVisualStyleBackColor = true;
            // 
            // radioBttnContem
            // 
            this.radioBttnContem.AutoSize = true;
            this.radioBttnContem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBttnContem.Location = new System.Drawing.Point(419, 12);
            this.radioBttnContem.Name = "radioBttnContem";
            this.radioBttnContem.Size = new System.Drawing.Size(74, 21);
            this.radioBttnContem.TabIndex = 3;
            this.radioBttnContem.TabStop = true;
            this.radioBttnContem.Text = "Contém";
            this.radioBttnContem.UseVisualStyleBackColor = true;
            // 
            // radioBttnComeca
            // 
            this.radioBttnComeca.AutoSize = true;
            this.radioBttnComeca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBttnComeca.Location = new System.Drawing.Point(340, 12);
            this.radioBttnComeca.Name = "radioBttnComeca";
            this.radioBttnComeca.Size = new System.Drawing.Size(74, 21);
            this.radioBttnComeca.TabIndex = 2;
            this.radioBttnComeca.TabStop = true;
            this.radioBttnComeca.Text = "Começa";
            this.radioBttnComeca.UseVisualStyleBackColor = true;
            // 
            // cbButtonPesquisarEm
            // 
            this.cbButtonPesquisarEm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbButtonPesquisarEm.FormattingEnabled = true;
            this.cbButtonPesquisarEm.Items.AddRange(new object[] {
            "Nome"});
            this.cbButtonPesquisarEm.Location = new System.Drawing.Point(206, 7);
            this.cbButtonPesquisarEm.Name = "cbButtonPesquisarEm";
            this.cbButtonPesquisarEm.Size = new System.Drawing.Size(126, 25);
            this.cbButtonPesquisarEm.TabIndex = 1;
            // 
            // txtBoxPesquisar
            // 
            this.txtBoxPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPesquisar.Location = new System.Drawing.Point(6, 7);
            this.txtBoxPesquisar.Name = "txtBoxPesquisar";
            this.txtBoxPesquisar.Size = new System.Drawing.Size(194, 25);
            this.txtBoxPesquisar.TabIndex = 0;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxId.Location = new System.Drawing.Point(737, 9);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(59, 25);
            this.txtBoxId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(710, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttnBeginPages,
            this.bttnOnePageLeft,
            this.labelTextPageFrom,
            this.lbseparador,
            this.labelTextTotalPages,
            this.lbseparadortraco,
            this.labelTextTotalRegFould,
            this.bttnOnePageRight,
            this.bttnEndPages,
            this.toolStripSeparator1,
            this.lbtitulototalencontrados,
            this.lbTotalEncontrados,
            this.toolStripSeparator2,
            this.lbquantpg,
            this.cbButtnQuantPage,
            this.lblistarpor,
            this.cbOrdemParam,
            this.lbordem,
            this.cbOrdenarPor});
            this.toolStrip2.Location = new System.Drawing.Point(0, 554);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(975, 28);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // bttnBeginPages
            // 
            this.bttnBeginPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnBeginPages.Image = global::SistemaDespesas.Properties.Resources._2leftarrow;
            this.bttnBeginPages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnBeginPages.Name = "bttnBeginPages";
            this.bttnBeginPages.Size = new System.Drawing.Size(23, 25);
            this.bttnBeginPages.Text = "toolStripButton1";
            // 
            // bttnOnePageLeft
            // 
            this.bttnOnePageLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnOnePageLeft.Image = global::SistemaDespesas.Properties.Resources._1leftarrow;
            this.bttnOnePageLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnOnePageLeft.Name = "bttnOnePageLeft";
            this.bttnOnePageLeft.Size = new System.Drawing.Size(23, 25);
            this.bttnOnePageLeft.Text = "toolStripButton2";
            // 
            // labelTextPageFrom
            // 
            this.labelTextPageFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTextPageFrom.Name = "labelTextPageFrom";
            this.labelTextPageFrom.Size = new System.Drawing.Size(17, 25);
            this.labelTextPageFrom.Text = "0";
            // 
            // lbseparador
            // 
            this.lbseparador.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbseparador.Name = "lbseparador";
            this.lbseparador.Size = new System.Drawing.Size(15, 25);
            this.lbseparador.Text = "/";
            // 
            // labelTextTotalPages
            // 
            this.labelTextTotalPages.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTextTotalPages.Name = "labelTextTotalPages";
            this.labelTextTotalPages.Size = new System.Drawing.Size(17, 25);
            this.labelTextTotalPages.Text = "0";
            // 
            // lbseparadortraco
            // 
            this.lbseparadortraco.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbseparadortraco.Name = "lbseparadortraco";
            this.lbseparadortraco.Size = new System.Drawing.Size(15, 25);
            this.lbseparadortraco.Text = "-";
            // 
            // labelTextTotalRegFould
            // 
            this.labelTextTotalRegFould.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTextTotalRegFould.Name = "labelTextTotalRegFould";
            this.labelTextTotalRegFould.Size = new System.Drawing.Size(17, 25);
            this.labelTextTotalRegFould.Text = "0";
            // 
            // bttnOnePageRight
            // 
            this.bttnOnePageRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnOnePageRight.Image = global::SistemaDespesas.Properties.Resources._1rightarrow;
            this.bttnOnePageRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnOnePageRight.Name = "bttnOnePageRight";
            this.bttnOnePageRight.Size = new System.Drawing.Size(23, 25);
            this.bttnOnePageRight.Text = "toolStripButton3";
            // 
            // bttnEndPages
            // 
            this.bttnEndPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnEndPages.Image = global::SistemaDespesas.Properties.Resources._2rightarrow;
            this.bttnEndPages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnEndPages.Name = "bttnEndPages";
            this.bttnEndPages.Size = new System.Drawing.Size(23, 25);
            this.bttnEndPages.Text = "toolStripButton4";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // lbtitulototalencontrados
            // 
            this.lbtitulototalencontrados.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtitulototalencontrados.Name = "lbtitulototalencontrados";
            this.lbtitulototalencontrados.Size = new System.Drawing.Size(201, 25);
            this.lbtitulototalencontrados.Text = "Total Registros Encontrados:";
            // 
            // lbTotalEncontrados
            // 
            this.lbTotalEncontrados.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalEncontrados.Name = "lbTotalEncontrados";
            this.lbTotalEncontrados.Size = new System.Drawing.Size(33, 25);
            this.lbTotalEncontrados.Text = "000";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // lbquantpg
            // 
            this.lbquantpg.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbquantpg.Name = "lbquantpg";
            this.lbquantpg.Size = new System.Drawing.Size(54, 25);
            this.lbquantpg.Text = "Qt.Pg.:";
            // 
            // cbButtnQuantPage
            // 
            this.cbButtnQuantPage.AutoSize = false;
            this.cbButtnQuantPage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbButtnQuantPage.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "75",
            "100"});
            this.cbButtnQuantPage.Name = "cbButtnQuantPage";
            this.cbButtnQuantPage.Size = new System.Drawing.Size(80, 28);
            // 
            // lblistarpor
            // 
            this.lblistarpor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblistarpor.Name = "lblistarpor";
            this.lblistarpor.Size = new System.Drawing.Size(77, 25);
            this.lblistarpor.Text = "Listar Por:";
            // 
            // cbOrdemParam
            // 
            this.cbOrdemParam.AutoSize = false;
            this.cbOrdemParam.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbOrdemParam.Items.AddRange(new object[] {
            "Codigo",
            "Alfabeto"});
            this.cbOrdemParam.Name = "cbOrdemParam";
            this.cbOrdemParam.Size = new System.Drawing.Size(90, 28);
            // 
            // lbordem
            // 
            this.lbordem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbordem.Name = "lbordem";
            this.lbordem.Size = new System.Drawing.Size(71, 25);
            this.lbordem.Text = "Ordenar:";
            // 
            // cbOrdenarPor
            // 
            this.cbOrdenarPor.AutoSize = false;
            this.cbOrdenarPor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbOrdenarPor.Items.AddRange(new object[] {
            "Primeiros",
            "Ultimos"});
            this.cbOrdenarPor.Name = "cbOrdenarPor";
            this.cbOrdenarPor.Size = new System.Drawing.Size(90, 28);
            // 
            // gridCrudMovimentos
            // 
            this.gridCrudMovimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCrudMovimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrudMovimentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCrudMovimentos.Location = new System.Drawing.Point(0, 128);
            this.gridCrudMovimentos.Name = "gridCrudMovimentos";
            this.gridCrudMovimentos.RowTemplate.Height = 25;
            this.gridCrudMovimentos.Size = new System.Drawing.Size(975, 426);
            this.gridCrudMovimentos.TabIndex = 5;
            // 
            // groupBoxFormulario
            // 
            this.groupBoxFormulario.Controls.Add(this.txtIdconta);
            this.groupBoxFormulario.Controls.Add(this.cbConta);
            this.groupBoxFormulario.Controls.Add(this.lbdigito);
            this.groupBoxFormulario.Controls.Add(this.label8);
            this.groupBoxFormulario.Controls.Add(this.txtDigito);
            this.groupBoxFormulario.Controls.Add(this.lbvalor);
            this.groupBoxFormulario.Controls.Add(this.txtDescricaoConta);
            this.groupBoxFormulario.Controls.Add(this.cbTipoMovimento);
            this.groupBoxFormulario.Controls.Add(this.lbagencia);
            this.groupBoxFormulario.Controls.Add(this.txtValor);
            this.groupBoxFormulario.Controls.Add(this.label10);
            this.groupBoxFormulario.Controls.Add(this.label9);
            this.groupBoxFormulario.Controls.Add(this.txtBanco);
            this.groupBoxFormulario.Controls.Add(this.dtData);
            this.groupBoxFormulario.Controls.Add(this.lbDescricao);
            this.groupBoxFormulario.Controls.Add(this.label3);
            this.groupBoxFormulario.Controls.Add(this.txtAgencia);
            this.groupBoxFormulario.Controls.Add(this.txtDescricao);
            this.groupBoxFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFormulario.Location = new System.Drawing.Point(0, 128);
            this.groupBoxFormulario.Name = "groupBoxFormulario";
            this.groupBoxFormulario.Size = new System.Drawing.Size(975, 426);
            this.groupBoxFormulario.TabIndex = 6;
            this.groupBoxFormulario.TabStop = false;
            // 
            // txtIdconta
            // 
            this.txtIdconta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIdconta.Location = new System.Drawing.Point(498, 39);
            this.txtIdconta.Name = "txtIdconta";
            this.txtIdconta.Size = new System.Drawing.Size(48, 25);
            this.txtIdconta.TabIndex = 76;
            // 
            // cbConta
            // 
            this.cbConta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbConta.FormattingEnabled = true;
            this.cbConta.Location = new System.Drawing.Point(254, 39);
            this.cbConta.Name = "cbConta";
            this.cbConta.Size = new System.Drawing.Size(172, 25);
            this.cbConta.TabIndex = 75;
            this.cbConta.SelectedIndexChanged += new System.EventHandler(this.cbConta_SelectedIndexChanged);
            // 
            // lbdigito
            // 
            this.lbdigito.AutoSize = true;
            this.lbdigito.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbdigito.Location = new System.Drawing.Point(432, 19);
            this.lbdigito.Name = "lbdigito";
            this.lbdigito.Size = new System.Drawing.Size(47, 17);
            this.lbdigito.TabIndex = 73;
            this.lbdigito.Text = "Digito:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Descrição:";
            // 
            // txtDigito
            // 
            this.txtDigito.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDigito.Location = new System.Drawing.Point(432, 39);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(60, 25);
            this.txtDigito.TabIndex = 74;
            // 
            // lbvalor
            // 
            this.lbvalor.AutoSize = true;
            this.lbvalor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbvalor.Location = new System.Drawing.Point(10, 114);
            this.lbvalor.Name = "lbvalor";
            this.lbvalor.Size = new System.Drawing.Size(42, 17);
            this.lbvalor.TabIndex = 31;
            this.lbvalor.Text = "Valor:";
            // 
            // txtDescricaoConta
            // 
            this.txtDescricaoConta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDescricaoConta.Location = new System.Drawing.Point(254, 182);
            this.txtDescricaoConta.Name = "txtDescricaoConta";
            this.txtDescricaoConta.Size = new System.Drawing.Size(238, 25);
            this.txtDescricaoConta.TabIndex = 72;
            // 
            // cbTipoMovimento
            // 
            this.cbTipoMovimento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbTipoMovimento.FormattingEnabled = true;
            this.cbTipoMovimento.Items.AddRange(new object[] {
            "Banco do Brasil",
            "Caixa Economica Federal"});
            this.cbTipoMovimento.Location = new System.Drawing.Point(10, 87);
            this.cbTipoMovimento.Name = "cbTipoMovimento";
            this.cbTipoMovimento.Size = new System.Drawing.Size(238, 25);
            this.cbTipoMovimento.TabIndex = 33;
            // 
            // lbagencia
            // 
            this.lbagencia.AutoSize = true;
            this.lbagencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbagencia.Location = new System.Drawing.Point(254, 115);
            this.lbagencia.Name = "lbagencia";
            this.lbagencia.Size = new System.Drawing.Size(59, 17);
            this.lbagencia.TabIndex = 68;
            this.lbagencia.Text = "Agência:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(10, 134);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(238, 25);
            this.txtValor.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(254, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 70;
            this.label10.Text = "Banco";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(10, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Data:";
            // 
            // txtBanco
            // 
            this.txtBanco.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBanco.Location = new System.Drawing.Point(254, 87);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(238, 25);
            this.txtBanco.TabIndex = 71;
            // 
            // dtData
            // 
            this.dtData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(10, 182);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(238, 25);
            this.dtData.TabIndex = 38;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescricao.Location = new System.Drawing.Point(254, 162);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(65, 17);
            this.lbDescricao.TabIndex = 67;
            this.lbDescricao.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tipo Movimento:";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAgencia.Location = new System.Drawing.Point(254, 134);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(238, 25);
            this.txtAgencia.TabIndex = 69;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.Location = new System.Drawing.Point(8, 39);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(240, 25);
            this.txtDescricao.TabIndex = 39;
            // 
            // MovimentosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 582);
            this.Controls.Add(this.groupBoxFormulario);
            this.Controls.Add(this.gridCrudMovimentos);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.tabControlAssets);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MovimentosView";
            this.Text = "Movimentos";
            this.Load += new System.EventHandler(this.MovimentosView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControlAssets.ResumeLayout(false);
            this.tabPagePesquisar.ResumeLayout(false);
            this.tabPagePesquisar.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrudMovimentos)).EndInit();
            this.groupBoxFormulario.ResumeLayout(false);
            this.groupBoxFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton bttnNew;
        private ToolStripButton bttnSave;
        private ToolStripButton bttnRefresh;
        private ToolStripButton bttnEdit;
        private ToolStripButton bttnSearch;
        private ToolStripButton bttnDel;
        private TabControl tabControlAssets;
        private TabPage tabPagePesquisar;
        private RadioButton radioBttnTermina;
        private RadioButton radioBttnContem;
        private RadioButton radioBttnComeca;
        private ComboBox cbButtonPesquisarEm;
        private TextBox txtBoxPesquisar;
        private TextBox txtBoxId;
        private Label label1;
        private ToolStrip toolStrip2;
        private ToolStripButton bttnBeginPages;
        private ToolStripButton bttnOnePageLeft;
        private ToolStripLabel labelTextPageFrom;
        private ToolStripLabel lbseparador;
        private ToolStripLabel labelTextTotalPages;
        private ToolStripLabel lbseparadortraco;
        private ToolStripLabel labelTextTotalRegFould;
        private ToolStripButton bttnOnePageRight;
        private ToolStripButton bttnEndPages;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lbtitulototalencontrados;
        private ToolStripLabel lbTotalEncontrados;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel lbquantpg;
        private ToolStripComboBox cbButtnQuantPage;
        private ToolStripLabel lblistarpor;
        private ToolStripComboBox cbOrdemParam;
        private ToolStripLabel lbordem;
        private ToolStripComboBox cbOrdenarPor;
        private DataGridView gridCrudMovimentos;
        private GroupBox groupBoxFormulario;
        private Label label8;
        private Label lbvalor;
        private ComboBox cbTipoMovimento;
        private TextBox txtValor;
        private Label label9;
        private DateTimePicker dtData;
        private Label label3;
        private TextBox txtDescricao;
        private ComboBox cbConta;
        private Label lbdigito;
        private TextBox txtDigito;
        private TextBox txtDescricaoConta;
        private Label lbagencia;
        private Label label10;
        private TextBox txtBanco;
        private Label lbDescricao;
        private TextBox txtAgencia;
        private TextBox txtIdconta;
    }
}