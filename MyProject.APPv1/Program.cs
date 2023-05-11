using MyProject.APPv1;
using MyProject.BLL;
using MyProject.MODEL;


internal static class Program
{
    [STAThread]
    static void Main()
    {
        Projeto projeto = new Projeto();
        projeto.NomeDoProjeto = "Projeto Teste";
        projeto.NomeDoGerente = "Gerente Teste";
        projeto.InicioProjeto = DateTime.Today;
        projeto.FinalProjeto = new DateTime(2024, 07, 02, 22, 59, 59);
        projeto.ResumoProjeto = "Resumo Teste";
        projeto.StatusProjeto = "Status Teste";
        ProjetoRepository.Add(projeto);

        Console.WriteLine("Cadastro Teste Concluido");
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }
}