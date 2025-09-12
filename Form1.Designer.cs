
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
        private System.Windows.Forms.Label labelDataNasc;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNasc;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelTelefone;
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
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelCPF = new Label();
            labelDataNasc = new Label();
            dateTimePickerDataNasc = new DateTimePicker();
            labelEndereco = new Label();
            textBoxEndereco = new TextBox();
            labelTelefone = new Label();
            labelHistorico = new Label();
            textBoxHistorico = new TextBox();
            buttonSalvar = new Button();
            dataGridViewClientes = new DataGridView();
            buttonConsultar = new Button();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            labelBuscar = new Label();
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            buttonLimpar = new Button();
            buttonExportar = new Button();
            menuStrip1 = new MenuStrip();
            menuAgendamentos = new ToolStripMenuItem();
            menuMedicamentos = new ToolStripMenuItem();
            menuDoencas = new ToolStripMenuItem();
            menuPrescricoes = new ToolStripMenuItem();
            menuClientes = new Label();
            textBoxCPF = new MaskedTextBox();
            textBoxTelefone = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(36, 50);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(120, 47);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(200, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(36, 77);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(28, 15);
            labelCPF.TabIndex = 2;
            labelCPF.Text = "CPF";
            // 
            // labelDataNasc
            // 
            labelDataNasc.AutoSize = true;
            labelDataNasc.Location = new Point(12, 108);
            labelDataNasc.Name = "labelDataNasc";
            labelDataNasc.Size = new Size(98, 15);
            labelDataNasc.TabIndex = 4;
            labelDataNasc.Text = "Data Nascimento";
            // 
            // dateTimePickerDataNasc
            // 
            dateTimePickerDataNasc.Location = new Point(120, 108);
            dateTimePickerDataNasc.Name = "dateTimePickerDataNasc";
            dateTimePickerDataNasc.Size = new Size(200, 23);
            dateTimePickerDataNasc.TabIndex = 5;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Location = new Point(24, 140);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(56, 15);
            labelEndereco.TabIndex = 6;
            labelEndereco.Text = "Endereço";
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Location = new Point(120, 137);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(200, 23);
            textBoxEndereco.TabIndex = 7;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(24, 180);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(52, 15);
            labelTelefone.TabIndex = 8;
            labelTelefone.Text = "Telefone";
            // 
            // labelHistorico
            // 
            labelHistorico.AutoSize = true;
            labelHistorico.Location = new Point(16, 220);
            labelHistorico.Name = "labelHistorico";
            labelHistorico.Size = new Size(98, 15);
            labelHistorico.TabIndex = 10;
            labelHistorico.Text = "Histórico Médico";
            // 
            // textBoxHistorico
            // 
            textBoxHistorico.Location = new Point(120, 217);
            textBoxHistorico.Multiline = true;
            textBoxHistorico.Name = "textBoxHistorico";
            textBoxHistorico.Size = new Size(200, 60);
            textBoxHistorico.TabIndex = 11;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(120, 290);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(100, 30);
            buttonSalvar.TabIndex = 12;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.Location = new Point(350, 17);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(600, 250);
            dataGridViewClientes.TabIndex = 14;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(350, 280);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(100, 30);
            buttonConsultar.TabIndex = 15;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(460, 280);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(100, 30);
            buttonEditar.TabIndex = 16;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(570, 280);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(100, 30);
            buttonExcluir.TabIndex = 17;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Location = new Point(350, 320);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(42, 15);
            labelBuscar.TabIndex = 19;
            labelBuscar.Text = "Buscar";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(400, 317);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(200, 23);
            textBoxBuscar.TabIndex = 20;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(610, 315);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(80, 27);
            buttonBuscar.TabIndex = 21;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(230, 290);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(90, 30);
            buttonLimpar.TabIndex = 13;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // buttonExportar
            // 
            buttonExportar.Location = new Point(680, 280);
            buttonExportar.Name = "buttonExportar";
            buttonExportar.Size = new Size(120, 30);
            buttonExportar.TabIndex = 18;
            buttonExportar.Text = "Exportar CSV";
            buttonExportar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuAgendamentos, menuMedicamentos, menuDoencas, menuPrescricoes });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(980, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuAgendamentos
            // 
            menuAgendamentos.Name = "menuAgendamentos";
            menuAgendamentos.Size = new Size(100, 20);
            menuAgendamentos.Text = "Agendamentos";
            // 
            // menuMedicamentos
            // 
            menuMedicamentos.Name = "menuMedicamentos";
            menuMedicamentos.Size = new Size(98, 20);
            menuMedicamentos.Text = "Medicamentos";
            // 
            // menuDoencas
            // 
            menuDoencas.Name = "menuDoencas";
            menuDoencas.Size = new Size(64, 20);
            menuDoencas.Text = "Doenças";
            // 
            // menuPrescricoes
            // 
            menuPrescricoes.Name = "menuPrescricoes";
            menuPrescricoes.Size = new Size(78, 20);
            menuPrescricoes.Text = "Prescrições";
            // 
            // menuClientes
            // 
            menuClientes.AutoSize = true;
            menuClientes.Location = new Point(24, 24);
            menuClientes.Name = "menuClientes";
            menuClientes.Size = new Size(75, 15);
            menuClientes.TabIndex = 22;
            menuClientes.Text = "Criar Cliente:";
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(120, 74);
            textBoxCPF.Mask = "000,000,000-00";
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(200, 23);
            textBoxCPF.TabIndex = 23;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(120, 180);
            textBoxTelefone.Mask = "(00) 00000-0000";
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(200, 23);
            textBoxTelefone.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 350);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxCPF);
            Controls.Add(menuClientes);
            Controls.Add(labelNome);
            Controls.Add(textBoxNome);
            Controls.Add(labelCPF);
            Controls.Add(labelDataNasc);
            Controls.Add(dateTimePickerDataNasc);
            Controls.Add(labelEndereco);
            Controls.Add(textBoxEndereco);
            Controls.Add(labelTelefone);
            Controls.Add(labelHistorico);
            Controls.Add(textBoxHistorico);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonLimpar);
            Controls.Add(dataGridViewClientes);
            Controls.Add(buttonConsultar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonExportar);
            Controls.Add(labelBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonBuscar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Clínica - Menu Principal";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label menuClientes;
        private MaskedTextBox textBoxCPF;
        private MaskedTextBox textBoxTelefone;
    }
}
