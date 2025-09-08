using System;
using System.Windows.Forms;
using Npgsql;

namespace ClinicaApp
{
    public partial class MedicamentoForm : Form
    {
        public MedicamentoForm()
        {
            InitializeComponent();
            ListarMedicamentos();
            buttonSalvar.Click += buttonSalvar_Click;
            dataGridViewMedicamentos.CellClick += dataGridViewMedicamentos_CellClick;
        }

        private int? medicamentoSelecionadoId = null;

        private void ListarMedicamentos()
        {
            using (var conn = DbConnectionFactory.GetConnection())
            using (var cmd = new NpgsqlCommand("SELECT Id, Nome, Descricao FROM Medicamentos ORDER BY Nome", conn))
            using (var reader = cmd.ExecuteReader())
            {
                var dt = new System.Data.DataTable();
                dt.Load(reader);
                dataGridViewMedicamentos.DataSource = dt;
            }
        }

        private void buttonSalvar_Click(object? sender, EventArgs? e)
        {
            string nome = textBoxNome.Text.Trim();
            string descricao = textBoxDescricao.Text.Trim();
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Informe o nome do medicamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var conn = DbConnectionFactory.GetConnection())
            {
                if (medicamentoSelecionadoId == null)
                {
                    using (var cmd = new NpgsqlCommand("INSERT INTO Medicamentos (Nome, Descricao) VALUES (@nome, @desc)", conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@desc", descricao);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Medicamento cadastrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (var cmd = new NpgsqlCommand("UPDATE Medicamentos SET Nome=@nome, Descricao=@desc WHERE Id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@desc", descricao);
                        cmd.Parameters.AddWithValue("@id", medicamentoSelecionadoId.Value);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Medicamento atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LimparCampos();
            ListarMedicamentos();
        }

        private void dataGridViewMedicamentos_CellClick(object? sender, DataGridViewCellEventArgs? e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewMedicamentos.Rows[e.RowIndex];
                medicamentoSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                textBoxNome.Text = row.Cells["Nome"].Value.ToString();
                textBoxDescricao.Text = row.Cells["Descricao"].Value.ToString();

                dataGridViewMedicamentos.ContextMenuStrip = new ContextMenuStrip();
                var itemExcluir = new ToolStripMenuItem("Excluir");
                itemExcluir.Click += (s, ev) => ExcluirMedicamento();
                dataGridViewMedicamentos.ContextMenuStrip.Items.Clear();
                dataGridViewMedicamentos.ContextMenuStrip.Items.Add(itemExcluir);
            }
        }

        private void ExcluirMedicamento()
        {
            if (medicamentoSelecionadoId == null) return;
            if (MessageBox.Show("Deseja excluir este medicamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var conn = DbConnectionFactory.GetConnection())
                using (var cmd = new NpgsqlCommand("DELETE FROM Medicamentos WHERE Id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", medicamentoSelecionadoId.Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Medicamento excluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                ListarMedicamentos();
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Text = "";
            textBoxDescricao.Text = "";
            medicamentoSelecionadoId = null;
        }
    }
}
