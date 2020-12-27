namespace wfaSistemaDeVendas
{
    partial class Cliente
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
            this.btn_VoltarCli = new System.Windows.Forms.Button();
            this.lbl_NomeCli = new System.Windows.Forms.Label();
            this.lbl_SobrenomeCli = new System.Windows.Forms.Label();
            this.lbl_EnderecoCli = new System.Windows.Forms.Label();
            this.lbl_NumeroCli = new System.Windows.Forms.Label();
            this.lbl_ComplementoCli = new System.Windows.Forms.Label();
            this.lbl_CidadeCli = new System.Windows.Forms.Label();
            this.lbl_EstadoCli = new System.Windows.Forms.Label();
            this.lbl_AtivoCli = new System.Windows.Forms.Label();
            this.txt_NomeCli = new System.Windows.Forms.TextBox();
            this.txt_SobrenomeCli = new System.Windows.Forms.TextBox();
            this.txt_EnderecoCli = new System.Windows.Forms.TextBox();
            this.txt_NumeroCli = new System.Windows.Forms.TextBox();
            this.txt_ComplementoCli = new System.Windows.Forms.TextBox();
            this.txt_CidadeCli = new System.Windows.Forms.TextBox();
            this.txt_EstadoCli = new System.Windows.Forms.TextBox();
            this.txt_AtivoCli = new System.Windows.Forms.TextBox();
            this.btn_InsereCli = new System.Windows.Forms.Button();
            this.btn_AtualizaCli = new System.Windows.Forms.Button();
            this.btn_ExcluiCli = new System.Windows.Forms.Button();
            this.btn_SalvarCli = new System.Windows.Forms.Button();
            this.lbl_CEPCli = new System.Windows.Forms.Label();
            this.txt_CEPCli = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_VoltarCli
            // 
            this.btn_VoltarCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VoltarCli.Location = new System.Drawing.Point(14, 511);
            this.btn_VoltarCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_VoltarCli.Name = "btn_VoltarCli";
            this.btn_VoltarCli.Size = new System.Drawing.Size(87, 28);
            this.btn_VoltarCli.TabIndex = 0;
            this.btn_VoltarCli.Text = "Voltar";
            this.btn_VoltarCli.UseVisualStyleBackColor = true;
            this.btn_VoltarCli.Click += new System.EventHandler(this.btn_VoltarCli_Click);
            // 
            // lbl_NomeCli
            // 
            this.lbl_NomeCli.AutoSize = true;
            this.lbl_NomeCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeCli.Location = new System.Drawing.Point(64, 27);
            this.lbl_NomeCli.Name = "lbl_NomeCli";
            this.lbl_NomeCli.Size = new System.Drawing.Size(46, 16);
            this.lbl_NomeCli.TabIndex = 1;
            this.lbl_NomeCli.Text = "Nome: ";
            // 
            // lbl_SobrenomeCli
            // 
            this.lbl_SobrenomeCli.AutoSize = true;
            this.lbl_SobrenomeCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SobrenomeCli.Location = new System.Drawing.Point(37, 54);
            this.lbl_SobrenomeCli.Name = "lbl_SobrenomeCli";
            this.lbl_SobrenomeCli.Size = new System.Drawing.Size(73, 16);
            this.lbl_SobrenomeCli.TabIndex = 2;
            this.lbl_SobrenomeCli.Text = "Sobrenome:";
            // 
            // lbl_EnderecoCli
            // 
            this.lbl_EnderecoCli.AutoSize = true;
            this.lbl_EnderecoCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnderecoCli.Location = new System.Drawing.Point(43, 84);
            this.lbl_EnderecoCli.Name = "lbl_EnderecoCli";
            this.lbl_EnderecoCli.Size = new System.Drawing.Size(66, 16);
            this.lbl_EnderecoCli.TabIndex = 3;
            this.lbl_EnderecoCli.Text = "Endereço: ";
            // 
            // lbl_NumeroCli
            // 
            this.lbl_NumeroCli.AutoSize = true;
            this.lbl_NumeroCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroCli.Location = new System.Drawing.Point(51, 112);
            this.lbl_NumeroCli.Name = "lbl_NumeroCli";
            this.lbl_NumeroCli.Size = new System.Drawing.Size(53, 16);
            this.lbl_NumeroCli.TabIndex = 4;
            this.lbl_NumeroCli.Text = "Número:";
            // 
            // lbl_ComplementoCli
            // 
            this.lbl_ComplementoCli.AutoSize = true;
            this.lbl_ComplementoCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ComplementoCli.Location = new System.Drawing.Point(15, 140);
            this.lbl_ComplementoCli.Name = "lbl_ComplementoCli";
            this.lbl_ComplementoCli.Size = new System.Drawing.Size(89, 16);
            this.lbl_ComplementoCli.TabIndex = 5;
            this.lbl_ComplementoCli.Text = "Complemento:";
            // 
            // lbl_CidadeCli
            // 
            this.lbl_CidadeCli.AutoSize = true;
            this.lbl_CidadeCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CidadeCli.Location = new System.Drawing.Point(51, 197);
            this.lbl_CidadeCli.Name = "lbl_CidadeCli";
            this.lbl_CidadeCli.Size = new System.Drawing.Size(53, 16);
            this.lbl_CidadeCli.TabIndex = 6;
            this.lbl_CidadeCli.Text = "Cidade:";
            // 
            // lbl_EstadoCli
            // 
            this.lbl_EstadoCli.AutoSize = true;
            this.lbl_EstadoCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstadoCli.Location = new System.Drawing.Point(57, 224);
            this.lbl_EstadoCli.Name = "lbl_EstadoCli";
            this.lbl_EstadoCli.Size = new System.Drawing.Size(48, 16);
            this.lbl_EstadoCli.TabIndex = 7;
            this.lbl_EstadoCli.Text = "Estado:";
            // 
            // lbl_AtivoCli
            // 
            this.lbl_AtivoCli.AutoSize = true;
            this.lbl_AtivoCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AtivoCli.Location = new System.Drawing.Point(66, 251);
            this.lbl_AtivoCli.Name = "lbl_AtivoCli";
            this.lbl_AtivoCli.Size = new System.Drawing.Size(39, 16);
            this.lbl_AtivoCli.TabIndex = 8;
            this.lbl_AtivoCli.Text = "Ativo:";
            // 
            // txt_NomeCli
            // 
            this.txt_NomeCli.Enabled = false;
            this.txt_NomeCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeCli.Location = new System.Drawing.Point(119, 17);
            this.txt_NomeCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NomeCli.Name = "txt_NomeCli";
            this.txt_NomeCli.Size = new System.Drawing.Size(329, 21);
            this.txt_NomeCli.TabIndex = 1;
            // 
            // txt_SobrenomeCli
            // 
            this.txt_SobrenomeCli.Enabled = false;
            this.txt_SobrenomeCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SobrenomeCli.Location = new System.Drawing.Point(119, 49);
            this.txt_SobrenomeCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SobrenomeCli.Name = "txt_SobrenomeCli";
            this.txt_SobrenomeCli.Size = new System.Drawing.Size(297, 21);
            this.txt_SobrenomeCli.TabIndex = 2;
            // 
            // txt_EnderecoCli
            // 
            this.txt_EnderecoCli.Enabled = false;
            this.txt_EnderecoCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EnderecoCli.Location = new System.Drawing.Point(119, 79);
            this.txt_EnderecoCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_EnderecoCli.Name = "txt_EnderecoCli";
            this.txt_EnderecoCli.Size = new System.Drawing.Size(307, 21);
            this.txt_EnderecoCli.TabIndex = 3;
            // 
            // txt_NumeroCli
            // 
            this.txt_NumeroCli.Enabled = false;
            this.txt_NumeroCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumeroCli.Location = new System.Drawing.Point(119, 107);
            this.txt_NumeroCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NumeroCli.Name = "txt_NumeroCli";
            this.txt_NumeroCli.Size = new System.Drawing.Size(74, 21);
            this.txt_NumeroCli.TabIndex = 4;
            // 
            // txt_ComplementoCli
            // 
            this.txt_ComplementoCli.Enabled = false;
            this.txt_ComplementoCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ComplementoCli.Location = new System.Drawing.Point(119, 135);
            this.txt_ComplementoCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ComplementoCli.Name = "txt_ComplementoCli";
            this.txt_ComplementoCli.Size = new System.Drawing.Size(279, 21);
            this.txt_ComplementoCli.TabIndex = 5;
            // 
            // txt_CidadeCli
            // 
            this.txt_CidadeCli.Enabled = false;
            this.txt_CidadeCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CidadeCli.Location = new System.Drawing.Point(119, 192);
            this.txt_CidadeCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CidadeCli.Name = "txt_CidadeCli";
            this.txt_CidadeCli.Size = new System.Drawing.Size(146, 21);
            this.txt_CidadeCli.TabIndex = 7;
            // 
            // txt_EstadoCli
            // 
            this.txt_EstadoCli.Enabled = false;
            this.txt_EstadoCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EstadoCli.Location = new System.Drawing.Point(119, 219);
            this.txt_EstadoCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_EstadoCli.Name = "txt_EstadoCli";
            this.txt_EstadoCli.Size = new System.Drawing.Size(116, 21);
            this.txt_EstadoCli.TabIndex = 8;
            // 
            // txt_AtivoCli
            // 
            this.txt_AtivoCli.Enabled = false;
            this.txt_AtivoCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AtivoCli.Location = new System.Drawing.Point(119, 246);
            this.txt_AtivoCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AtivoCli.Name = "txt_AtivoCli";
            this.txt_AtivoCli.Size = new System.Drawing.Size(130, 21);
            this.txt_AtivoCli.TabIndex = 9;
            // 
            // btn_InsereCli
            // 
            this.btn_InsereCli.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_InsereCli.FlatAppearance.BorderSize = 2;
            this.btn_InsereCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_InsereCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InsereCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsereCli.ForeColor = System.Drawing.Color.Black;
            this.btn_InsereCli.Location = new System.Drawing.Point(495, 229);
            this.btn_InsereCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_InsereCli.Name = "btn_InsereCli";
            this.btn_InsereCli.Size = new System.Drawing.Size(97, 38);
            this.btn_InsereCli.TabIndex = 10;
            this.btn_InsereCli.Text = "Inserir";
            this.btn_InsereCli.UseVisualStyleBackColor = true;
            this.btn_InsereCli.Click += new System.EventHandler(this.btn_InsereCli_Click);
            // 
            // btn_AtualizaCli
            // 
            this.btn_AtualizaCli.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_AtualizaCli.FlatAppearance.BorderSize = 2;
            this.btn_AtualizaCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_AtualizaCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AtualizaCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AtualizaCli.Location = new System.Drawing.Point(598, 229);
            this.btn_AtualizaCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AtualizaCli.Name = "btn_AtualizaCli";
            this.btn_AtualizaCli.Size = new System.Drawing.Size(99, 38);
            this.btn_AtualizaCli.TabIndex = 11;
            this.btn_AtualizaCli.Text = "Atualizar";
            this.btn_AtualizaCli.UseVisualStyleBackColor = true;
            this.btn_AtualizaCli.Click += new System.EventHandler(this.btn_AtualizaCli_Click);
            // 
            // btn_ExcluiCli
            // 
            this.btn_ExcluiCli.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_ExcluiCli.FlatAppearance.BorderSize = 2;
            this.btn_ExcluiCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_ExcluiCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcluiCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluiCli.Location = new System.Drawing.Point(705, 229);
            this.btn_ExcluiCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ExcluiCli.Name = "btn_ExcluiCli";
            this.btn_ExcluiCli.Size = new System.Drawing.Size(87, 38);
            this.btn_ExcluiCli.TabIndex = 12;
            this.btn_ExcluiCli.Text = "Excluir";
            this.btn_ExcluiCli.UseVisualStyleBackColor = true;
            this.btn_ExcluiCli.Click += new System.EventHandler(this.btn_ExcluiCli_Click);
            // 
            // btn_SalvarCli
            // 
            this.btn_SalvarCli.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_SalvarCli.FlatAppearance.BorderSize = 2;
            this.btn_SalvarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_SalvarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalvarCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarCli.Location = new System.Drawing.Point(799, 229);
            this.btn_SalvarCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SalvarCli.Name = "btn_SalvarCli";
            this.btn_SalvarCli.Size = new System.Drawing.Size(87, 38);
            this.btn_SalvarCli.TabIndex = 13;
            this.btn_SalvarCli.Text = "Salvar";
            this.btn_SalvarCli.UseVisualStyleBackColor = true;
            this.btn_SalvarCli.Click += new System.EventHandler(this.btn_SalvarCli_Click);
            // 
            // lbl_CEPCli
            // 
            this.lbl_CEPCli.AutoSize = true;
            this.lbl_CEPCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CEPCli.Location = new System.Drawing.Point(72, 170);
            this.lbl_CEPCli.Name = "lbl_CEPCli";
            this.lbl_CEPCli.Size = new System.Drawing.Size(33, 16);
            this.lbl_CEPCli.TabIndex = 22;
            this.lbl_CEPCli.Text = "CEP:";
            // 
            // txt_CEPCli
            // 
            this.txt_CEPCli.Enabled = false;
            this.txt_CEPCli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CEPCli.Location = new System.Drawing.Point(119, 165);
            this.txt_CEPCli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CEPCli.Name = "txt_CEPCli";
            this.txt_CEPCli.Size = new System.Drawing.Size(160, 21);
            this.txt_CEPCli.TabIndex = 6;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(29, 289);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(857, 214);
            this.dgvCliente.TabIndex = 23;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txt_CEPCli);
            this.Controls.Add(this.lbl_CEPCli);
            this.Controls.Add(this.btn_SalvarCli);
            this.Controls.Add(this.btn_ExcluiCli);
            this.Controls.Add(this.btn_AtualizaCli);
            this.Controls.Add(this.btn_InsereCli);
            this.Controls.Add(this.txt_AtivoCli);
            this.Controls.Add(this.txt_EstadoCli);
            this.Controls.Add(this.txt_CidadeCli);
            this.Controls.Add(this.txt_ComplementoCli);
            this.Controls.Add(this.txt_NumeroCli);
            this.Controls.Add(this.txt_EnderecoCli);
            this.Controls.Add(this.txt_SobrenomeCli);
            this.Controls.Add(this.txt_NomeCli);
            this.Controls.Add(this.lbl_AtivoCli);
            this.Controls.Add(this.lbl_EstadoCli);
            this.Controls.Add(this.lbl_CidadeCli);
            this.Controls.Add(this.lbl_ComplementoCli);
            this.Controls.Add(this.lbl_NumeroCli);
            this.Controls.Add(this.lbl_EnderecoCli);
            this.Controls.Add(this.lbl_SobrenomeCli);
            this.Controls.Add(this.lbl_NomeCli);
            this.Controls.Add(this.btn_VoltarCli);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VoltarCli;
        private System.Windows.Forms.Label lbl_NomeCli;
        private System.Windows.Forms.Label lbl_SobrenomeCli;
        private System.Windows.Forms.Label lbl_EnderecoCli;
        private System.Windows.Forms.Label lbl_NumeroCli;
        private System.Windows.Forms.Label lbl_ComplementoCli;
        private System.Windows.Forms.Label lbl_CidadeCli;
        private System.Windows.Forms.Label lbl_EstadoCli;
        private System.Windows.Forms.Label lbl_AtivoCli;
        private System.Windows.Forms.TextBox txt_NomeCli;
        private System.Windows.Forms.TextBox txt_SobrenomeCli;
        private System.Windows.Forms.TextBox txt_EnderecoCli;
        private System.Windows.Forms.TextBox txt_NumeroCli;
        private System.Windows.Forms.TextBox txt_ComplementoCli;
        private System.Windows.Forms.TextBox txt_CidadeCli;
        private System.Windows.Forms.TextBox txt_EstadoCli;
        private System.Windows.Forms.TextBox txt_AtivoCli;
        private System.Windows.Forms.Button btn_InsereCli;
        private System.Windows.Forms.Button btn_AtualizaCli;
        private System.Windows.Forms.Button btn_ExcluiCli;
        private System.Windows.Forms.Button btn_SalvarCli;
        private System.Windows.Forms.Label lbl_CEPCli;
        private System.Windows.Forms.TextBox txt_CEPCli;
        private System.Windows.Forms.DataGridView dgvCliente;
    }
}