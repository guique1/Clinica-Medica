
namespace ClinicaApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controles do formulário
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Label labelDataNasc;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNasc;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label labelHistorico;
        private System.Windows.Forms.TextBox textBoxHistorico;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonLimpar;
    private System.Windows.Forms.Button buttonExportar;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem menuClientes;
    private System.Windows.Forms.ToolStripMenuItem menuAgendamentos;
    private System.Windows.Forms.ToolStripMenuItem menuMedicamentos;
    private System.Windows.Forms.ToolStripMenuItem menuDoencas;
    private System.Windows.Forms.ToolStripMenuItem menuPrescricoes;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.labelDataNasc = new System.Windows.Forms.Label();
            this.dateTimePickerDataNasc = new System.Windows.Forms.DateTimePicker();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.labelHistorico = new System.Windows.Forms.Label();
            this.textBoxHistorico = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgendamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMedicamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoencas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrescricoes = new System.Windows.Forms.ToolStripMenuItem();

            // labelNome
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(20, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.Text = "Nome";
            // textBoxNome
            this.textBoxNome.Location = new System.Drawing.Point(120, 17);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(200, 23);
            // labelCPF
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(20, 60);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(28, 15);
            this.labelCPF.Text = "CPF";
            // textBoxCPF
            this.textBoxCPF.Location = new System.Drawing.Point(120, 57);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(200, 23);
            // labelDataNasc
            this.labelDataNasc.AutoSize = true;
            this.labelDataNasc.Location = new System.Drawing.Point(20, 100);
            this.labelDataNasc.Name = "labelDataNasc";
            this.labelDataNasc.Size = new System.Drawing.Size(99, 15);
            this.labelDataNasc.Text = "Data Nascimento";
            // dateTimePickerDataNasc
            this.dateTimePickerDataNasc.Location = new System.Drawing.Point(120, 97);
            this.dateTimePickerDataNasc.Name = "dateTimePickerDataNasc";
            this.dateTimePickerDataNasc.Size = new System.Drawing.Size(200, 23);
            // labelEndereco
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(20, 140);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(56, 15);
            this.labelEndereco.Text = "Endereço";
            // textBoxEndereco
            this.textBoxEndereco.Location = new System.Drawing.Point(120, 137);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(200, 23);
            // labelTelefone
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(20, 180);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(51, 15);
            this.labelTelefone.Text = "Telefone";
            // textBoxTelefone
            this.textBoxTelefone.Location = new System.Drawing.Point(120, 177);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(200, 23);
            // labelHistorico
            this.labelHistorico.AutoSize = true;
            this.labelHistorico.Location = new System.Drawing.Point(20, 220);
            this.labelHistorico.Name = "labelHistorico";
            this.labelHistorico.Size = new System.Drawing.Size(92, 15);
            this.labelHistorico.Text = "Histórico Médico";
            // textBoxHistorico
            this.textBoxHistorico.Location = new System.Drawing.Point(120, 217);
            this.textBoxHistorico.Name = "textBoxHistorico";
            this.textBoxHistorico.Size = new System.Drawing.Size(200, 60);
            this.textBoxHistorico.Multiline = true;
            // buttonSalvar
            this.buttonSalvar.Location = new System.Drawing.Point(120, 290);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 30);
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // buttonLimpar
            this.buttonLimpar.Location = new System.Drawing.Point(230, 290);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(90, 30);
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // dataGridViewClientes
            this.dataGridViewClientes.Location = new System.Drawing.Point(350, 17);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(600, 250);
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.MultiSelect = false;
            // buttonConsultar
            this.buttonConsultar.Location = new System.Drawing.Point(350, 280);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(100, 30);
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            // buttonEditar
            this.buttonEditar.Location = new System.Drawing.Point(460, 280);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 30);
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // buttonExcluir
            this.buttonExcluir.Location = new System.Drawing.Point(570, 280);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(100, 30);
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // buttonExportar
            this.buttonExportar.Location = new System.Drawing.Point(680, 280);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(120, 30);
            this.buttonExportar.Text = "Exportar CSV";
            this.buttonExportar.UseVisualStyleBackColor = true;
            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuClientes,
                this.menuAgendamentos,
                this.menuMedicamentos,
                this.menuDoencas,
                this.menuPrescricoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";


            // menuClientes
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(64, 20);
            this.menuClientes.Text = "Clientes";

            // menuAgendamentos
            this.menuAgendamentos.Name = "menuAgendamentos";
            this.menuAgendamentos.Size = new System.Drawing.Size(99, 20);
            this.menuAgendamentos.Text = "Agendamentos";

            // menuMedicamentos
            this.menuMedicamentos.Name = "menuMedicamentos";
            this.menuMedicamentos.Size = new System.Drawing.Size(99, 20);
            this.menuMedicamentos.Text = "Medicamentos";

            // menuDoencas
            this.menuDoencas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoencas.Name = "menuDoencas";
            this.menuDoencas.Size = new System.Drawing.Size(70, 20);
            this.menuDoencas.Text = "Doenças";

            // menuPrescricoes
            this.menuPrescricoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrescricoes.Name = "menuPrescricoes";
            this.menuPrescricoes.Size = new System.Drawing.Size(85, 20);
            this.menuPrescricoes.Text = "Prescrições";

            // labelBuscar
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(350, 320);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(42, 15);
            this.labelBuscar.Text = "Buscar";
            // textBoxBuscar
            this.textBoxBuscar.Location = new System.Drawing.Point(400, 317);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(200, 23);
            // buttonBuscar
            this.buttonBuscar.Location = new System.Drawing.Point(610, 315);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(80, 27);
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;

            // Form1
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 350);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.labelDataNasc);
            this.Controls.Add(this.dateTimePickerDataNasc);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.labelHistorico);
            this.Controls.Add(this.textBoxHistorico);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Clínica - Menu Principal";
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
