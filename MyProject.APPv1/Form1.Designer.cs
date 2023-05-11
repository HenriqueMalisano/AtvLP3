using MyProject.BLL;
using MyProject.MODEL;
using MyProject.DAL;

namespace MyProject.APPv1
{
    public partial class Form1 : Form
    {
        private Button Cadastrar_Projeto;
        private Button Editar_Projeto;
        private Button Excluir_Projeto;
        private Button Atualizar_Tabela;
        private DataGridView Tabela_Projeto;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDoProjetoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDoGerenteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inicioProjetoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn finalProjetoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resumoProjetoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusProjetoDataGridViewTextBoxColumn;
        private System.Data.DataTable tabelaProjetos;
        private System.Data.SqlClient.SqlConnection conexao;
        private System.Data.SqlClient.SqlDataAdapter adaptador;
        private Button Finalizar_App;
    }
}