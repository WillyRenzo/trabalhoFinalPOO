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
    public partial class Venda : Form
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

        public Venda()
        {
            InitializeComponent();
        }

        private void pedido_select()
        {
            try
            {
                conn.Open();
                sql = @"select * from sede.fn_pedido_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvPed.DataSource = null; //Resetando o DataGridView
                dgvPed.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_VoltarVenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txt_IDCliPed.Text = dgvPed.Rows[e.RowIndex].Cells["_id_cli"].Value.ToString();
                txt_ValorPed.Text = dgvPed.Rows[e.RowIndex].Cells["_valor"].Value.ToString();
            }
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            pedido_select();
        }

        private void btn_InserePed_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            txt_IDCliPed.Enabled = txt_ValorPed.Enabled = true;
            txt_ValorPed.Text = txt_IDCliPed.Text = null;
            txt_IDCliPed.Select();
        }

        private void btn_AtualizaPed_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Por favor, escolha um pedido para atualizar.");
                return;
            }
            txt_IDCliPed.Enabled = txt_ValorPed.Enabled = true;
        }

        private void btn_ExcluiPed_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Por favor, escolha um pedido para deletar.");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from sede.fn_pedido_delete(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", int.Parse(dgvPed.Rows[rowIndex].Cells["_id_pedido"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Pedido excluido com sucesso.");
                    rowIndex = -1;
                    conn.Close();
                    pedido_select();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Falha ao excluir. Erro: " + ex.Message);
            }
        }

        private void btn_SalvaPed_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0) //Insert
            {
                try
                {
                    conn.Open();
                    sql = @"select * from sede.fn_pedido_insert(:_id_cli, :_valor)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_cli", int.Parse(txt_IDCliPed.Text));
                    cmd.Parameters.AddWithValue("_valor", double.Parse(txt_ValorPed.Text));
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Registro inserido com sucesso.");
                        pedido_select();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao inserir registro.");
                    }

                    pedido_select();
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
                    sql = @"select * from sede.fn_pedido_update(:_id,:_id_cli,:_valor, :_fg_ativo)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", int.Parse(dgvPed.Rows[rowIndex].Cells["_id_pedido"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_id_cli", int.Parse(txt_IDCliPed.Text));
                    cmd.Parameters.AddWithValue("_valor", double.Parse(txt_ValorPed.Text));
                    cmd.Parameters.AddWithValue("_fg_ativo", int.Parse("1"));
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Registro atualizado com sucesso.");
                        pedido_select();
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
            txt_IDCliPed.Enabled = txt_ValorPed.Enabled = false;
            txt_IDCliPed.Text = txt_ValorPed.Text = null;
        }
    }
}
