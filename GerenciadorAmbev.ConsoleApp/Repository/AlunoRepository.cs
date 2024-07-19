using GerenciadorAmbev.ConsoleApp;
using GerenciadorAmbev.Domain.Model;

namespace GerenciadorAmbev.Data.Repository
{
    public class AlunoRepository
    {
        protected readonly Contexto contexto;
        public AlunoRepository()
        {
            contexto = new Contexto();
        }
        public List<Aluno> SelecionarTudo()
        {
            return contexto.Aluno.ToList();
        }

        public void Incluir(Aluno aluno)
        {
            contexto.Aluno.Add(aluno);
            contexto.SaveChanges();
        }
        public void Alterar(Aluno aluno)
        {
            contexto.Aluno.Update(aluno);
            contexto.SaveChanges();
        }
        public Aluno Selecionar(int id)
        {
           return contexto.Aluno.FirstOrDefault(x => x.Id == id);
        }
        public void Excluir(int id)
        {
            var aluno = Selecionar(id);
            contexto.Aluno.Remove(aluno);
            contexto.SaveChanges();
        }
      public void Dispose()
    {
            contexto.Dispose();
    } 
    }

 

}
