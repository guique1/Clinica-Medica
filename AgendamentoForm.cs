using System;
using System.Windows.Forms;
using Npgsql;

namespace ClinicaApp
{
    public partial class AgendamentoForm : Form
    {
        public AgendamentoForm()
        {
            InitializeComponent();
            CarregarClientes();
            CarregarMedicos();
            ListarAgendamentos();
            buttonSalvar.Click += buttonSalvar_Click;
            dataGridViewAgendamentos.CellClick += dataGridViewAgendamentos_CellClick;
        }

        private int? agendamentoSelecionadoId = null;

        private void CarregarClientes()
        {
            comboBoxCliente.Items.Clear();
            using (var conn = DbConnectionFactory.GetConnection())
            using (var cmd = new NpgsqlCommand("SELECT Id, Nome FROM Clientes ORDER BY Nome", conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBoxCliente.Items.Add(new ComboboxItem { Text = reader.GetString(1), Value = reader.GetInt32(0) });
                }
            }
        }

        private void CarregarMedicos()
        {
            comboBoxMedico.Items.Clear();
            using (var conn = DbConnectionFactory.GetConnection())
            using (var cmd = new NpgsqlCommand("SELECT Id, Nome FROM Medicos ORDER BY Nome", conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBoxMedico.Items.Add(new ComboboxItem { Text = reader.GetString(1), Value = reader.GetInt32(0) });
                }
            }
        }

        private void ListarAgendamentos()
        {
            using (var conn = DbConnectionFactory.GetConnection())
            using (var cmd = new NpgsqlCommand(@"SELECT a.Id, c.Nome AS Cliente, m.Nome AS Medico, a.DataHora, a.Observacao
                                                FROM Agendamentos a
                                                JOIN Clientes c ON a.ClienteId = c.Id
                                                JOIN Medicos m ON a.MedicoId = m.Id
                                                ORDER BY a.DataHora DESC", conn))
            using (var reader = cmd.ExecuteReader())
            {
                var dt = new System.Data.DataTable();
                dt.Load(reader);
                dataGridViewAgendamentos.DataSource = dt;
            }
        }

        private void buttonSalvar_Click(object? sender, EventArgs? e)
        {
            if (comboBoxCliente.SelectedItem == null || comboBoxMedico.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cliente e um médico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int clienteId = ((ComboboxItem)comboBoxCliente.SelectedItem).Value;
            int medicoId = ((ComboboxItem)comboBoxMedico.SelectedItem).Value;
            DateTime dataHora = dateTimePickerDataHora.Value;
            string obs = textBoxObs.Text;

            using (var conn = DbConnectionFactory.GetConnection())
            {
                if (agendamentoSelecionadoId == null)
                {
                    // Inserir novo
                    using (var cmd = new NpgsqlCommand("INSERT INTO Agendamentos (ClienteId, MedicoId, DataHora, Observacao) VALUES (@cliente, @medico, @datahora, @obs)", conn))
                    {
                        cmd.Parameters.AddWithValue("@cliente", clienteId);
                        cmd.Parameters.AddWithValue("@medico", medicoId);
                        cmd.Parameters.AddWithValue("@datahora", dataHora);
                        cmd.Parameters.AddWithValue("@obs", obs);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Agendamento cadastrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Editar
                    using (var cmd = new NpgsqlCommand("UPDATE Agendamentos SET ClienteId=@cliente, MedicoId=@medico, DataHora=@datahora, Observacao=@obs WHERE Id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@cliente", clienteId);
                        cmd.Parameters.AddWithValue("@medico", medicoId);
                        cmd.Parameters.AddWithValue("@datahora", dataHora);
                        cmd.Parameters.AddWithValue("@obs", obs);
                        cmd.Parameters.AddWithValue("@id", agendamentoSelecionadoId.Value);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Agendamento atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LimparCampos();
            ListarAgendamentos();
        }

        private void dataGridViewAgendamentos_CellClick(object? sender, DataGridViewCellEventArgs? e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewAgendamentos.Rows[e.RowIndex];
                agendamentoSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                // Selecionar cliente e médico nos combos
                SelecionarComboPorTexto(comboBoxCliente, row.Cells["Cliente"].Value.ToString());
                SelecionarComboPorTexto(comboBoxMedico, row.Cells["Medico"].Value.ToString());
                dateTimePickerDataHora.Value = Convert.ToDateTime(row.Cells["DataHora"].Value);
                textBoxObs.Text = row.Cells["Observacao"].Value.ToString();

                // Botão direito para excluir
                dataGridViewAgendamentos.ContextMenuStrip = new ContextMenuStrip();
                var itemExcluir = new ToolStripMenuItem("Excluir");
                itemExcluir.Click += (s, ev) => ExcluirAgendamento();
                dataGridViewAgendamentos.ContextMenuStrip.Items.Clear();
                dataGridViewAgendamentos.ContextMenuStrip.Items.Add(itemExcluir);
            }
        }

        private void ExcluirAgendamento()
        {
            if (agendamentoSelecionadoId == null) return;
            if (MessageBox.Show("Deseja excluir este agendamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var conn = DbConnectionFactory.GetConnection())
                using (var cmd = new NpgsqlCommand("DELETE FROM Agendamentos WHERE Id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", agendamentoSelecionadoId.Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Agendamento excluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                ListarAgendamentos();
            }
        }

        private void LimparCampos()
        {
            comboBoxCliente.SelectedItem = null;
            comboBoxMedico.SelectedItem = null;
            dateTimePickerDataHora.Value = DateTime.Now;
            textBoxObs.Text = "";
            agendamentoSelecionadoId = null;
        }

        // Classe utilitária para ComboBox
        private class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public override string ToString() => Text;
        }

        private void SelecionarComboPorTexto(ComboBox combo, string texto)
        {
            foreach (var item in combo.Items)
            {
                if (((ComboboxItem)item).Text == texto)
                {
                    combo.SelectedItem = item;
                    break;
                }
            }
        }
    }
}
