namespace BakerCommerce
{
    partial class FormProdutos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbCategoriaCadastro = new System.Windows.Forms.ComboBox();
            this.lblCategoriaCadastro = new System.Windows.Forms.Label();
            this.txbPrecoCadastrar = new System.Windows.Forms.TextBox();
            this.txbNomeCadastrar = new System.Windows.Forms.TextBox();
            this.lblPrecoCadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnCadastrarEditar = new System.Windows.Forms.Button();
            this.cmbCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.lblCadastroEditar = new System.Windows.Forms.Label();
            this.txbPrecoEditar = new System.Windows.Forms.TextBox();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(45, 88);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(733, 267);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.cmbCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.lblCategoriaCadastro);
            this.grbCadastrar.Controls.Add(this.txbPrecoCadastrar);
            this.grbCadastrar.Controls.Add(this.txbNomeCadastrar);
            this.grbCadastrar.Controls.Add(this.lblPrecoCadastro);
            this.grbCadastrar.Controls.Add(this.label1);
            this.grbCadastrar.Controls.Add(this.lblNomeCadastro);
            this.grbCadastrar.Location = new System.Drawing.Point(45, 371);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(344, 225);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(81, 157);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(175, 61);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbCategoriaCadastro
            // 
            this.cmbCategoriaCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaCadastro.FormattingEnabled = true;
            this.cmbCategoriaCadastro.Location = new System.Drawing.Point(81, 121);
            this.cmbCategoriaCadastro.Name = "cmbCategoriaCadastro";
            this.cmbCategoriaCadastro.Size = new System.Drawing.Size(172, 21);
            this.cmbCategoriaCadastro.TabIndex = 6;
            // 
            // lblCategoriaCadastro
            // 
            this.lblCategoriaCadastro.AutoSize = true;
            this.lblCategoriaCadastro.Location = new System.Drawing.Point(10, 121);
            this.lblCategoriaCadastro.Name = "lblCategoriaCadastro";
            this.lblCategoriaCadastro.Size = new System.Drawing.Size(52, 13);
            this.lblCategoriaCadastro.TabIndex = 5;
            this.lblCategoriaCadastro.Text = "Cadastro:";
            // 
            // txbPrecoCadastrar
            // 
            this.txbPrecoCadastrar.Location = new System.Drawing.Point(81, 84);
            this.txbPrecoCadastrar.Name = "txbPrecoCadastrar";
            this.txbPrecoCadastrar.Size = new System.Drawing.Size(175, 20);
            this.txbPrecoCadastrar.TabIndex = 4;
            // 
            // txbNomeCadastrar
            // 
            this.txbNomeCadastrar.Location = new System.Drawing.Point(78, 48);
            this.txbNomeCadastrar.Name = "txbNomeCadastrar";
            this.txbNomeCadastrar.Size = new System.Drawing.Size(175, 20);
            this.txbNomeCadastrar.TabIndex = 3;
            // 
            // lblPrecoCadastro
            // 
            this.lblPrecoCadastro.AutoSize = true;
            this.lblPrecoCadastro.Location = new System.Drawing.Point(22, 87);
            this.lblPrecoCadastro.Name = "lblPrecoCadastro";
            this.lblPrecoCadastro.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoCadastro.TabIndex = 2;
            this.lblPrecoCadastro.Text = "Preço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(22, 51);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Nome:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnCadastrarEditar);
            this.grbEditar.Controls.Add(this.cmbCategoriaEditar);
            this.grbEditar.Controls.Add(this.lblCadastroEditar);
            this.grbEditar.Controls.Add(this.txbPrecoEditar);
            this.grbEditar.Controls.Add(this.txbNomeEditar);
            this.grbEditar.Controls.Add(this.lblPrecoEditar);
            this.grbEditar.Controls.Add(this.label4);
            this.grbEditar.Controls.Add(this.lblNomeEditar);
            this.grbEditar.Location = new System.Drawing.Point(432, 371);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(346, 225);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnCadastrarEditar
            // 
            this.btnCadastrarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEditar.Location = new System.Drawing.Point(81, 157);
            this.btnCadastrarEditar.Name = "btnCadastrarEditar";
            this.btnCadastrarEditar.Size = new System.Drawing.Size(175, 61);
            this.btnCadastrarEditar.TabIndex = 2;
            this.btnCadastrarEditar.Text = "Editar";
            this.btnCadastrarEditar.UseVisualStyleBackColor = true;
            this.btnCadastrarEditar.Click += new System.EventHandler(this.btnCadastrarEditar_Click);
            // 
            // cmbCategoriaEditar
            // 
            this.cmbCategoriaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEditar.FormattingEnabled = true;
            this.cmbCategoriaEditar.Location = new System.Drawing.Point(81, 121);
            this.cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            this.cmbCategoriaEditar.Size = new System.Drawing.Size(172, 21);
            this.cmbCategoriaEditar.TabIndex = 6;
            // 
            // lblCadastroEditar
            // 
            this.lblCadastroEditar.AutoSize = true;
            this.lblCadastroEditar.Location = new System.Drawing.Point(10, 121);
            this.lblCadastroEditar.Name = "lblCadastroEditar";
            this.lblCadastroEditar.Size = new System.Drawing.Size(52, 13);
            this.lblCadastroEditar.TabIndex = 5;
            this.lblCadastroEditar.Text = "Cadastro:";
            // 
            // txbPrecoEditar
            // 
            this.txbPrecoEditar.Location = new System.Drawing.Point(81, 84);
            this.txbPrecoEditar.Name = "txbPrecoEditar";
            this.txbPrecoEditar.Size = new System.Drawing.Size(175, 20);
            this.txbPrecoEditar.TabIndex = 4;
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(78, 48);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(175, 20);
            this.txbNomeEditar.TabIndex = 3;
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(22, 87);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoEditar.TabIndex = 2;
            this.lblPrecoEditar.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 1;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(22, 51);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(38, 13);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Location = new System.Drawing.Point(45, 602);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(733, 106);
            this.grbApagar.TabIndex = 3;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnApagar.Location = new System.Drawing.Point(403, 31);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(292, 59);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Location = new System.Drawing.Point(25, 50);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(173, 13);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione um produto para apagar.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Dutch801 XBd BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(79, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(427, 39);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Gerenciamento de Produtos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BakerCommerce.Properties.Resources.box1;
            this.pictureBox1.Location = new System.Drawing.Point(513, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 719);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.ComboBox cmbCategoriaCadastro;
        private System.Windows.Forms.Label lblCategoriaCadastro;
        private System.Windows.Forms.TextBox txbPrecoCadastrar;
        private System.Windows.Forms.TextBox txbNomeCadastrar;
        private System.Windows.Forms.Label lblPrecoCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnCadastrarEditar;
        private System.Windows.Forms.ComboBox cmbCategoriaEditar;
        private System.Windows.Forms.Label lblCadastroEditar;
        private System.Windows.Forms.TextBox txbPrecoEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}