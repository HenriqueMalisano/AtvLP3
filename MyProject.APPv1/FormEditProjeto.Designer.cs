namespace MyProject.APPv1
{
    partial class FormEditProjeto
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
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            cmbStatusProjeto = new ComboBox();
            rtxtResumoProjeto = new RichTextBox();
            dtpFinalProjeto = new DateTimePicker();
            dtpInicioProjeto = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNomeDoGerente = new TextBox();
            label2 = new Label();
            txtNomeDoProjeto = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 335);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 31;
            label7.Tag = "Status do projeto";
            label7.Text = "Status do projeto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 31);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 30;
            label6.Tag = "Nome do projeto";
            label6.Text = "Nome do projeto";
            // 
            // button1
            // 
            button1.Location = new Point(64, 393);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 28;
            button1.Tag = "btnEditSalvar";
            button1.Text = "Salvar Edição";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbStatusProjeto
            // 
            cmbStatusProjeto.FormattingEnabled = true;
            cmbStatusProjeto.Location = new Point(30, 353);
            cmbStatusProjeto.Name = "cmbStatusProjeto";
            cmbStatusProjeto.Size = new Size(200, 23);
            cmbStatusProjeto.TabIndex = 27;
            cmbStatusProjeto.Tag = "cmbEditStatusProjeto";
            // 
            // rtxtResumoProjeto
            // 
            rtxtResumoProjeto.Location = new Point(30, 232);
            rtxtResumoProjeto.Name = "rtxtResumoProjeto";
            rtxtResumoProjeto.Size = new Size(200, 96);
            rtxtResumoProjeto.TabIndex = 26;
            rtxtResumoProjeto.Tag = "rtxtEditResumoProjeto";
            rtxtResumoProjeto.Text = "";
            // 
            // dtpFinalProjeto
            // 
            dtpFinalProjeto.Location = new Point(30, 188);
            dtpFinalProjeto.Name = "dtpFinalProjeto";
            dtpFinalProjeto.Size = new Size(200, 23);
            dtpFinalProjeto.TabIndex = 25;
            dtpFinalProjeto.Tag = "dtpEditFinalProjeto";
            // 
            // dtpInicioProjeto
            // 
            dtpInicioProjeto.Location = new Point(30, 141);
            dtpInicioProjeto.Name = "dtpInicioProjeto";
            dtpInicioProjeto.Size = new Size(200, 23);
            dtpInicioProjeto.TabIndex = 24;
            dtpInicioProjeto.Tag = "dtpEditInicioProjeto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 214);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 23;
            label5.Tag = "Resumo do projeto";
            label5.Text = "Resumo do projeto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 119);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 22;
            label3.Tag = "Data de início";
            label3.Text = "Data de início";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 167);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 21;
            label4.Tag = "Data final";
            label4.Text = "Data final";
            // 
            // txtNomeDoGerente
            // 
            txtNomeDoGerente.Location = new Point(30, 93);
            txtNomeDoGerente.Name = "txtNomeDoGerente";
            txtNomeDoGerente.Size = new Size(200, 23);
            txtNomeDoGerente.TabIndex = 20;
            txtNomeDoGerente.Tag = "txtEditNomeDoGerente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 75);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 19;
            label2.Tag = "Nome do gerente";
            label2.Text = "Nome do gerente";
            // 
            // txtNomeDoProjeto
            // 
            txtNomeDoProjeto.Location = new Point(30, 49);
            txtNomeDoProjeto.Name = "txtNomeDoProjeto";
            txtNomeDoProjeto.Size = new Size(200, 23);
            txtNomeDoProjeto.TabIndex = 18;
            txtNomeDoProjeto.Tag = "txtEditNomeDoProjeto";
            // 
            // label1
            // 
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 29;
            // 
            // FormEditProjeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 469);
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
            Name = "FormEditProjeto";
            Text = "FormEditProjeto";
            Load += FormEditProjeto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Button button1;
        private ComboBox cmbStatusProjeto;
        private RichTextBox rtxtResumoProjeto;
        private DateTimePicker dtpFinalProjeto;
        private DateTimePicker dtpInicioProjeto;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txtNomeDoGerente;
        private Label label2;
        private TextBox txtNomeDoProjeto;
        private Label label1;
    }
}