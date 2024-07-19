using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorAmbev.Domain.Model
{
    public class Aluno
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Ativo { get; private set; }
        public List<TurmaAluno> TurmaAluno { get; private set; }
        public static Aluno NovoAluno(string nome)
        {
            var aluno = new Aluno();
            aluno.Nome = nome;
            aluno.Ativo = "true";
            return aluno;
        }
        public Aluno AlterarNome(string novoNome)
        {
            Nome = novoNome;

            return this;
        }
    }
}
