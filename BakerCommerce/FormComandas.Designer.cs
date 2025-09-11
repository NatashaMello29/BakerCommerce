namespace BakerCommerce
{
    partial class FormComandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComandas));
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.grbInformacoesComandas = new System.Windows.Forms.GroupBox();
            this.lblTituloComandas = new System.Windows.Forms.Label();
            this.pibComanadas = new System.Windows.Forms.PictureBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.lblCodComanda = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.btnContinuarComanda = new System.Windows.Forms.Button();
            this.grbLancamentoComanda = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.lblQuantidadeComanda = new System.Windows.Forms.Label();
            this.lblProdutoComanda = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.grbInformacoesComandas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibComanadas)).BeginInit();
            this.grbLancamentoComanda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComandas
            // 
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(368, 95);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(452, 557);
            this.dgvComandas.TabIndex = 0;
            this.dgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellClick);
            // 
            // grbInformacoesComandas
            // 
            this.grbInformacoesComandas.Controls.Add(this.btnContinuarComanda);
            this.grbInformacoesComandas.Controls.Add(this.txbCodProduto);
            this.grbInformacoesComandas.Controls.Add(this.txbComanda);
            this.grbInformacoesComandas.Controls.Add(this.lblCodComanda);
            this.grbInformacoesComandas.Controls.Add(this.lblComanda);
            this.grbInformacoesComandas.Location = new System.Drawing.Point(12, 95);
            this.grbInformacoesComandas.Name = "grbInformacoesComandas";
            this.grbInformacoesComandas.Size = new System.Drawing.Size(350, 242);
            this.grbInformacoesComandas.TabIndex = 1;
            this.grbInformacoesComandas.TabStop = false;
            this.grbInformacoesComandas.Text = "Informações";
            // 
            // lblTituloComandas
            // 
            this.lblTituloComandas.AutoSize = true;
            this.lblTituloComandas.Font = new System.Drawing.Font("News706 BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloComandas.Location = new System.Drawing.Point(6, 24);
            this.lblTituloComandas.Name = "lblTituloComandas";
            this.lblTituloComandas.Size = new System.Drawing.Size(597, 35);
            this.lblTituloComandas.TabIndex = 2;
            this.lblTituloComandas.Text = "Lançamento Comandas Baker Commerce";
            // 
            // pibComanadas
            // 
            this.pibComanadas.Image = global::BakerCommerce.Properties.Resources.clipboard;
            this.pibComanadas.Location = new System.Drawing.Point(609, 12);
            this.pibComanadas.Name = "pibComanadas";
            this.pibComanadas.Size = new System.Drawing.Size(155, 77);
            this.pibComanadas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibComanadas.TabIndex = 3;
            this.pibComanadas.TabStop = false;
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(6, 39);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(146, 32);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda:";
            // 
            // lblCodComanda
            // 
            this.lblCodComanda.AutoSize = true;
            this.lblCodComanda.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblCodComanda.Location = new System.Drawing.Point(6, 105);
            this.lblCodComanda.Name = "lblCodComanda";
            this.lblCodComanda.Size = new System.Drawing.Size(195, 32);
            this.lblCodComanda.TabIndex = 1;
            this.lblCodComanda.Text = "Cod. Produto:";
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(207, 33);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(100, 38);
            this.txbComanda.TabIndex = 2;
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodProduto.Location = new System.Drawing.Point(207, 99);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(100, 38);
            this.txbCodProduto.TabIndex = 3;
            // 
            // btnContinuarComanda
            // 
            this.btnContinuarComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(148)))), ((int)(((byte)(72)))));
            this.btnContinuarComanda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnContinuarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuarComanda.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarComanda.Location = new System.Drawing.Point(52, 157);
            this.btnContinuarComanda.Name = "btnContinuarComanda";
            this.btnContinuarComanda.Size = new System.Drawing.Size(238, 66);
            this.btnContinuarComanda.TabIndex = 4;
            this.btnContinuarComanda.Text = "Continuar";
            this.btnContinuarComanda.UseVisualStyleBackColor = false;
            this.btnContinuarComanda.Click += new System.EventHandler(this.btnContinuarComanda_Click);
            // 
            // grbLancamentoComanda
            // 
            this.grbLancamentoComanda.Controls.Add(this.btnCancelar);
            this.grbLancamentoComanda.Controls.Add(this.btnLancar);
            this.grbLancamentoComanda.Controls.Add(this.txbQuantidade);
            this.grbLancamentoComanda.Controls.Add(this.txbProduto);
            this.grbLancamentoComanda.Controls.Add(this.lblQuantidadeComanda);
            this.grbLancamentoComanda.Controls.Add(this.lblProdutoComanda);
            this.grbLancamentoComanda.Enabled = false;
            this.grbLancamentoComanda.Location = new System.Drawing.Point(12, 396);
            this.grbLancamentoComanda.Name = "grbLancamentoComanda";
            this.grbLancamentoComanda.Size = new System.Drawing.Size(350, 323);
            this.grbLancamentoComanda.TabIndex = 4;
            this.grbLancamentoComanda.TabStop = false;
            this.grbLancamentoComanda.Text = "Lançamento";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(148)))), ((int)(((byte)(72)))));
            this.btnLancar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLancar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(52, 159);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(238, 66);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(207, 99);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(100, 38);
            this.txbQuantidade.TabIndex = 3;
            // 
            // txbProduto
            // 
            this.txbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProduto.Location = new System.Drawing.Point(207, 33);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.ReadOnly = true;
            this.txbProduto.Size = new System.Drawing.Size(100, 38);
            this.txbProduto.TabIndex = 2;
            // 
            // lblQuantidadeComanda
            // 
            this.lblQuantidadeComanda.AutoSize = true;
            this.lblQuantidadeComanda.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblQuantidadeComanda.Location = new System.Drawing.Point(6, 105);
            this.lblQuantidadeComanda.Name = "lblQuantidadeComanda";
            this.lblQuantidadeComanda.Size = new System.Drawing.Size(175, 32);
            this.lblQuantidadeComanda.TabIndex = 1;
            this.lblQuantidadeComanda.Text = "Quantidade:";
            // 
            // lblProdutoComanda
            // 
            this.lblProdutoComanda.AutoSize = true;
            this.lblProdutoComanda.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoComanda.Location = new System.Drawing.Point(6, 39);
            this.lblProdutoComanda.Name = "lblProdutoComanda";
            this.lblProdutoComanda.Size = new System.Drawing.Size(129, 32);
            this.lblProdutoComanda.TabIndex = 0;
            this.lblProdutoComanda.Text = "Produto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(55)))), ((int)(((byte)(34)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(52, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(238, 66);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 759);
            this.Controls.Add(this.grbLancamentoComanda);
            this.Controls.Add(this.pibComanadas);
            this.Controls.Add(this.lblTituloComandas);
            this.Controls.Add(this.grbInformacoesComandas);
            this.Controls.Add(this.dgvComandas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comandas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.grbInformacoesComandas.ResumeLayout(false);
            this.grbInformacoesComandas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibComanadas)).EndInit();
            this.grbLancamentoComanda.ResumeLayout(false);
            this.grbLancamentoComanda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.GroupBox grbInformacoesComandas;
        private System.Windows.Forms.Label lblTituloComandas;
        private System.Windows.Forms.PictureBox pibComanadas;
        private System.Windows.Forms.Label lblCodComanda;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.Button btnContinuarComanda;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.GroupBox grbLancamentoComanda;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Label lblQuantidadeComanda;
        private System.Windows.Forms.Label lblProdutoComanda;
        private System.Windows.Forms.Button btnCancelar;
    }
}