using Npgsql;
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
    public partial class Produto : Form
    {
        private string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres",
            "banco", "Cadastro");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private int rowIndex = -1;
        public Produto()
        {
            InitializeComponent();
        }

        private void btn_VoltarProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            produto_select();
        }

        private void produto_select()
        {
            try
            {
                conn.Open();
                sql = @"select * from sede.fn_prod_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvProd.DataSource = null; //Resetando o DataGridView
                dgvProd.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txt_DescProd.Text = dgvProd.Rows[e.RowIndex].Cells["_descricao"].Value.ToString();
                txt_CustoProd.Text = dgvProd.Rows[e.RowIndex].Cells["_preco_custo"].Value.ToString();
                txt_VendaProd.Text = dgvProd.Rows[e.RowIndex].Cells["_preco_venda"].Value.ToString();
                txt_AtivoProd.Text = dgvProd.Rows[e.RowIndex].Cells["_fg_ativo"].Value.ToString();
            }
        }

        private void btn_InsereProd_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            txt_DescProd.Enabled = txt_CustoProd.Enabled = txt_VendaProd.Enabled = txt_AtivoProd.Enabled = true;
            txt_DescProd.Text = txt_CustoProd.Text = txt_VendaProd.Text = txt_AtivoProd.Text = null;
            txt_DescProd.Select();
        }

        private void btn_AtualizaProd_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Por favor, escolha um produto para atualizar.");
                return;
            }
            txt_DescProd.Enabled = txt_CustoProd.Enabled = txt_VendaProd.Enabled = txt_AtivoProd.Enabled = true;
        }

        private void btn_ExcluiProd_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Por favor, escolha um produto para deletar.");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from sede.fn_prod_delete(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", int.Parse(dgvProd.Rows[rowIndex].Cells["_id_prod"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Cliente deletado com sucesso.");
                    rowIndex = -1;
                    conn.Close();
                    produto_select();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Falha ao excluir. Erro: " + ex.Message);
            }
        }

        private void btn_SalvarProd_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0) //Insert
            {
                try
                {
                    conn.Open();
                    sql = @"select * from sede.fn_prod_insert(:_descricao,:_preco_custo,:_preco_venda)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_descricao", txt_DescProd.Text);
                    cmd.Parameters.AddWithValue("_preco_custo", double.Parse(txt_CustoProd.Text));
                    cmd.Parameters.AddWithValue("_preco_venda", double.Parse(txt_VendaProd.Text));
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Registro inserido com sucesso.");
                        produto_select();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao inserir registro.");
                    }

                    produto_select();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Falha ao inserir registro. Erro: " + ex.Message);
                }
            }
            else //Update
            {
                try
                {
                    conn.Open();
                    sql = @"select * from sede.fn_prod_update(:_id,:_descricao, :_preco_custo, :_preco_venda, :_fg_ativo)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", int.Parse(dgvProd.Rows[rowIndex].Cells["_id_prod"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_descricao", txt_DescProd.Text);
                    cmd.Parameters.AddWithValue("_preco_custo", float.Parse(txt_CustoProd.Text));
                    cmd.Parameters.AddWithValue("_preco_venda", float.Parse(txt_VendaProd.Text));
                    cmd.Parameters.AddWithValue("_fg_ativo", int.Parse(txt_AtivoProd.Text));
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Registro atualizado com sucesso.");
                        produto_select();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o registro.");
                    }

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Falha ao atualizar registro. Erro: " + ex.Message);
                }
            }
            result = 0;
            txt_DescProd.Enabled = txt_CustoProd.Enabled = txt_VendaProd.Enabled = txt_AtivoProd.Enabled = false;
            txt_DescProd.Text = txt_CustoProd.Text = txt_VendaProd.Text = txt_AtivoProd.Text = null;
        }
    }
}
