namespace wfaSistemaDeVendas
{
    partial class Produto
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
            this.btn_VoltarProd = new System.Windows.Forms.Button();
            this.lbl_DescProd = new System.Windows.Forms.Label();
            this.lbl_CustoProd = new System.Windows.Forms.Label();
            this.lbl_VendaProd = new System.Windows.Forms.Label();
            this.lbl_AtivoProd = new System.Windows.Forms.Label();
            this.txt_DescProd = new System.Windows.Forms.TextBox();
            this.txt_CustoProd = new System.Windows.Forms.TextBox();
            this.txt_VendaProd = new System.Windows.Forms.TextBox();
            this.txt_AtivoProd = new System.Windows.Forms.TextBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.btn_InsereProd = new System.Windows.Forms.Button();
            this.btn_AtualizaProd = new System.Windows.Forms.Button();
            this.btn_ExcluiProd = new System.Windows.Forms.Button();
            this.btn_SalvarProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_VoltarProd
            // 
            this.btn_VoltarProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VoltarProd.Location = new System.Drawing.Point(12, 415);
            this.btn_VoltarProd.Name = "btn_VoltarProd";
            this.btn_VoltarProd.Size = new System.Drawing.Size(75, 23);
            this.btn_VoltarProd.TabIndex = 1;
            this.btn_VoltarProd.Text = "Voltar";
            this.btn_VoltarProd.UseVisualStyleBackColor = true;
            this.btn_VoltarProd.Click += new System.EventHandler(this.btn_VoltarProd_Click);
            // 
            // lbl_DescProd
            // 
            this.lbl_DescProd.AutoSize = true;
            this.lbl_DescProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescProd.Location = new System.Drawing.Point(37, 21);
            this.lbl_DescProd.Name = "lbl_DescProd";
            this.lbl_DescProd.Size = new System.Drawing.Size(128, 16);
            this.lbl_DescProd.TabIndex = 2;
            this.lbl_DescProd.Text = "Descrição do Produto:";
            // 
            // lbl_CustoProd
            // 
            this.lbl_CustoProd.AutoSize = true;
            this.lbl_CustoProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustoProd.Location = new System.Drawing.Point(71, 52);
            this.lbl_CustoProd.Name = "lbl_CustoProd";
            this.lbl_CustoProd.Size = new System.Drawing.Size(94, 16);
            this.lbl_CustoProd.TabIndex = 3;
            this.lbl_CustoProd.Text = "Preço de Custo:";
            // 
            // lbl_VendaProd
            // 
            this.lbl_VendaProd.AutoSize = true;
            this.lbl_VendaProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VendaProd.Location = new System.Drawing.Point(65, 82);
            this.lbl_VendaProd.Name = "lbl_VendaProd";
            this.lbl_VendaProd.Size = new System.Drawing.Size(100, 16);
            this.lbl_VendaProd.TabIndex = 4;
            this.lbl_VendaProd.Text = "Preço de Venda:";
            // 
            // lbl_AtivoProd
            // 
            this.lbl_AtivoProd.AutoSize = true;
            this.lbl_AtivoProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AtivoProd.Location = new System.Drawing.Point(126, 111);
            this.lbl_AtivoProd.Name = "lbl_AtivoProd";
            this.lbl_AtivoProd.Size = new System.Drawing.Size(39, 16);
            this.lbl_AtivoProd.TabIndex = 5;
            this.lbl_AtivoProd.Text = "Ativo:";
            // 
            // txt_DescProd
            // 
            this.txt_DescProd.Enabled = false;
            this.txt_DescProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescProd.Location = new System.Drawing.Point(171, 18);
            this.txt_DescProd.Name = "txt_DescProd";
            this.txt_DescProd.Size = new System.Drawing.Size(311, 21);
            this.txt_DescProd.TabIndex = 6;
            // 
            // txt_CustoProd
            // 
            this.txt_CustoProd.Enabled = false;
            this.txt_CustoProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustoProd.Location = new System.Drawing.Point(171, 47);
            this.txt_CustoProd.Name = "txt_CustoProd";
            this.txt_CustoProd.Size = new System.Drawing.Size(100, 21);
            this.txt_CustoProd.TabIndex = 7;
            // 
            // txt_VendaProd
            // 
            this.txt_VendaProd.Enabled = false;
            this.txt_VendaProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_VendaProd.Location = new System.Drawing.Point(171, 77);
            this.txt_VendaProd.Name = "txt_VendaProd";
            this.txt_VendaProd.Size = new System.Drawing.Size(100, 21);
            this.txt_VendaProd.TabIndex = 8;
            // 
            // txt_AtivoProd
            // 
            this.txt_AtivoProd.Enabled = false;
            this.txt_AtivoProd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AtivoProd.Location = new System.Drawing.Point(171, 106);
            this.txt_AtivoProd.Name = "txt_AtivoProd";
            this.txt_AtivoProd.Size = new System.Drawing.Size(46, 21);
            this.txt_AtivoProd.TabIndex = 9;
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.AllowUserToOrderColumns = true;
            this.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(54, 171);
            this.dgvProd.MultiSelect = false;
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(678, 224);
            this.dgvProd.TabIndex = 10;
            this.dgvProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellClick);
            // 
            // btn_InsereProd
            // 
            this.btn_InsereProd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_InsereProd.FlatAppearance.BorderSize = 2;
            this.btn_InsereProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_InsereProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InsereProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsereProd.Location = new System.Drawing.Point(386, 128);
            this.btn_InsereProd.Name = "btn_InsereProd";
            this.btn_InsereProd.Size = new System.Drawing.Size(82, 28);
            this.btn_InsereProd.TabIndex = 11;
            this.btn_InsereProd.Text = "Inserir";
            this.btn_InsereProd.UseVisualStyleBackColor = true;
            this.btn_InsereProd.Click += new System.EventHandler(this.btn_InsereProd_Click);
            // 
            // btn_AtualizaProd
            // 
            this.btn_AtualizaProd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_AtualizaProd.FlatAppearance.BorderSize = 2;
            this.btn_AtualizaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_AtualizaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtualizaProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AtualizaProd.Location = new System.Drawing.Point(474, 128);
            this.btn_AtualizaProd.Name = "btn_AtualizaProd";
            this.btn_AtualizaProd.Size = new System.Drawing.Size(82, 28);
            this.btn_AtualizaProd.TabIndex = 12;
            this.btn_AtualizaProd.Text = "Atualizar";
            this.btn_AtualizaProd.UseVisualStyleBackColor = true;
            this.btn_AtualizaProd.Click += new System.EventHandler(this.btn_AtualizaProd_Click);
            // 
            // btn_ExcluiProd
            // 
            this.btn_ExcluiProd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_ExcluiProd.FlatAppearance.BorderSize = 2;
            this.btn_ExcluiProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_ExcluiProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcluiProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluiProd.Location = new System.Drawing.Point(562, 128);
            this.btn_ExcluiProd.Name = "btn_ExcluiProd";
            this.btn_ExcluiProd.Size = new System.Drawing.Size(82, 28);
            this.btn_ExcluiProd.TabIndex = 13;
            this.btn_ExcluiProd.Text = "Excluir";
            this.btn_ExcluiProd.UseVisualStyleBackColor = true;
            this.btn_ExcluiProd.Click += new System.EventHandler(this.btn_ExcluiProd_Click);
            // 
            // btn_SalvarProd
            // 
            this.btn_SalvarProd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_SalvarProd.FlatAppearance.BorderSize = 2;
            this.btn_SalvarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_SalvarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalvarProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarProd.Location = new System.Drawing.Point(650, 128);
            this.btn_SalvarProd.Name = "btn_SalvarProd";
            this.btn_SalvarProd.Size = new System.Drawing.Size(82, 28);
            this.btn_SalvarProd.TabIndex = 14;
            this.btn_SalvarProd.Text = "Salvar";
            this.btn_SalvarProd.UseVisualStyleBackColor = true;
            this.btn_SalvarProd.Click += new System.EventHandler(this.btn_SalvarProd_Click);
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SalvarProd);
            this.Controls.Add(this.btn_ExcluiProd);
            this.Controls.Add(this.btn_AtualizaProd);
            this.Controls.Add(this.btn_InsereProd);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.txt_AtivoProd);
            this.Controls.Add(this.txt_VendaProd);
            this.Controls.Add(this.txt_CustoProd);
            this.Controls.Add(this.txt_DescProd);
            this.Controls.Add(this.lbl_AtivoProd);
            this.Controls.Add(this.lbl_VendaProd);
            this.Controls.Add(this.lbl_CustoProd);
            this.Controls.Add(this.lbl_DescProd);
            this.Controls.Add(this.btn_VoltarProd);
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VoltarProd;
        private System.Windows.Forms.Label lbl_DescProd;
        private System.Windows.Forms.Label lbl_CustoProd;
        private System.Windows.Forms.Label lbl_VendaProd;
        private System.Windows.Forms.Label lbl_AtivoProd;
        private System.Windows.Forms.TextBox txt_DescProd;
        private System.Windows.Forms.TextBox txt_CustoProd;
        private System.Windows.Forms.TextBox txt_VendaProd;
        private System.Windows.Forms.TextBox txt_AtivoProd;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Button btn_InsereProd;
        private System.Windows.Forms.Button btn_AtualizaProd;
        private System.Windows.Forms.Button btn_ExcluiProd;
        private System.Windows.Forms.Button btn_SalvarProd;
    }
}