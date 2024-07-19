using GerenciadorAmbev.Data.Repository;
using GerenciadorAmbev.Domain.Model;

class Program
{
    static void Main(string[] args)
    {
        IncluirProfessor();
        var prof = ConsultarTodosProfessor();
        if (prof?.Count > 0) {
            AlterarNomeProfessor(prof[0]);
            ExcluirProfessor(prof[1].Id);
        }

    }

    private static void IncluirProfessor()
    {
        var repoProfessor = new ProfessorRepository();
        repoProfessor.Incluir(Professor.NovoProfessor("Prof Thamy", "email", Turno.Manha));
        repoProfessor.Incluir(Professor.NovoProfessor("Prof Gab", "email", Turno.Tarde));
    }
    private static void AlterarNomeProfessor(Professor prof)
    {
        var repoProfessor = new ProfessorRepository();
        repoProfessor.Alterar(prof.AlterarNome("Prof Thami"));
    }
    private static List<Professor> ConsultarTodosProfessor()
    {
        var repoProfessor = new ProfessorRepository();
        return repoProfessor.SelecionarTudo();
    }

    private static void ExcluirProfessor(int id)
    {
        var repoProfessor = new ProfessorRepository();
        repoProfessor.Excluir(id);
    }
}