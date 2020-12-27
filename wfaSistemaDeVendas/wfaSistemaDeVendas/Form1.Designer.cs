namespace wfaSistemaDeVendas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Titulo2 = new System.Windows.Forms.Label();
            this.btn_MenuCli = new System.Windows.Forms.Button();
            this.btn_MenuProd = new System.Windows.Forms.Button();
            this.btn_MenuVendas = new System.Windows.Forms.Button();
            this.btn_MenuFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(32, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(218, 21);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Olá, bem-vindo ao sistema";
            // 
            // lbl_Titulo2
            // 
            this.lbl_Titulo2.AutoSize = true;
            this.lbl_Titulo2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo2.Location = new System.Drawing.Point(32, 30);
            this.lbl_Titulo2.Name = "lbl_Titulo2";
            this.lbl_Titulo2.Size = new System.Drawing.Size(221, 21);
            this.lbl_Titulo2.TabIndex = 1;
            this.lbl_Titulo2.Text = "Selecione uma das opções:";
            // 
            // btn_MenuCli
            // 
            this.btn_MenuCli.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_MenuCli.FlatAppearance.BorderSize = 2;
            this.btn_MenuCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_MenuCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuCli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MenuCli.Location = new System.Drawing.Point(36, 64);
            this.btn_MenuCli.Name = "btn_MenuCli";
            this.btn_MenuCli.Size = new System.Drawing.Size(214, 32);
            this.btn_MenuCli.TabIndex = 2;
            this.btn_MenuCli.Text = "Controle de Clientes";
            this.btn_MenuCli.UseVisualStyleBackColor = true;
            this.btn_MenuCli.Click += new System.EventHandler(this.btn_MenuCli_Click);
            // 
            // btn_MenuProd
            // 
            this.btn_MenuProd.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_MenuProd.FlatAppearance.BorderSize = 2;
            this.btn_MenuProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_MenuProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MenuProd.Location = new System.Drawing.Point(36, 102);
            this.btn_MenuProd.Name = "btn_MenuProd";
            this.btn_MenuProd.Size = new System.Drawing.Size(214, 32);
            this.btn_MenuProd.TabIndex = 3;
            this.btn_MenuProd.Text = "Controle de Produtos";
            this.btn_MenuProd.UseVisualStyleBackColor = true;
            this.btn_MenuProd.Click += new System.EventHandler(this.btn_MenuProd_Click);
            // 
            // btn_MenuVendas
            // 
            this.btn_MenuVendas.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_MenuVendas.FlatAppearance.BorderSize = 2;
            this.btn_MenuVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_MenuVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuVendas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MenuVendas.Location = new System.Drawing.Point(36, 140);
            this.btn_MenuVendas.Name = "btn_MenuVendas";
            this.btn_MenuVendas.Size = new System.Drawing.Size(217, 32);
            this.btn_MenuVendas.TabIndex = 4;
            this.btn_MenuVendas.Text = "Controle de Pedidos";
            this.btn_MenuVendas.UseVisualStyleBackColor = true;
            this.btn_MenuVendas.Click += new System.EventHandler(this.btn_MenuVendas_Click);
            // 
            // btn_MenuFechar
            // 
            this.btn_MenuFechar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MenuFechar.Location = new System.Drawing.Point(197, 178);
            this.btn_MenuFechar.Name = "btn_MenuFechar";
            this.btn_MenuFechar.Size = new System.Drawing.Size(75, 23);
            this.btn_MenuFechar.TabIndex = 5;
            this.btn_MenuFechar.Text = "Fechar";
            this.btn_MenuFechar.UseVisualStyleBackColor = true;
            this.btn_MenuFechar.Click += new System.EventHandler(this.btn_MenuFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.btn_MenuFechar);
            this.Controls.Add(this.btn_MenuVendas);
            this.Controls.Add(this.btn_MenuProd);
            this.Controls.Add(this.btn_MenuCli);
            this.Controls.Add(this.lbl_Titulo2);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema para Controle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Titulo2;
        private System.Windows.Forms.Button btn_MenuCli;
        private System.Windows.Forms.Button btn_MenuProd;
        private System.Windows.Forms.Button btn_MenuVendas;
        private System.Windows.Forms.Button btn_MenuFechar;
    }
}

