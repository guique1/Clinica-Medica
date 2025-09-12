using ClinicaApp;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace CLINICA2
{
    public partial class DoencaForm : Form
    {
        public DoencaForm()
        {
            InitializeComponent();
            LoadDoencas();
        }

        private void LoadDoencas()
        {
            try
            {
                using (var conn = DbConnectionFactory.GetConnection())
                {
                    string query = "SELECT * FROM Doencas ORDER BY Id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar doenças: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DbConnectionFactory.GetConnection())
                {
                    string query = "INSERT INTO Doencas (Nome, CID, Descricao) VALUES (@nome, @cid, @descricao)";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@cid", txtCID.Text);
                        cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadDoencas();
                MessageBox.Show("Doença adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar doença: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            try
            {
                using (var conn = DbConnectionFactory.GetConnection())
                {
                    string query = "UPDATE Doencas SET Nome=@nome, CID=@cid, Descricao=@descricao WHERE Id=@id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@cid", txtCID.Text);
                        cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadDoencas();
                MessageBox.Show("Doença editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar doença: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            try
            {
                using (var conn = DbConnectionFactory.GetConnection())
                {
                    string query = "DELETE FROM Doencas WHERE Id=@id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadDoencas();
                MessageBox.Show("Doença excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir doença: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var row = dataGridView1.SelectedRows[0];
            txtNome.Text = row.Cells["Nome"].Value?.ToString() ?? string.Empty;
            txtCID.Text = row.Cells["CID"].Value?.ToString() ?? string.Empty;
            txtDescricao.Text = row.Cells["Descricao"].Value?.ToString() ?? string.Empty;
        }
    }
}
