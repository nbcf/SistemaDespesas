namespace SistemaDespesas.views
{
    partial class ContasView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContasView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bttnNew = new System.Windows.Forms.ToolStripButton();
            this.bttnSave = new System.Windows.Forms.ToolStripButton();
            this.bttnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bttnEdit = new System.Windows.Forms.ToolStripButton();
            this.bttnSearch = new System.Windows.Forms.ToolStripButton();
            this.bttnDel = new System.Windows.Forms.ToolStripButton();
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
            this.tabControlAssets = new System.Windows.Forms.TabControl();
            this.tabPagePesquisar = new System.Windows.Forms.TabPage();
            this.radioBttnTermina = new System.Windows.Forms.RadioButton();
            this.radioBttnContem = new System.Windows.Forms.RadioButton();
            this.radioBttnComeca = new System.Windows.Forms.RadioButton();
            this.cbButtonPesquisarEm = new System.Windows.Forms.ComboBox();
            this.txtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCrudContas = new System.Windows.Forms.DataGridView();
            this.groupBoxFormulario = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.dtDeste = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabControlAssets.SuspendLayout();
            this.tabPagePesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrudContas)).BeginInit();
            this.groupBoxFormulario.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(949, 51);
            this.toolStrip1.TabIndex = 0;
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
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
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
            this.bttnSearch.Click += new System.EventHandler(this.toolStripButton9_Click);
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
            this.bttnDel.Click += new System.EventHandler(this.bttnDel_Click);
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
            this.toolStrip2.Location = new System.Drawing.Point(0, 422);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(949, 28);
            this.toolStrip2.TabIndex = 1;
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
            this.bttnBeginPages.Click += new System.EventHandler(this.bttnBeginPages_Click);
            // 
            // bttnOnePageLeft
            // 
            this.bttnOnePageLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnOnePageLeft.Image = global::SistemaDespesas.Properties.Resources._1leftarrow;
            this.bttnOnePageLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnOnePageLeft.Name = "bttnOnePageLeft";
            this.bttnOnePageLeft.Size = new System.Drawing.Size(23, 25);
            this.bttnOnePageLeft.Text = "toolStripButton2";
            this.bttnOnePageLeft.Click += new System.EventHandler(this.bttnOnePageLeft_Click);
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
            this.bttnOnePageRight.Click += new System.EventHandler(this.bttnOnePageRight_Click);
            // 
            // bttnEndPages
            // 
            this.bttnEndPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bttnEndPages.Image = global::SistemaDespesas.Properties.Resources._2rightarrow;
            this.bttnEndPages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttnEndPages.Name = "bttnEndPages";
            this.bttnEndPages.Size = new System.Drawing.Size(23, 25);
            this.bttnEndPages.Text = "toolStripButton4";
            this.bttnEndPages.Click += new System.EventHandler(this.bttnEndPages_Click);
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
            this.cbButtnQuantPage.SelectedIndexChanged += new System.EventHandler(this.cbButtnQuantPage_SelectedIndexChanged);
            this.cbButtnQuantPage.Click += new System.EventHandler(this.cbButtnQuantPage_Click);
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
            this.cbOrdemParam.SelectedIndexChanged += new System.EventHandler(this.cbOrdemParam1_SelectedIndexChanged);
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
            this.cbOrdenarPor.SelectedIndexChanged += new System.EventHandler(this.cbOrdenarPor1_SelectedIndexChanged);
            // 
            // tabControlAssets
            // 
            this.tabControlAssets.Controls.Add(this.tabPagePesquisar);
            this.tabControlAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAssets.Location = new System.Drawing.Point(0, 51);
            this.tabControlAssets.Name = "tabControlAssets";
            this.tabControlAssets.SelectedIndex = 0;
            this.tabControlAssets.Size = new System.Drawing.Size(949, 77);
            this.tabControlAssets.TabIndex = 2;
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
            this.tabPagePesquisar.Size = new System.Drawing.Size(941, 49);
            this.tabPagePesquisar.TabIndex = 0;
            this.tabPagePesquisar.Text = "Pesquisar";
            // 
            // radioBttnTermina
            // 
            this.radioBttnTermina.AutoSize = true;
            this.radioBttnTermina.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBttnTermina.Location = new System.Drawing.Point(495, 9);
            this.radioBttnTermina.Name = "radioBttnTermina";
            this.radioBttnTermina.Size = new System.Drawing.Size(74, 21);
            this.radioBttnTermina.TabIndex = 4;
            this.radioBttnTermina.TabStop = true;
            this.radioBttnTermina.Text = "Termina";
            this.radioBttnTermina.UseVisualStyleBackColor = true;
            this.radioBttnTermina.CheckedChanged += new System.EventHandler(this.radioBttnTermina_CheckedChanged);
            // 
            // radioBttnContem
            // 
            this.radioBttnContem.AutoSize = true;
            this.radioBttnContem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBttnContem.Location = new System.Drawing.Point(416, 9);
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
            this.radioBttnComeca.Location = new System.Drawing.Point(337, 9);
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
            this.cbButtonPesquisarEm.SelectedIndexChanged += new System.EventHandler(this.cbButtonPesquisarEm_SelectedIndexChanged);
            // 
            // txtBoxPesquisar
            // 
            this.txtBoxPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPesquisar.Location = new System.Drawing.Point(6, 7);
            this.txtBoxPesquisar.Name = "txtBoxPesquisar";
            this.txtBoxPesquisar.Size = new System.Drawing.Size(194, 25);
            this.txtBoxPesquisar.TabIndex = 0;
            this.txtBoxPesquisar.TextChanged += new System.EventHandler(this.txtBoxPesquisar_TextChanged);
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
            this.label1.Location = new System.Drawing.Point(707, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // gridCrudContas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridCrudContas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCrudContas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCrudContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCrudContas.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridCrudContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrudContas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCrudContas.Location = new System.Drawing.Point(0, 128);
            this.gridCrudContas.MultiSelect = false;
            this.gridCrudContas.Name = "gridCrudContas";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridCrudContas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridCrudContas.RowTemplate.Height = 25;
            this.gridCrudContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCrudContas.Size = new System.Drawing.Size(949, 294);
            this.gridCrudContas.TabIndex = 3;
            this.gridCrudContas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCrudContas_CellClick);
            // 
            // groupBoxFormulario
            // 
            this.groupBoxFormulario.Controls.Add(this.txtDescricao);
            this.groupBoxFormulario.Controls.Add(this.groupBox1);
            this.groupBoxFormulario.Controls.Add(this.dtDeste);
            this.groupBoxFormulario.Controls.Add(this.label9);
            this.groupBoxFormulario.Controls.Add(this.label8);
            this.groupBoxFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFormulario.Location = new System.Drawing.Point(0, 128);
            this.groupBoxFormulario.Name = "groupBoxFormulario";
            this.groupBoxFormulario.Size = new System.Drawing.Size(949, 294);
            this.groupBoxFormulario.TabIndex = 4;
            this.groupBoxFormulario.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.Location = new System.Drawing.Point(10, 36);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(240, 25);
            this.txtDescricao.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDigito);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.cbBanco);
            this.groupBox1.Controls.Add(this.txtAgencia);
            this.groupBox1.Location = new System.Drawing.Point(8, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 186);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Banco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Agência:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(240, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dig.:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSaldo.Location = new System.Drawing.Point(77, 146);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(155, 25);
            this.txtSaldo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saldo:";
            // 
            // txtDigito
            // 
            this.txtDigito.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDigito.Location = new System.Drawing.Point(275, 117);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(52, 25);
            this.txtDigito.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(77, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 25);
            this.txtNome.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(77, 117);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(155, 25);
            this.txtNumero.TabIndex = 11;
            // 
            // cbBanco
            // 
            this.cbBanco.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Items.AddRange(new object[] {
            "Banco do Brasil",
            "Caixa Economica Federal"});
            this.cbBanco.Location = new System.Drawing.Point(77, 55);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(250, 25);
            this.cbBanco.TabIndex = 9;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAgencia.Location = new System.Drawing.Point(77, 86);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(250, 25);
            this.txtAgencia.TabIndex = 10;
            // 
            // dtDeste
            // 
            this.dtDeste.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDeste.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDeste.Location = new System.Drawing.Point(256, 36);
            this.dtDeste.Name = "dtDeste";
            this.dtDeste.Size = new System.Drawing.Size(121, 25);
            this.dtDeste.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(256, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Conta Desde:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Descrição:";
            // 
            // ContasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.groupBoxFormulario);
            this.Controls.Add(this.gridCrudContas);
            this.Controls.Add(this.tabControlAssets);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContasView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContasView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContasView_FormClosing);
            this.Load += new System.EventHandler(this.ContasView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabControlAssets.ResumeLayout(false);
            this.tabPagePesquisar.ResumeLayout(false);
            this.tabPagePesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrudContas)).EndInit();
            this.groupBoxFormulario.ResumeLayout(false);
            this.groupBoxFormulario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStrip toolStrip2;
        private TabControl tabControlAssets;
        private TabPage tabPagePesquisar;
        private DataGridView gridCrudContas;
        private GroupBox groupBoxFormulario;
        private ToolStripButton bttnBeginPages;
        private ToolStripButton bttnOnePageLeft;
        private ToolStripLabel labelTextPageFrom;
        private ToolStripLabel lbseparador;
        private ToolStripLabel labelTextTotalPages;
        private ToolStripLabel lbseparadortraco;
        private ToolStripLabel labelTextTotalRegFould;
        private ToolStripButton bttnOnePageRight;
        private ToolStripButton bttnEndPages;
        private ToolStripButton bttnNew;
        private ToolStripButton bttnSave;
        private ToolStripButton bttnRefresh;
        private ToolStripButton bttnEdit;
        private ToolStripButton bttnSearch;
        private ToolStripButton bttnDel;
        private TextBox txtSaldo;
        private TextBox txtDigito;
        private TextBox txtNumero;
        private TextBox txtAgencia;
        private ComboBox cbBanco;
        private TextBox txtNome;
        private TextBox txtBoxId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbButtonPesquisarEm;
        private TextBox txtBoxPesquisar;
        private RadioButton radioBttnTermina;
        private RadioButton radioBttnContem;
        private RadioButton radioBttnComeca;
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
        private Label label8;
        private GroupBox groupBox1;
        private DateTimePicker dtDeste;
        private Label label9;
        private TextBox txtDescricao;
    }
}