using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using ClinicaApp;

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
            using (var conn = DbConnectionFactory.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM Doencas ORDER BY Id", conn);
                var da = new NpgsqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (var conn = DbConnectionFactory.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO Doencas (Nome, CID, Descricao) VALUES (@nome, @cid, @descricao)", conn);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cid", txtCID.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.ExecuteNonQuery();
            }
            LoadDoencas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            using (var conn = DbConnectionFactory.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE Doencas SET Nome=@nome, CID=@cid, Descricao=@descricao WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cid", txtCID.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            LoadDoencas();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            using (var conn = DbConnectionFactory.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM Doencas WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            LoadDoencas();
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
