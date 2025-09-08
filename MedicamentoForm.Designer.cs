namespace ClinicaApp
{
    partial class MedicamentoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.DataGridView dataGridViewMedicamentos;

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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dataGridViewMedicamentos = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();
            // labelNome
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(20, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.Text = "Nome";
            // textBoxNome
            this.textBoxNome.Location = new System.Drawing.Point(80, 17);
            this.textBoxNome.Size = new System.Drawing.Size(200, 23);
            // labelDescricao
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(20, 60);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(58, 15);
            this.labelDescricao.Text = "Descrição";
            // textBoxDescricao
            this.textBoxDescricao.Location = new System.Drawing.Point(80, 57);
            this.textBoxDescricao.Size = new System.Drawing.Size(200, 23);
            // buttonSalvar
            this.buttonSalvar.Location = new System.Drawing.Point(80, 100);
            this.buttonSalvar.Size = new System.Drawing.Size(100, 30);
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // dataGridViewMedicamentos
            this.dataGridViewMedicamentos.Location = new System.Drawing.Point(320, 17);
            this.dataGridViewMedicamentos.Size = new System.Drawing.Size(400, 150);
            // MedicamentoForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 200);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.dataGridViewMedicamentos);
            this.Name = "MedicamentoForm";
            this.Text = "Medicamentos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
