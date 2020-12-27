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
    public partial class Cliente : Form
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

        public Cliente()
        {
            InitializeComponent();
        }

        private void btn_VoltarCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cliente_select()
        {
            try
            {
                conn.Open();
                sql = @"select * from sede.fn_cli_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvCliente.DataSource = null; //Resetando o DataGridView
                dgvCliente.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            cliente_select();
        }

        private void dgvCli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_InsereCli_Click(object sender, EventArgs e)
        {
            rowIndex = -1;
            txt_NomeCli.Enabled = txt_SobrenomeCli.Enabled = txt_EnderecoCli.Enabled = txt_NumeroCli.Enabled = txt_ComplementoCli.Enabled = txt_CEPCli.Enabled = txt_CidadeCli.Enabled = txt_EstadoCli.Enabled = txt_AtivoCli.Enabled = true;
            txt_NomeCli.Text = txt_SobrenomeCli.Text = txt_EnderecoCli.Text = txt_NumeroCli.Text = txt_CEPCli.Text = txt_CidadeCli.Text = txt_EstadoCli.Text = txt_ComplementoCli.Text = txt_AtivoCli.Text = null;
            txt_NomeCli.Select();
        }

        private void dgvCli_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_AtualizaCli_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Por favor, escolha um cliente para atualizar.");
                return;
            }
            txt_NomeCli.Enabled = txt_SobrenomeCli.Enabled = txt_EnderecoCli.Enabled = txt_NumeroCli.Enabled = txt_ComplementoCli.Enabled = txt_CEPCli.Enabled = txt_CidadeCli.Enabled = txt_EstadoCli.Enabled = txt_AtivoCli.Enabled = true;
        }

        private void btn_ExcluiCli_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Por favor, escolha um cliente para deletar.");
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * from sede.fn_cli_delete(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", int.Parse(dgvCliente.Rows[rowIndex].Cells["_id_cli"].Value.ToString()));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Cliente deletado com sucesso.");
                    rowIndex = -1;
                    conn.Close();
                    cliente_select();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Falha ao excluir. Erro: " + ex.Message);
            }
        }

        private void btn_SalvarCli_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (rowIndex < 0) //Insert
            {
                try
                {
                    conn.Open();
                    sql = @"select * from sede.fn_cli_insert(:_nome, :_sobrenome, :_endereco, :_numero, :_complemento, :_cep, :_cidade, :_estado)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_nome", txt_NomeCli.Text);
                    cmd.Parameters.AddWithValue("_sobrenome", txt_SobrenomeCli.Text);
                    cmd.Parameters.AddWithValue("_endereco", txt_EnderecoCli.Text);
                    cmd.Parameters.AddWithValue("_numero", txt_NumeroCli.Text);
                    cmd.Parameters.AddWithValue("_complemento", txt_ComplementoCli.Text);
                    cmd.Parameters.AddWithValue("_cep", txt_CEPCli.Text);
                    cmd.Parameters.AddWithValue("_cidade", txt_CidadeCli.Text);
                    cmd.Parameters.AddWithValue("_estado", txt_EstadoCli.Text);
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Registro inserido com sucesso.");
                        cliente_select();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao inserir registro.");
                    }

                    cliente_select();
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
                    sql = @"select * from sede.fn_cli_update(:_id,:_nome,:_sobrenome,:_endereco,:_numero,:_complemento,:_cep,:_cidade,:_estado,:_fg_ativo)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", int.Parse(dgvCliente.Rows[rowIndex].Cells["_id_cli"].Value.ToString()));
                    cmd.Parameters.AddWithValue("_nome", txt_NomeCli.Text);
                    cmd.Parameters.AddWithValue("_sobrenome", txt_SobrenomeCli.Text);
                    cmd.Parameters.AddWithValue("_endereco", txt_EnderecoCli.Text);
                    cmd.Parameters.AddWithValue("_numero", txt_NumeroCli.Text);
                    cmd.Parameters.AddWithValue("_complemento", txt_ComplementoCli.Text);
                    cmd.Parameters.AddWithValue("_cep", txt_CEPCli.Text);
                    cmd.Parameters.AddWithValue("_cidade", txt_CidadeCli.Text);
                    cmd.Parameters.AddWithValue("_estado", txt_EstadoCli.Text);
                    cmd.Parameters.AddWithValue("_fg_ativo", int.Parse(txt_AtivoCli.Text));
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Registro atualizado com sucesso.");
                        cliente_select();
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
            txt_NomeCli.Enabled = txt_SobrenomeCli.Enabled = txt_EnderecoCli.Enabled = txt_NumeroCli.Enabled = txt_ComplementoCli.Enabled = txt_CEPCli.Enabled = txt_CidadeCli.Enabled = txt_EstadoCli.Enabled = txt_AtivoCli.Enabled = false;
            txt_NomeCli.Text = txt_SobrenomeCli.Text = txt_EnderecoCli.Text = txt_NumeroCli.Text = txt_CEPCli.Text = txt_CidadeCli.Text = txt_EstadoCli.Text = txt_ComplementoCli.Text = txt_AtivoCli.Text = null;

        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txt_NomeCli.Text = dgvCliente.Rows[e.RowIndex].Cells["_nome"].Value.ToString();
                txt_SobrenomeCli.Text = dgvCliente.Rows[e.RowIndex].Cells["_sobrenome"].Value.ToString();
                txt_EnderecoCli.Text = dgvCliente.Rows[e.RowIndex].Cells["_endereco"].Value.ToString();
                txt_NumeroCli.Text = dgvCliente.Rows[e.RowIndex].Cells["_numero"].Value.ToString();
                txt_ComplementoCli.Text = dgvCliente.Rows[e.RowIndex].Cells["_complemento"].Value.ToString();
                txt_CEPCli.Text = dgvCliente.Rows[e.RowIndex].Cells["_cep"].Value.ToString();
                txt_CidadeCli.Text = dgvCliente.Rows[e.RowIndex].Cells["_cidade"].Value.ToString();
                txt_EstadoCli.Text = dgvCliente.Rows[e.RowIndex].Cells["_estado"].Value.ToString();
                txt_AtivoCli.Text = dgvCliente.Rows[e.RowIndex].Cells["_fg_ativo"].Value.ToString();
            }
        }
    }
}
