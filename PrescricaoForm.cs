using ClinicaApp;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace CLINICA2
{
    public partial class PrescricaoForm : Form
    {
        public PrescricaoForm()
        {
            InitializeComponent();
            LoadPrescricoes();
            LoadCombos();
        }

        private void LoadPrescricoes()
        {
            try
            {
                using (var conn = DbConnectionFactory.GetConnection())
                {
                    string query = @"
                        SELECT p.Id, c.Nome AS Cliente, m.Nome AS Medico, med.Nome AS Medicamento, d.Nome AS Doenca, p.DataPrescricao, p.Observacao
                        FROM Prescricoes p
                        JOIN Clientes c ON p.ClienteId = c.Id
                        JOIN Medicos m ON p.MedicoId = m.Id
                        JOIN Medicamentos med ON p.MedicamentoId = med.Id
                        LEFT JOIN Doencas d ON p.DoencaId = d.Id
                        ORDER BY p.Id";

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
                MessageBox.Show($"Erro ao carregar prescrições: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCombos()
        {
            try
            {
                using (var conn = DbConnectionFactory.GetConnection())
                {
                    // Clientes
                    using (var cmd = new NpgsqlCommand("SELECT Id, Nome FROM Clientes ORDER BY Nome", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        comboCliente.DataSource = dt;
                        comboCliente.DisplayMember = "Nome";
                        comboCliente.ValueMember = "Id";
                    }

                    // Medicos
                    using (var cmd = new NpgsqlCommand("SELECT Id, Nome FROM Medicos ORDER BY Nome", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        comboMedico.DataSource = dt;
                        comboMedico.DisplayMember = "Nome";
                        comboMedico.ValueMember = "Id";
                    }

                    // Medicamentos
                    using (var cmd = new NpgsqlCommand("SELECT Id, Nome FROM Medicamentos ORDER BY Nome", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        comboMedicamento.DataSource = dt;
                        comboMedicamento.DisplayMember = "Nome";
                        comboMedicamento.ValueMember = "Id";
                    }

                    // Doencas
                    using (var cmd = new NpgsqlCommand("SELECT Id, Nome FROM Doencas ORDER BY Nome", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        comboDoenca.DataSource = dt;
                        comboDoenca.DisplayMember = "Nome";
                        comboDoenca.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar combos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DbConnectionFactory.GetConnection())
                {
                    using (var cmd = new NpgsqlCommand(@"
                        INSERT INTO Prescricoes (ClienteId, MedicoId, MedicamentoId, DoencaId, Observacao) 
                        VALUES (@cliente, @medico, @medicamento, @doenca, @obs)", conn))
                    {
                        cmd.Parameters.AddWithValue("@cliente", comboCliente.SelectedValue ?? 0);
                        cmd.Parameters.AddWithValue("@medico", comboMedico.SelectedValue ?? 0);
                        cmd.Parameters.AddWithValue("@medicamento", comboMedicamento.SelectedValue ?? 0);
                        cmd.Parameters.AddWithValue("@doenca", comboDoenca.SelectedValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@obs", txtObservacao.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadPrescricoes();
                MessageBox.Show("Prescrição adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar prescrição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    using (var cmd = new NpgsqlCommand("DELETE FROM Prescricoes WHERE Id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadPrescricoes();
                MessageBox.Show("Prescrição excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir prescrição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Preencher controles para edição se necessário
        }
    }
}
