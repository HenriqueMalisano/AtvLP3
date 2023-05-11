using MyProject.BLL;
using MyProject.MODEL;
using MyProject.DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;

namespace MyProject.APPv1
{
    public partial class Form1 : Form
    {
        private void InitializeComponent()
        {
            Cadastrar_Projeto = new Button();
            Editar_Projeto = new Button();
            Excluir_Projeto = new Button();
            Atualizar_Tabela = new Button();
            Tabela_Projeto = new DataGridView();
            this.tabelaProjetos = new DataTable();
            this.conexao = new SqlConnection();
            this.adaptador = new SqlDataAdapter();
            this.idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nomeDoProjetoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nomeDoGerenteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.inicioProjetoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.finalProjetoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.resumoProjetoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.statusProjetoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.Finalizar_App = new Button();
            ((ISupportInitialize)Tabela_Projeto).BeginInit();
            ((ISupportInitialize)this.tabelaProjetos).BeginInit();
            SuspendLayout();
            // 
            // Cadastrar_Projeto
            // 
            Cadastrar_Projeto.Location = new Point(60, 12);
            Cadastrar_Projeto.Name = "Cadastrar_Projeto";
            Cadastrar_Projeto.Size = new Size(142, 23);
            Cadastrar_Projeto.TabIndex = 0;
            Cadastrar_Projeto.Text = "Cadastrar Projeto";
            Cadastrar_Projeto.UseVisualStyleBackColor = true;
            Cadastrar_Projeto.Click += Cadastrar_Projeto_Click;
            // 
            // Editar_Projeto
            // 
            Editar_Projeto.Location = new Point(208, 12);
            Editar_Projeto.Name = "Editar_Projeto";
            Editar_Projeto.Size = new Size(189, 23);
            Editar_Projeto.TabIndex = 1;
            Editar_Projeto.Text = "Editar Projeto Selecionado";
            Editar_Projeto.UseVisualStyleBackColor = true;
            Editar_Projeto.Click += Editar_Projeto_Click;
            // 
            // Excluir_Projeto
            // 
            Excluir_Projeto.Location = new Point(403, 12);
            Excluir_Projeto.Name = "Excluir_Projeto";
            Excluir_Projeto.Size = new Size(184, 23);
            Excluir_Projeto.TabIndex = 2;
            Excluir_Projeto.Text = "Excluir Projeto Selecionado";
            Excluir_Projeto.UseVisualStyleBackColor = true;
            Excluir_Projeto.Click += Excluir_Projeto_Click;
            // 
            // Atualizar_Tabela
            // 
            Atualizar_Tabela.Location = new Point(593, 12);
            Atualizar_Tabela.Name = "Atualizar_Tabela";
            Atualizar_Tabela.Size = new Size(117, 23);
            Atualizar_Tabela.TabIndex = 3;
            Atualizar_Tabela.Text = "Atualizar Tabela";
            Atualizar_Tabela.UseVisualStyleBackColor = true;
            Atualizar_Tabela.Click += Atualizar_Tabela_Click;
            // 
            // Tabela_Projeto
            // 
            Tabela_Projeto.AllowUserToAddRows = false;
            Tabela_Projeto.AllowUserToDeleteRows = false;
            Tabela_Projeto.AutoGenerateColumns = false;
            Tabela_Projeto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tabela_Projeto.Columns.AddRange(new DataGridViewColumn[] { this.idDataGridViewTextBoxColumn, this.nomeDoProjetoDataGridViewTextBoxColumn, this.nomeDoGerenteDataGridViewTextBoxColumn, this.inicioProjetoDataGridViewTextBoxColumn, this.finalProjetoDataGridViewTextBoxColumn, this.resumoProjetoDataGridViewTextBoxColumn, this.statusProjetoDataGridViewTextBoxColumn });
            Tabela_Projeto.DataSource = this.tabelaProjetos;
            Tabela_Projeto.Location = new Point(12, 76);
            Tabela_Projeto.Name = "Tabela_Projeto";
            Tabela_Projeto.ReadOnly = true;
            Tabela_Projeto.RowTemplate.Height = 25;
            Tabela_Projeto.Size = new Size(747, 346);
            Tabela_Projeto.TabIndex = 4;
            // 
            // tabelaProjetos
            // 
            this.tabelaProjetos.Namespace = "";
            // 
            // conexao
            // 
            this.conexao.AccessToken = null;
            this.conexao.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Henku\\source\\repos\\Av2Projeto\\MyProject.DAL\\database\\DatabaseProjeto.mdf;Integrated Security=True";
            this.conexao.Credential = null;
            this.conexao.FireInfoMessageEventOnUserErrors = false;
            this.conexao.StatisticsEnabled = false;
            // 
            // adaptador
            // 
            this.adaptador.DeleteCommand = null;
            this.adaptador.InsertCommand = null;
            this.adaptador.UpdateCommand = null;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDoProjetoDataGridViewTextBoxColumn
            // 
            this.nomeDoProjetoDataGridViewTextBoxColumn.DataPropertyName = "NomeDoProjeto";
            this.nomeDoProjetoDataGridViewTextBoxColumn.HeaderText = "NomeDoProjeto";
            this.nomeDoProjetoDataGridViewTextBoxColumn.Name = "nomeDoProjetoDataGridViewTextBoxColumn";
            this.nomeDoProjetoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDoGerenteDataGridViewTextBoxColumn
            // 
            this.nomeDoGerenteDataGridViewTextBoxColumn.DataPropertyName = "NomeDoGerente";
            this.nomeDoGerenteDataGridViewTextBoxColumn.HeaderText = "NomeDoGerente";
            this.nomeDoGerenteDataGridViewTextBoxColumn.Name = "nomeDoGerenteDataGridViewTextBoxColumn";
            this.nomeDoGerenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inicioProjetoDataGridViewTextBoxColumn
            // 
            this.inicioProjetoDataGridViewTextBoxColumn.DataPropertyName = "InicioProjeto";
            this.inicioProjetoDataGridViewTextBoxColumn.HeaderText = "InicioProjeto";
            this.inicioProjetoDataGridViewTextBoxColumn.Name = "inicioProjetoDataGridViewTextBoxColumn";
            this.inicioProjetoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalProjetoDataGridViewTextBoxColumn
            // 
            this.finalProjetoDataGridViewTextBoxColumn.DataPropertyName = "FinalProjeto";
            this.finalProjetoDataGridViewTextBoxColumn.HeaderText = "FinalProjeto";
            this.finalProjetoDataGridViewTextBoxColumn.Name = "finalProjetoDataGridViewTextBoxColumn";
            this.finalProjetoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resumoProjetoDataGridViewTextBoxColumn
            // 
            this.resumoProjetoDataGridViewTextBoxColumn.DataPropertyName = "ResumoProjeto";
            this.resumoProjetoDataGridViewTextBoxColumn.HeaderText = "ResumoProjeto";
            this.resumoProjetoDataGridViewTextBoxColumn.Name = "resumoProjetoDataGridViewTextBoxColumn";
            this.resumoProjetoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusProjetoDataGridViewTextBoxColumn
            // 
            this.statusProjetoDataGridViewTextBoxColumn.DataPropertyName = "StatusProjeto";
            this.statusProjetoDataGridViewTextBoxColumn.HeaderText = "StatusProjeto";
            this.statusProjetoDataGridViewTextBoxColumn.Name = "statusProjetoDataGridViewTextBoxColumn";
            this.statusProjetoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Finalizar_App
            // 
            this.Finalizar_App.Location = new Point(339, 41);
            this.Finalizar_App.Name = "Finalizar_App";
            this.Finalizar_App.Size = new Size(75, 23);
            this.Finalizar_App.TabIndex = 5;
            this.Finalizar_App.Text = "Finalizar";
            this.Finalizar_App.UseVisualStyleBackColor = true;
            this.Finalizar_App.Click += this.Finalizar_App_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(768, 437);
            Controls.Add(this.Finalizar_App);
            Controls.Add(Tabela_Projeto);
            Controls.Add(Atualizar_Tabela);
            Controls.Add(Excluir_Projeto);
            Controls.Add(Editar_Projeto);
            Controls.Add(Cadastrar_Projeto);
            Name = "Form1";
            ((ISupportInitialize)Tabela_Projeto).EndInit();
            ((ISupportInitialize)this.tabelaProjetos).EndInit();
            ResumeLayout(false);
        }

        public Form1()
        {
            InitializeComponent();
            PreencherTabela();
        }

        private void Cadastrar_Projeto_Click(object sender, EventArgs e)
        {
            FormAddProjeto formCadastrarProjeto = new FormAddProjeto();
            formCadastrarProjeto.Show();
        }

        private void Editar_Projeto_Click(object sender, EventArgs e)
        {
            if (Tabela_Projeto.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(Tabela_Projeto.SelectedRows[0].Cells[0].Value);
                FormEditProjeto formEditProjeto = new FormEditProjeto(id);
                formEditProjeto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um projeto para editar.");
            }
        }

        private void Excluir_Projeto_Click(object sender, EventArgs e)
        {
            if (Tabela_Projeto.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(Tabela_Projeto.SelectedRows[0].Cells[0].Value);
                ProjetoRepository.Excluir(ProjetoRepository.GetById(id));
                AtualizarTabela();
                MessageBox.Show("Projeto de id " + id + " Excluido");
            }
            else
            {
                MessageBox.Show("Selecione um projeto para excluir.");
            }
        }

        private void Atualizar_Tabela_Click(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void PreencherTabela()
        {
            tabelaProjetos.Clear();
            adaptador.SelectCommand = new SqlCommand("SELECT * FROM PROJETO", conexao);
            adaptador.Fill(tabelaProjetos);
            Tabela_Projeto.DataSource = tabelaProjetos;
        }

        private void Finalizar_App_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}