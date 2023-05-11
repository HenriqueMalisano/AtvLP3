namespace MyProject.APPv1
{
    partial class FormAddProjeto
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
            label1 = new Label();
            txtNomeDoProjeto = new TextBox();
            label2 = new Label();
            txtNomeDoGerente = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpInicioProjeto = new DateTimePicker();
            dtpFinalProjeto = new DateTimePicker();
            rtxtResumoProjeto = new RichTextBox();
            cmbStatusProjeto = new ComboBox();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 15;
            // 
            // txtNomeDoProjeto
            // 
            txtNomeDoProjeto.Location = new Point(12, 30);
            txtNomeDoProjeto.Name = "txtNomeDoProjeto";
            txtNomeDoProjeto.Size = new Size(200, 23);
            txtNomeDoProjeto.TabIndex = 1;
            txtNomeDoProjeto.Tag = "txtNomeDoProjeto";
            txtNomeDoProjeto.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Tag = "Nome do gerente";
            label2.Text = "Nome do gerente";
            // 
            // txtNomeDoGerente
            // 
            txtNomeDoGerente.Location = new Point(12, 74);
            txtNomeDoGerente.Name = "txtNomeDoGerente";
            txtNomeDoGerente.Size = new Size(200, 23);
            txtNomeDoGerente.TabIndex = 3;
            txtNomeDoGerente.Tag = "txtNomeDoGerente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 6;
            label3.Tag = "Data de início";
            label3.Text = "Data de início";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 148);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Tag = "Data final";
            label4.Text = "Data final";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 195);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 8;
            label5.Tag = "Resumo do projeto";
            label5.Text = "Resumo do projeto";
            // 
            // dtpInicioProjeto
            // 
            dtpInicioProjeto.Location = new Point(12, 122);
            dtpInicioProjeto.Name = "dtpInicioProjeto";
            dtpInicioProjeto.Size = new Size(200, 23);
            dtpInicioProjeto.TabIndex = 10;
            dtpInicioProjeto.Tag = "dtpInicioProjeto";
            // 
            // dtpFinalProjeto
            // 
            dtpFinalProjeto.Location = new Point(12, 169);
            dtpFinalProjeto.Name = "dtpFinalProjeto";
            dtpFinalProjeto.Size = new Size(200, 23);
            dtpFinalProjeto.TabIndex = 11;
            dtpFinalProjeto.Tag = "dtpFinalProjeto";
            // 
            // rtxtResumoProjeto
            // 
            rtxtResumoProjeto.Location = new Point(12, 213);
            rtxtResumoProjeto.Name = "rtxtResumoProjeto";
            rtxtResumoProjeto.Size = new Size(200, 96);
            rtxtResumoProjeto.TabIndex = 12;
            rtxtResumoProjeto.Tag = "rtxtResumoProjeto";
            rtxtResumoProjeto.Text = "";
            // 
            // cmbStatusProjeto
            // 
            cmbStatusProjeto.FormattingEnabled = true;
            cmbStatusProjeto.Location = new Point(12, 334);
            cmbStatusProjeto.Name = "cmbStatusProjeto";
            cmbStatusProjeto.Size = new Size(200, 23);
            cmbStatusProjeto.TabIndex = 13;
            cmbStatusProjeto.Tag = "cmbStatusProjeto";
            // 
            // button1
            // 
            button1.Location = new Point(72, 363);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Tag = "btnSalvar";
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 12);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 16;
            label6.Tag = "Nome do projeto";
            label6.Text = "Nome do projeto";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 316);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 17;
            label7.Tag = "Status do projeto";
            label7.Text = "Status do projeto";
            // 
            // FormAddProjeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 396);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(cmbStatusProjeto);
            Controls.Add(rtxtResumoProjeto);
            Controls.Add(dtpFinalProjeto);
            Controls.Add(dtpInicioProjeto);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtNomeDoGerente);
            Controls.Add(label2);
            Controls.Add(txtNomeDoProjeto);
            Controls.Add(label1);
            Name = "FormAddProjeto";
            Text = "FormAddProjeto";
            Load += FormAddProjeto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeDoProjeto;
        private Label label2;
        private TextBox txtNomeDoGerente;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpInicioProjeto;
        private DateTimePicker dtpFinalProjeto;
        private RichTextBox rtxtResumoProjeto;
        private ComboBox cmbStatusProjeto;
        private Button button1;
        private Label label6;
        private Label label7;
        private Button button2;
    }
}