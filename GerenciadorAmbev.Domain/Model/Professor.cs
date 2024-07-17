using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorAmbev.Domain.Model
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Turno Turno { get; set; }
        public string Banco {  get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public List<Turma> Turmas { get; set; } = new List<Turma>();

        public static Professor NovoProfessor(string nome, string email, Turno turno)
        {
            var prof = new Professor();
            prof.Nome = nome;
            prof.Email = email;
            prof.Turno = turno;

            return prof;
        }
    }
}
