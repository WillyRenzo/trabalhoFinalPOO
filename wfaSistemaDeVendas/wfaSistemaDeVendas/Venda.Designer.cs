namespace wfaSistemaDeVendas
{
    partial class Venda
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
            this.btn_VoltarVenda = new System.Windows.Forms.Button();
            this.lbl_IDCliPed = new System.Windows.Forms.Label();
            this.lbl_ValorPed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPed = new System.Windows.Forms.DataGridView();
            this.txt_IDCliPed = new System.Windows.Forms.TextBox();
            this.txt_ValorPed = new System.Windows.Forms.TextBox();
            this.btn_InserePed = new System.Windows.Forms.Button();
            this.btn_AtualizaPed = new System.Windows.Forms.Button();
            this.btn_ExcluiPed = new System.Windows.Forms.Button();
            this.btn_SalvaPed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPed)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_VoltarVenda
            // 
            this.btn_VoltarVenda.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VoltarVenda.Location = new System.Drawing.Point(19, 238);
            this.btn_VoltarVenda.Name = "btn_VoltarVenda";
            this.btn_VoltarVenda.Size = new System.Drawing.Size(75, 23);
            this.btn_VoltarVenda.TabIndex = 1;
            this.btn_VoltarVenda.Text = "Voltar";
            this.btn_VoltarVenda.UseVisualStyleBackColor = true;
            this.btn_VoltarVenda.Click += new System.EventHandler(this.btn_VoltarVenda_Click);
            // 
            // lbl_IDCliPed
            // 
            this.lbl_IDCliPed.AutoSize = true;
            this.lbl_IDCliPed.Location = new System.Drawing.Point(56, 12);
            this.lbl_IDCliPed.Name = "lbl_IDCliPed";
            this.lbl_IDCliPed.Size = new System.Drawing.Size(71, 13);
            this.lbl_IDCliPed.TabIndex = 2;
            this.lbl_IDCliPed.Text = "ID do Cliente:";
            // 
            // lbl_ValorPed
            // 
            this.lbl_ValorPed.AutoSize = true;
            this.lbl_ValorPed.Location = new System.Drawing.Point(16, 37);
            this.lbl_ValorPed.Name = "lbl_ValorPed";
            this.lbl_ValorPed.Size = new System.Drawing.Size(112, 13);
            this.lbl_ValorPed.TabIndex = 3;
            this.lbl_ValorPed.Text = "Valor Total do Pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // dgvPed
            // 
            this.dgvPed.AllowUserToAddRows = false;
            this.dgvPed.AllowUserToDeleteRows = false;
            this.dgvPed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPed.Location = new System.Drawing.Point(19, 65);
            this.dgvPed.MultiSelect = false;
            this.dgvPed.Name = "dgvPed";
            this.dgvPed.ReadOnly = true;
            this.dgvPed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPed.Size = new System.Drawing.Size(638, 167);
            this.dgvPed.TabIndex = 5;
            this.dgvPed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPed_CellClick);
            // 
            // txt_IDCliPed
            // 
            this.txt_IDCliPed.Enabled = false;
            this.txt_IDCliPed.Location = new System.Drawing.Point(133, 9);
            this.txt_IDCliPed.Name = "txt_IDCliPed";
            this.txt_IDCliPed.Size = new System.Drawing.Size(71, 20);
            this.txt_IDCliPed.TabIndex = 1;
            // 
            // txt_ValorPed
            // 
            this.txt_ValorPed.Enabled = false;
            this.txt_ValorPed.Location = new System.Drawing.Point(133, 34);
            this.txt_ValorPed.Name = "txt_ValorPed";
            this.txt_ValorPed.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorPed.TabIndex = 2;
            // 
            // btn_InserePed
            // 
            this.btn_InserePed.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_InserePed.FlatAppearance.BorderSize = 2;
            this.btn_InserePed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_InserePed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InserePed.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InserePed.Location = new System.Drawing.Point(329, 26);
            this.btn_InserePed.Name = "btn_InserePed";
            this.btn_InserePed.Size = new System.Drawing.Size(75, 28);
            this.btn_InserePed.TabIndex = 3;
            this.btn_InserePed.Text = "Inserir";
            this.btn_InserePed.UseVisualStyleBackColor = true;
            this.btn_InserePed.Click += new System.EventHandler(this.btn_InserePed_Click);
            // 
            // btn_AtualizaPed
            // 
            this.btn_AtualizaPed.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_AtualizaPed.FlatAppearance.BorderSize = 2;
            this.btn_AtualizaPed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_AtualizaPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtualizaPed.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AtualizaPed.Location = new System.Drawing.Point(410, 26);
            this.btn_AtualizaPed.Name = "btn_AtualizaPed";
            this.btn_AtualizaPed.Size = new System.Drawing.Size(75, 28);
            this.btn_AtualizaPed.TabIndex = 4;
            this.btn_AtualizaPed.Text = "Atualizar";
            this.btn_AtualizaPed.UseVisualStyleBackColor = true;
            this.btn_AtualizaPed.Click += new System.EventHandler(this.btn_AtualizaPed_Click);
            // 
            // btn_ExcluiPed
            // 
            this.btn_ExcluiPed.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_ExcluiPed.FlatAppearance.BorderSize = 2;
            this.btn_ExcluiPed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_ExcluiPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcluiPed.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluiPed.Location = new System.Drawing.Point(491, 26);
            this.btn_ExcluiPed.Name = "btn_ExcluiPed";
            this.btn_ExcluiPed.Size = new System.Drawing.Size(75, 28);
            this.btn_ExcluiPed.TabIndex = 5;
            this.btn_ExcluiPed.Text = "Excluir";
            this.btn_ExcluiPed.UseVisualStyleBackColor = true;
            this.btn_ExcluiPed.Click += new System.EventHandler(this.btn_ExcluiPed_Click);
            // 
            // btn_SalvaPed
            // 
            this.btn_SalvaPed.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_SalvaPed.FlatAppearance.BorderSize = 2;
            this.btn_SalvaPed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_SalvaPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalvaPed.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvaPed.Location = new System.Drawing.Point(572, 26);
            this.btn_SalvaPed.Name = "btn_SalvaPed";
            this.btn_SalvaPed.Size = new System.Drawing.Size(75, 28);
            this.btn_SalvaPed.TabIndex = 6;
            this.btn_SalvaPed.Text = "Salvar";
            this.btn_SalvaPed.UseVisualStyleBackColor = true;
            this.btn_SalvaPed.Click += new System.EventHandler(this.btn_SalvaPed_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 273);
            this.Controls.Add(this.btn_SalvaPed);
            this.Controls.Add(this.btn_ExcluiPed);
            this.Controls.Add(this.btn_AtualizaPed);
            this.Controls.Add(this.btn_InserePed);
            this.Controls.Add(this.txt_ValorPed);
            this.Controls.Add(this.txt_IDCliPed);
            this.Controls.Add(this.dgvPed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ValorPed);
            this.Controls.Add(this.lbl_IDCliPed);
            this.Controls.Add(this.btn_VoltarVenda);
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VoltarVenda;
        private System.Windows.Forms.Label lbl_IDCliPed;
        private System.Windows.Forms.Label lbl_ValorPed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPed;
        private System.Windows.Forms.TextBox txt_IDCliPed;
        private System.Windows.Forms.TextBox txt_ValorPed;
        private System.Windows.Forms.Button btn_InserePed;
        private System.Windows.Forms.Button btn_AtualizaPed;
        private System.Windows.Forms.Button btn_ExcluiPed;
        private System.Windows.Forms.Button btn_SalvaPed;
    }
}