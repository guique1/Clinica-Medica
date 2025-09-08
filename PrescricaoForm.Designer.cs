namespace CLINICA2
{
    partial class PrescricaoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboMedico;
        private System.Windows.Forms.ComboBox comboMedicamento;
        private System.Windows.Forms.ComboBox comboDoenca;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.Label lblDoenca;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboMedico = new System.Windows.Forms.ComboBox();
            this.comboMedicamento = new System.Windows.Forms.ComboBox();
            this.comboDoenca = new System.Windows.Forms.ComboBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.lblDoenca = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(500, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // comboCliente
            // 
            this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCliente.Location = new System.Drawing.Point(100, 230);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(200, 23);
            this.comboCliente.TabIndex = 1;
            // 
            // comboMedico
            // 
            this.comboMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMedico.Location = new System.Drawing.Point(100, 260);
            this.comboMedico.Name = "comboMedico";
            this.comboMedico.Size = new System.Drawing.Size(200, 23);
            this.comboMedico.TabIndex = 2;
            // 
            // comboMedicamento
            // 
            this.comboMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMedicamento.Location = new System.Drawing.Point(100, 290);
            this.comboMedicamento.Name = "comboMedicamento";
            this.comboMedicamento.Size = new System.Drawing.Size(200, 23);
            this.comboMedicamento.TabIndex = 3;
            // 
            // comboDoenca
            // 
            this.comboDoenca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDoenca.Location = new System.Drawing.Point(100, 320);
            this.comboDoenca.Name = "comboDoenca";
            this.comboDoenca.Size = new System.Drawing.Size(200, 23);
            this.comboDoenca.TabIndex = 4;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(100, 350);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(200, 23);
            this.txtObservacao.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 233);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(12, 263);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(46, 15);
            this.lblMedico.TabIndex = 7;
            this.lblMedico.Text = "Médico";
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Location = new System.Drawing.Point(12, 293);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(78, 15);
            this.lblMedicamento.TabIndex = 8;
            this.lblMedicamento.Text = "Medicamento";
            // 
            // lblDoenca
            // 
            this.lblDoenca.AutoSize = true;
            this.lblDoenca.Location = new System.Drawing.Point(12, 323);
            this.lblDoenca.Name = "lblDoenca";
            this.lblDoenca.Size = new System.Drawing.Size(49, 15);
            this.lblDoenca.TabIndex = 9;
            this.lblDoenca.Text = "Doença";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(12, 353);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(70, 15);
            this.lblObservacao.TabIndex = 10;
            this.lblObservacao.Text = "Observação";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(350, 230);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(90, 23);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(350, 260);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // PrescricaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 391);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblDoenca);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.comboDoenca);
            this.Controls.Add(this.comboMedicamento);
            this.Controls.Add(this.comboMedico);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrescricaoForm";
            this.Text = "Prescrições";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
