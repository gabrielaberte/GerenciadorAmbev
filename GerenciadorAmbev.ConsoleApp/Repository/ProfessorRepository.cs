using GerenciadorAmbev.ConsoleApp;
using GerenciadorAmbev.Domain.Model;

namespace GerenciadorAmbev.Data.Repository
{
    public class ProfessorRepository
    {
        protected readonly Contexto contexto;
        public ProfessorRepository()
        {
            contexto = new Contexto();
        }
        public List<Professor> SelecionarTudo()
        {
            return contexto.Professor.ToList();
        }

        public void Incluir(Professor prof)
        {
            contexto.Professor.Add(prof);
            contexto.SaveChanges();
        }
        public void Alterar(Professor prof)
        {
            contexto.Professor.Update(prof);
            contexto.SaveChanges();
        }
        public Professor Selecionar(int id)
        {
            return contexto.Professor.FirstOrDefault(x => x.Id == id);
        }
        public void Excluir(int id)
        {
            var prof = Selecionar(id);
            contexto.Professor.Remove(prof);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }
    }



}
