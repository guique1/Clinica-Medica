namespace ClinicaApp
{
    partial class AgendamentoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label labelMedico;
        private System.Windows.Forms.ComboBox comboBoxMedico;
        private System.Windows.Forms.Label labelDataHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataHora;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.DataGridView dataGridViewAgendamentos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelCliente = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.labelMedico = new System.Windows.Forms.Label();
            this.comboBoxMedico = new System.Windows.Forms.ComboBox();
            this.labelDataHora = new System.Windows.Forms.Label();
            this.dateTimePickerDataHora = new System.Windows.Forms.DateTimePicker();
            this.labelObs = new System.Windows.Forms.Label();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dataGridViewAgendamentos = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();
            // labelCliente
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(20, 20);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(44, 15);
            this.labelCliente.Text = "Cliente";
            // comboBoxCliente
            this.comboBoxCliente.Location = new System.Drawing.Point(80, 17);
            this.comboBoxCliente.Size = new System.Drawing.Size(200, 23);
            // labelMedico
            this.labelMedico.AutoSize = true;
            this.labelMedico.Location = new System.Drawing.Point(20, 60);
            this.labelMedico.Name = "labelMedico";
            this.labelMedico.Size = new System.Drawing.Size(46, 15);
            this.labelMedico.Text = "Médico";
            // comboBoxMedico
            this.comboBoxMedico.Location = new System.Drawing.Point(80, 57);
            this.comboBoxMedico.Size = new System.Drawing.Size(200, 23);
            // labelDataHora
            this.labelDataHora.AutoSize = true;
            this.labelDataHora.Location = new System.Drawing.Point(20, 100);
            this.labelDataHora.Name = "labelDataHora";
            this.labelDataHora.Size = new System.Drawing.Size(54, 15);
            this.labelDataHora.Text = "Data/Hora";
            // dateTimePickerDataHora
            this.dateTimePickerDataHora.Location = new System.Drawing.Point(80, 97);
            this.dateTimePickerDataHora.Size = new System.Drawing.Size(200, 23);
            // labelObs
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(20, 140);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(70, 15);
            this.labelObs.Text = "Observação";
            // textBoxObs
            this.textBoxObs.Location = new System.Drawing.Point(100, 137);
            this.textBoxObs.Size = new System.Drawing.Size(180, 23);
            // buttonSalvar
            this.buttonSalvar.Location = new System.Drawing.Point(80, 180);
            this.buttonSalvar.Size = new System.Drawing.Size(100, 30);
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // dataGridViewAgendamentos
            this.dataGridViewAgendamentos.Location = new System.Drawing.Point(320, 17);
            this.dataGridViewAgendamentos.Size = new System.Drawing.Size(400, 200);
            // AgendamentoForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 250);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.labelMedico);
            this.Controls.Add(this.comboBoxMedico);
            this.Controls.Add(this.labelDataHora);
            this.Controls.Add(this.dateTimePickerDataHora);
            this.Controls.Add(this.labelObs);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dataGridViewAgendamentos);
            this.Name = "AgendamentoForm";
            this.Text = "Agendamentos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
