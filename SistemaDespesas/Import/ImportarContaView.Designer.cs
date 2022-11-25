namespace SistemaDespesas.Import
{
    partial class ImportarContaView
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
            this.lbdigito = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.lbvalor = new System.Windows.Forms.Label();
            this.cbTipoMovimento = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricaoConta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbagencia = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdconta = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.cbConta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbdigito
            // 
            this.lbdigito.AutoSize = true;
            this.lbdigito.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbdigito.Location = new System.Drawing.Point(438, 9);
            this.lbdigito.Name = "lbdigito";
            this.lbdigito.Size = new System.Drawing.Size(47, 17);
            this.lbdigito.TabIndex = 64;
            this.lbdigito.Text = "Digito:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Descrição:";
            // 
            // txtDigito
            // 
            this.txtDigito.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDigito.Location = new System.Drawing.Point(438, 29);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(60, 25);
            this.txtDigito.TabIndex = 65;
            // 
            // lbvalor
            // 
            this.lbvalor.AutoSize = true;
            this.lbvalor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbvalor.Location = new System.Drawing.Point(16, 104);
            this.lbvalor.Name = "lbvalor";
            this.lbvalor.Size = new System.Drawing.Size(42, 17);
            this.lbvalor.TabIndex = 50;
            this.lbvalor.Text = "Valor:";
            // 
            // cbTipoMovimento
            // 
            this.cbTipoMovimento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbTipoMovimento.FormattingEnabled = true;
            this.cbTipoMovimento.Items.AddRange(new object[] {
            "--Selecione--",
            "Despesa Fixa",
            "Despesa Variável",
            "Entrada Venda",
            "Entrada Salário",
            "Entrada Serviço"});
            this.cbTipoMovimento.Location = new System.Drawing.Point(16, 77);
            this.cbTipoMovimento.Name = "cbTipoMovimento";
            this.cbTipoMovimento.Size = new System.Drawing.Size(238, 25);
            this.cbTipoMovimento.TabIndex = 52;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(16, 124);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(238, 25);
            this.txtValor.TabIndex = 54;
            // 
            // txtDescricaoConta
            // 
            this.txtDescricaoConta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDescricaoConta.Location = new System.Drawing.Point(260, 172);
            this.txtDescricaoConta.Name = "txtDescricaoConta";
            this.txtDescricaoConta.Size = new System.Drawing.Size(238, 25);
            this.txtDescricaoConta.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(16, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Data:";
            // 
            // lbagencia
            // 
            this.lbagencia.AutoSize = true;
            this.lbagencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbagencia.Location = new System.Drawing.Point(260, 105);
            this.lbagencia.Name = "lbagencia";
            this.lbagencia.Size = new System.Drawing.Size(59, 17);
            this.lbagencia.TabIndex = 49;
            this.lbagencia.Text = "Agência:";
            // 
            // dtData
            // 
            this.dtData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(16, 172);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(238, 25);
            this.dtData.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(260, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "Banco";
            // 
            // txtIdconta
            // 
            this.txtIdconta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIdconta.Location = new System.Drawing.Point(16, 203);
            this.txtIdconta.Name = "txtIdconta";
            this.txtIdconta.Size = new System.Drawing.Size(48, 25);
            this.txtIdconta.TabIndex = 51;
            // 
            // txtBanco
            // 
            this.txtBanco.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBanco.Location = new System.Drawing.Point(260, 77);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(238, 25);
            this.txtBanco.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tipo Movimento:";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescricao.Location = new System.Drawing.Point(260, 152);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(65, 17);
            this.lbDescricao.TabIndex = 47;
            this.lbDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.Location = new System.Drawing.Point(14, 29);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(240, 25);
            this.txtDescricao.TabIndex = 58;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAgencia.Location = new System.Drawing.Point(260, 124);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(238, 25);
            this.txtAgencia.TabIndex = 53;
            // 
            // cbConta
            // 
            this.cbConta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbConta.FormattingEnabled = true;
            this.cbConta.Location = new System.Drawing.Point(260, 29);
            this.cbConta.Name = "cbConta";
            this.cbConta.Size = new System.Drawing.Size(172, 25);
            this.cbConta.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::SistemaDespesas.Properties.Resources.ok24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(423, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 67;
            this.button1.Text = "Salvar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::SistemaDespesas.Properties.Resources.close24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(342, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 68;
            this.button2.Text = "Sair";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImportarContaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbConta);
            this.Controls.Add(this.lbdigito);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDigito);
            this.Controls.Add(this.lbvalor);
            this.Controls.Add(this.cbTipoMovimento);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricaoConta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbagencia);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIdconta);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtAgencia);
            this.Name = "ImportarContaView";
            this.Text = "ImportarContaView";
            this.Load += new System.EventHandler(this.ImportarContaView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbdigito;
        private Label label8;
        private TextBox txtDigito;
        private Label lbvalor;
        private ComboBox cbTipoMovimento;
        private TextBox txtValor;
        private TextBox txtDescricaoConta;
        private Label label9;
        private Label lbagencia;
        private DateTimePicker dtData;
        private Label label10;
        private TextBox txtIdconta;
        private TextBox txtBanco;
        private Label label3;
        private Label lbDescricao;
        private TextBox txtDescricao;
        private TextBox txtAgencia;
        private ComboBox cbConta;
        private Button button1;
        private Button button2;
    }
}