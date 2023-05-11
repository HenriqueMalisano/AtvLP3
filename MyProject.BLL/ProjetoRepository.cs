using MyProject.MODEL;
using MyProject.DAL.DBContextProjeto;

namespace MyProject.BLL
{
    public class ProjetoRepository
    {
        public static void Add(Projeto _projeto)
        {

            using (var dbContext = new CUsersHenkuSourceReposAv2projetoMyprojectDalDatabaseDatabaseprojetoMdfContext())
            {
                dbContext.Add(_projeto);
                dbContext.SaveChanges();
            }

        }

        public static Projeto GetById(int id)
        {
            using (var dbContext = new CUsersHenkuSourceReposAv2projetoMyprojectDalDatabaseDatabaseprojetoMdfContext())
            {
                var projeto = dbContext.Projetos.Single(p => p.Id == id);
                return projeto;
            }
        }

        public static List<Projeto> GetAll()
        {

            using (var dbContext = new CUsersHenkuSourceReposAv2projetoMyprojectDalDatabaseDatabaseprojetoMdfContext())
            {
                var projeto = dbContext.Projetos.ToList();
                return projeto;
            }

        }

        public static void Update(int id, Projeto newProjeto)
        {
            using (var dbContext = new CUsersHenkuSourceReposAv2projetoMyprojectDalDatabaseDatabaseprojetoMdfContext())
            {
                var projeto = dbContext.Projetos.Single(p => p.Id == id);
                projeto.NomeDoProjeto = newProjeto.NomeDoProjeto;
                projeto.NomeDoGerente = newProjeto.NomeDoGerente;
                projeto.InicioProjeto = newProjeto.InicioProjeto;
                projeto.FinalProjeto = newProjeto.FinalProjeto;
                projeto.ResumoProjeto = newProjeto.ResumoProjeto;
                projeto.StatusProjeto = newProjeto.StatusProjeto;
                dbContext.SaveChanges();
            }

        }

        public static void Excluir(Projeto _projeto)
        {

            using (var dbContext = new CUsersHenkuSourceReposAv2projetoMyprojectDalDatabaseDatabaseprojetoMdfContext())
            {
                var projeto = dbContext.Projetos.Single(p => p.Id == _projeto.Id);
                dbContext.Remove(projeto);
                dbContext.SaveChanges() ;
            }

        }
    }
}