
using System;

using System.Windows.Forms;
using CLINICA2;

namespace ClinicaApp
{
    public partial class Form1 : Form
    {
        private int? clienteSelecionadoId = null;

        public Form1()
        {
            try
            {
                MessageBox.Show("Entrou no Form1", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeComponent();
                buttonSalvar.Click += buttonSalvar_Click;
                buttonConsultar.Click += buttonConsultar_Click;
                buttonEditar.Click += buttonEditar_Click;
                buttonExcluir.Click += buttonExcluir_Click;
                buttonBuscar.Click += buttonBuscar_Click;
                buttonLimpar.Click += buttonLimpar_Click;
                buttonExportar.Click += buttonExportar_Click;
                dataGridViewClientes.SelectionChanged += dataGridViewClientes_SelectionChanged;
                menuClientes.Click += menuClientes_Click;
                menuAgendamentos.Click += menuAgendamentos_Click;
                menuMedicamentos.Click += menuMedicamentos_Click;
                menuDoencas.Click += menuDoencas_Click;
                menuPrescricoes.Click += menuPrescricoes_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir Form1: {ex.Message}\n{ex.StackTrace}", "Erro crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void menuClientes_Click(object? sender, EventArgs? e)
        {
            // Já está na tela de clientes, não faz nada
        }

        private void menuAgendamentos_Click(object? sender, EventArgs? e)
        {
            using (var frm = new AgendamentoForm())
            {
                frm.ShowDialog();
            }
        }

        private void menuMedicamentos_Click(object? sender, EventArgs? e)
        {
            using (var frm = new MedicamentoForm())
            {
                frm.ShowDialog();
            }
        }

        private void menuDoencas_Click(object? sender, EventArgs? e)
        {
            using (var frm = new DoencaForm())
            {
                frm.ShowDialog();
            }
        }


        private void menuPrescricoes_Click(object? sender, EventArgs? e)
        {
            using (var frm = new PrescricaoForm())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAgendamentos_Click(object? sender, EventArgs? e)
        {
            using (var frm = new AgendamentoForm())
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscar_Click(object? sender, EventArgs? e)
        {
            string termo = textBoxBuscar.Text.Trim();
            if (string.IsNullOrEmpty(termo))
            {
                buttonConsultar_Click(sender, e);
                return;
            }
            try
            {
                using (var conn = DbConnectionFactory.GetConnection())
                using (var cmd = new Npgsql.NpgsqlCommand("SELECT * FROM Clientes WHERE Nome ILIKE @termo ORDER BY Id", conn))
                {
                    cmd.Parameters.AddWithValue("@termo", "%" + termo + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dt = new System.Data.DataTable();
                        dt.Load(reader);
                        dataGridViewClientes.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimpar_Click(object? sender, EventArgs? e)
        {
            LimparCampos();
            dataGridViewClientes.DataSource = null;
            textBoxBuscar.Text = "";
            clienteSelecionadoId = null;
        }

        private void buttonExportar_Click(object? sender, EventArgs? e)
        {
            if (dataGridViewClientes.DataSource == null)
            {
                MessageBox.Show("Nenhum dado para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var dt = dataGridViewClientes.DataSource as System.Data.DataTable;
            if (dt == null)
            {
                MessageBox.Show("Erro ao exportar dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var sfd = new SaveFileDialog { Filter = "CSV (*.csv)|*.csv", FileName = "clientes.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var sw = new System.IO.StreamWriter(sfd.FileName))
                        {
                            // Cabeçalho
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                sw.Write(dt.Columns[i]);
                                if (i < dt.Columns.Count - 1) sw.Write(",");
                            }
                            sw.WriteLine();
                            // Dados
                            foreach (System.Data.DataRow row in dt.Rows)
                            {
                                for (int i = 0; i < dt.Columns.Count; i++)
                                {
                                    sw.Write(row[i].ToString().Replace(",", " "));
                                    if (i < dt.Columns.Count - 1) sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }
                        MessageBox.Show("Dados exportados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao exportar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonConsultar_Click(object? sender, EventArgs? e)
        {
            try
            {
                using (var conn = DbConnectionFactory.GetConnection())
                using (var cmd = new Npgsql.NpgsqlCommand("SELECT * FROM Clientes ORDER BY Id", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new System.Data.DataTable();
                    dt.Load(reader);
                    dataGridViewClientes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewClientes_SelectionChanged(object? sender, EventArgs? e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                var row = dataGridViewClientes.SelectedRows[0];
                clienteSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);
                textBoxNome.Text = row.Cells["Nome"].Value.ToString();
                textBoxCPF.Text = row.Cells["CPF"].Value.ToString();
                dateTimePickerDataNasc.Value = Convert.ToDateTime(row.Cells["DataNascimento"].Value);
                textBoxEndereco.Text = row.Cells["Endereco"].Value.ToString();
                textBoxTelefone.Text = row.Cells["Telefone"].Value.ToString();
                textBoxHistorico.Text = row.Cells["HistoricoMedico"].Value.ToString();
            }
            else
            {
                clienteSelecionadoId = null;
            }
        }

        private void buttonEditar_Click(object? sender, EventArgs? e)
        {
            if (clienteSelecionadoId == null)
            {
                MessageBox.Show("Selecione um cliente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var conn = DbConnectionFactory.GetConnection())
                using (var cmd = new Npgsql.NpgsqlCommand(@"UPDATE Clientes SET Nome=@nome, CPF=@cpf, DataNascimento=@dataNasc, Endereco=@endereco, Telefone=@telefone, HistoricoMedico=@historico WHERE Id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@nome", textBoxNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", textBoxCPF.Text);
                    cmd.Parameters.AddWithValue("@dataNasc", dateTimePickerDataNasc.Value.Date);
                    cmd.Parameters.AddWithValue("@endereco", textBoxEndereco.Text);
                    cmd.Parameters.AddWithValue("@telefone", textBoxTelefone.Text);
                    cmd.Parameters.AddWithValue("@historico", textBoxHistorico.Text);
                    cmd.Parameters.AddWithValue("@id", clienteSelecionadoId.Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonConsultar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExcluir_Click(object? sender, EventArgs? e)
        {
            if (clienteSelecionadoId == null)
            {
                MessageBox.Show("Selecione um cliente para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DbConnectionFactory.GetConnection())
                    using (var cmd = new Npgsql.NpgsqlCommand("DELETE FROM Clientes WHERE Id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", clienteSelecionadoId.Value);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonConsultar_Click(null, null);
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSalvar_Click(object? sender, EventArgs? e)
        {
            string nome = textBoxNome.Text;
            string cpf = textBoxCPF.Text;
            DateTime dataNasc = dateTimePickerDataNasc.Value.Date;
            string endereco = textBoxEndereco.Text;
            string telefone = textBoxTelefone.Text;
            string historico = textBoxHistorico.Text;

            try
            {
                using (var conn = DbConnectionFactory.GetConnection())
                using (var cmd = new Npgsql.NpgsqlCommand(@"INSERT INTO Clientes (Nome, CPF, DataNascimento, Endereco, Telefone, HistoricoMedico) VALUES (@nome, @cpf, @dataNasc, @endereco, @telefone, @historico)", conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@dataNasc", dataNasc);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@historico", historico);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Text = "";
            textBoxCPF.Text = "";
            dateTimePickerDataNasc.Value = DateTime.Now;
            textBoxEndereco.Text = "";
            textBoxTelefone.Text = "";
            textBoxHistorico.Text = "";
        }
    }
}
