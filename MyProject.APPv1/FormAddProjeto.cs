using MyProject.BLL;
using MyProject.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.APPv1
{
    public partial class FormAddProjeto : Form
    {
        public FormAddProjeto()
        {
            InitializeComponent();
        }

        private void FormAddProjeto_Load(object sender, EventArgs e)
        {
            // Preenche o combobox de status com os possíveis valores
            string[] status = { "Em execução", "Finalizado", "Cancelado" };
            cmbStatusProjeto.Items.AddRange(status);
            cmbStatusProjeto.SelectedIndex = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria um novo projeto com os dados do form
            Projeto projeto = new Projeto
            {
                NomeDoProjeto = txtNomeDoProjeto.Text,
                NomeDoGerente = txtNomeDoGerente.Text,
                InicioProjeto = dtpInicioProjeto.Value,
                FinalProjeto = dtpFinalProjeto.Value,
                ResumoProjeto = rtxtResumoProjeto.Text,
                StatusProjeto = cmbStatusProjeto.SelectedItem.ToString()
            };

            // Adiciona o projeto no banco de dados e fecha o form
            ProjetoRepository.Add(projeto);
            MessageBox.Show("Projeto adicionado com sucesso!");
            FormAddProjeto formAddProjeto = new FormAddProjeto();
            formAddProjeto.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
