using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using ClinicaApp;

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
            using (var conn = DbConnectionFactory.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"SELECT p.Id, c.Nome AS Cliente, m.Nome AS Medico, med.Nome AS Medicamento, d.Nome AS Doenca, p.DataPrescricao, p.Observacao
                                             FROM Prescricoes p
                                             JOIN Clientes c ON p.ClienteId = c.Id
                                             JOIN Medicos m ON p.MedicoId = m.Id
                                             JOIN Medicamentos med ON p.MedicamentoId = med.Id
                                             LEFT JOIN Doencas d ON p.DoencaId = d.Id
                                             ORDER BY p.Id", conn);
                var da = new NpgsqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void LoadCombos()
        {
            using (var conn = DbConnectionFactory.GetConnection())
            {
                conn.Open();
                // Clientes
                var cmd = new NpgsqlCommand("SELECT Id, Nome FROM Clientes ORDER BY Nome", conn);
                var dr = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dr);
                comboCliente.DataSource = dt;
                comboCliente.DisplayMember = "Nome";
                comboCliente.ValueMember = "Id";
                // Medicos
                cmd = new NpgsqlCommand("SELECT Id, Nome FROM Medicos ORDER BY Nome", conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                comboMedico.DataSource = dt;
                comboMedico.DisplayMember = "Nome";
                comboMedico.ValueMember = "Id";
                // Medicamentos
                cmd = new NpgsqlCommand("SELECT Id, Nome FROM Medicamentos ORDER BY Nome", conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                comboMedicamento.DataSource = dt;
                comboMedicamento.DisplayMember = "Nome";
                comboMedicamento.ValueMember = "Id";
                // Doencas
                cmd = new NpgsqlCommand("SELECT Id, Nome FROM Doencas ORDER BY Nome", conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                comboDoenca.DataSource = dt;
                comboDoenca.DisplayMember = "Nome";
                comboDoenca.ValueMember = "Id";
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (var conn = DbConnectionFactory.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO Prescricoes (ClienteId, MedicoId, MedicamentoId, DoencaId, Observacao) VALUES (@cliente, @medico, @medicamento, @doenca, @obs)", conn);
                cmd.Parameters.AddWithValue("@cliente", comboCliente.SelectedValue ?? 0);
                cmd.Parameters.AddWithValue("@medico", comboMedico.SelectedValue ?? 0);
                cmd.Parameters.AddWithValue("@medicamento", comboMedicamento.SelectedValue ?? 0);
                cmd.Parameters.AddWithValue("@doenca", comboDoenca.SelectedValue ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@obs", txtObservacao.Text);
                cmd.ExecuteNonQuery();
            }
            LoadPrescricoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            using (var conn = DbConnectionFactory.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM Prescricoes WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            LoadPrescricoes();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Optionally fill controls for editing
        }
    }
}
