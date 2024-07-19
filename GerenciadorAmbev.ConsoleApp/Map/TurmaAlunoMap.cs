using GerenciadorAmbev.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorAmbev.Data.Map
{
    public class TurmaAlunoMap : IEntityTypeConfiguration<TurmaAluno>
    {
        public void Configure(EntityTypeBuilder<TurmaAluno> builder)
        {
            builder.ToTable("TurmaAluno");
            builder.HasKey(x => new { x.IdTurma, x.IdAluno });

            builder.HasOne(x => x.Turma)
                .WithMany(x => x.TurmaAlunos)
                .HasForeignKey(x => x.IdTurma);

            builder.HasOne(x => x.Aluno)
                .WithMany(x => x.TurmaAluno)
                .HasForeignKey(x => x.IdAluno);

            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
