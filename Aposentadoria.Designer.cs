namespace RM98690___LOGIN_E_INSS
{
    partial class Aposentadoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aposentadoria));
            label1 = new Label();
            txtIdade = new TextBox();
            label2 = new Label();
            txtAnosTrabalhados = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            cmbGenero = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Azure;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(393, 117);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Idade";
            label1.Click += label1_Click;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(459, 115);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(226, 27);
            txtIdade.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Azure;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(390, 163);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 2;
            label2.Text = "Anos trabalhados";
            // 
            // txtAnosTrabalhados
            // 
            txtAnosTrabalhados.Location = new Point(560, 161);
            txtAnosTrabalhados.Name = "txtAnosTrabalhados";
            txtAnosTrabalhados.Size = new Size(125, 27);
            txtAnosTrabalhados.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(500, 272);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Azure;
            lblResultado.Location = new Point(444, 314);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(21, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "   ";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cmbGenero.Location = new Point(473, 210);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(212, 28);
            cmbGenero.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Azure;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(393, 213);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 7;
            label3.Text = "Gênero";
            // 
            // Aposentadoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(731, 349);
            Controls.Add(label3);
            Controls.Add(cmbGenero);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAnosTrabalhados);
            Controls.Add(label2);
            Controls.Add(txtIdade);
            Controls.Add(label1);
            Name = "Aposentadoria";
            Text = "Aposentadoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdade;
        private Label label2;
        private TextBox txtAnosTrabalhados;
        private Button btnCalcular;
        private Label lblResultado;
        private ComboBox cmbGenero;
        private Label label3;
    }
}