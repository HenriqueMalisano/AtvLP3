using MyProject.BLL;
using MyProject.MODEL;
using System;
using System.Windows.Forms;

namespace MyProject.APPv1
{
    public partial class FormEditProjeto : Form
    {
        private int idProjeto;
        public FormEditProjeto(int id)
        {
            InitializeComponent();
            idProjeto = id;
        }

        private void FormEditProjeto_Load(object sender, EventArgs e)
        {
            // Preenche o combobox de status com os possíveis valores
            string[] status = { "Em execução", "Finalizado", "Cancelado" };
            cmbStatusProjeto.Items.AddRange(status);

            // Busca os dados do projeto pelo id e preenche os campos
            Projeto projeto = ProjetoRepository.GetById(idProjeto);
            txtNomeDoProjeto.Text = projeto.NomeDoProjeto;
            txtNomeDoGerente.Text = projeto.NomeDoGerente;
            dtpInicioProjeto.Value = projeto.InicioProjeto;
            dtpFinalProjeto.Value = projeto.FinalProjeto;
            rtxtResumoProjeto.Text = projeto.ResumoProjeto;
            cmbStatusProjeto.SelectedItem = projeto.StatusProjeto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Atualiza os dados do projeto
            Projeto projeto = new Projeto
            {
                NomeDoProjeto = txtNomeDoProjeto.Text,
                NomeDoGerente = txtNomeDoGerente.Text,
                InicioProjeto = dtpInicioProjeto.Value,
                FinalProjeto = dtpFinalProjeto.Value,
                ResumoProjeto = rtxtResumoProjeto.Text,
                StatusProjeto = cmbStatusProjeto.SelectedItem.ToString()
            };

            ProjetoRepository.Update(idProjeto, projeto);
            MessageBox.Show("Projeto atualizado com sucesso!");
            this.Close();
        }
    }
}