namespace ControlePedidosMVP
{
    partial class CadastroItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpItens = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.btnAcrescentar = new System.Windows.Forms.Button();
            this.numQuant = new System.Windows.Forms.NumericUpDown();
            this.lblQuant = new System.Windows.Forms.Label();
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuant)).BeginInit();
            this.grpProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpItens);
            this.panel1.Controls.Add(this.btnAcrescentar);
            this.panel1.Controls.Add(this.numQuant);
            this.panel1.Controls.Add(this.lblQuant);
            this.panel1.Controls.Add(this.grpProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 248);
            this.panel1.TabIndex = 0;
            // 
            // grpItens
            // 
            this.grpItens.Controls.Add(this.lblTotal);
            this.grpItens.Controls.Add(this.btnCancelar);
            this.grpItens.Controls.Add(this.btnSalvar);
            this.grpItens.Controls.Add(this.lstItens);
            this.grpItens.Location = new System.Drawing.Point(179, 12);
            this.grpItens.Name = "grpItens";
            this.grpItens.Size = new System.Drawing.Size(371, 228);
            this.grpItens.TabIndex = 4;
            this.grpItens.TabStop = false;
            this.grpItens.Text = "Itens";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 200);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total: R$ ---";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(205, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(286, 195);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lstItens
            // 
            this.lstItens.FormattingEnabled = true;
            this.lstItens.Location = new System.Drawing.Point(6, 16);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(355, 173);
            this.lstItens.TabIndex = 0;
            // 
            // btnAcrescentar
            // 
            this.btnAcrescentar.Location = new System.Drawing.Point(87, 217);
            this.btnAcrescentar.Name = "btnAcrescentar";
            this.btnAcrescentar.Size = new System.Drawing.Size(86, 23);
            this.btnAcrescentar.TabIndex = 3;
            this.btnAcrescentar.Text = "Acrescentar";
            this.btnAcrescentar.UseVisualStyleBackColor = true;
            this.btnAcrescentar.Click += new System.EventHandler(this.btnAcrescentar_Click);
            // 
            // numQuant
            // 
            this.numQuant.Location = new System.Drawing.Point(87, 191);
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(86, 20);
            this.numQuant.TabIndex = 2;
            this.numQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(16, 193);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(65, 13);
            this.lblQuant.TabIndex = 1;
            this.lblQuant.Text = "Quantidade:";
            // 
            // grpProduto
            // 
            this.grpProduto.Controls.Add(this.lstProdutos);
            this.grpProduto.Controls.Add(this.txtNome);
            this.grpProduto.Controls.Add(this.txtCod);
            this.grpProduto.Controls.Add(this.lblNome);
            this.grpProduto.Controls.Add(this.lblCod);
            this.grpProduto.Location = new System.Drawing.Point(10, 12);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(163, 173);
            this.grpProduto.TabIndex = 0;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "Produto";
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(9, 67);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(141, 95);
            this.lstProdutos.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(50, 13);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 2;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 44);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(6, 16);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // CadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 248);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroItem";
            this.Text = "Cadastro de Item";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpItens.ResumeLayout(false);
            this.grpItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuant)).EndInit();
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.GroupBox grpItens;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.Button btnAcrescentar;
        private System.Windows.Forms.NumericUpDown numQuant;
        private System.Windows.Forms.Label lblTotal;
    }
}