namespace SistemaEstoque.Telas
{
    partial class frmMovimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labe5 = new System.Windows.Forms.Label();
            this.cboLocalEstoque = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.chkSaida = new System.Windows.Forms.CheckBox();
            this.dtpDataHora = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 61);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::SistemaEstoque.Telas.Properties.Resources.Cargo_Boxes_35596;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labe5);
            this.panel2.Controls.Add(this.cboLocalEstoque);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cboProduto);
            this.panel2.Controls.Add(this.chkSaida);
            this.panel2.Controls.Add(this.dtpDataHora);
            this.panel2.Controls.Add(this.txtDescricao);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtQuantidade);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 270);
            this.panel2.TabIndex = 3;
            // 
            // labe5
            // 
            this.labe5.AutoSize = true;
            this.labe5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe5.Location = new System.Drawing.Point(319, 21);
            this.labe5.Name = "labe5";
            this.labe5.Size = new System.Drawing.Size(198, 15);
            this.labe5.TabIndex = 13;
            this.labe5.Text = "Selecione o Local de Estoque";
            // 
            // cboLocalEstoque
            // 
            this.cboLocalEstoque.FormattingEnabled = true;
            this.cboLocalEstoque.Location = new System.Drawing.Point(322, 51);
            this.cboLocalEstoque.Name = "cboLocalEstoque";
            this.cboLocalEstoque.Size = new System.Drawing.Size(195, 21);
            this.cboLocalEstoque.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selecione o Produto";
            // 
            // cboProduto
            // 
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(39, 51);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(195, 21);
            this.cboProduto.TabIndex = 10;
            // 
            // chkSaida
            // 
            this.chkSaida.AutoSize = true;
            this.chkSaida.Location = new System.Drawing.Point(39, 163);
            this.chkSaida.Name = "chkSaida";
            this.chkSaida.Size = new System.Drawing.Size(135, 17);
            this.chkSaida.TabIndex = 9;
            this.chkSaida.Text = "É Movimento de Saída";
            this.chkSaida.UseVisualStyleBackColor = true;
            // 
            // dtpDataHora
            // 
            this.dtpDataHora.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDataHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataHora.Location = new System.Drawing.Point(39, 115);
            this.dtpDataHora.Name = "dtpDataHora";
            this.dtpDataHora.Size = new System.Drawing.Size(147, 20);
            this.dtpDataHora.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(39, 220);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(355, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite a Descrição";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(322, 114);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(120, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a Data e a Hora";
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::SistemaEstoque.Telas.Properties.Resources.botao_fechar;
            this.btnFechar.Location = new System.Drawing.Point(140, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(131, 56);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::SistemaEstoque.Telas.Properties.Resources.botao_salvar;
            this.btnSalvar.Location = new System.Drawing.Point(3, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(131, 56);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Movimento";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataHora;
        private System.Windows.Forms.CheckBox chkSaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Label labe5;
        private System.Windows.Forms.ComboBox cboLocalEstoque;
    }
}