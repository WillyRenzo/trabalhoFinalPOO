using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSistemaDeVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_MenuCli_Click(object sender, EventArgs e)
        {
            Cliente form = new Cliente();
            form.Show();
        }

        private void btn_MenuFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MenuProd_Click(object sender, EventArgs e)
        {
            Produto form = new Produto();
            form.Show();
        }

        private void btn_MenuVendas_Click(object sender, EventArgs e)
        {
            Venda form = new Venda();
            form.Show();
        }
    }
}
