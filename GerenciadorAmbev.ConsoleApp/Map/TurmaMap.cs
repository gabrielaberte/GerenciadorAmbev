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
    public class TurmaMap : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.ToTable("Turma");
            builder.HasKey(x =>x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(150)");
            builder.Property(x => x.Descricao).HasColumnType("nvarchar(500)");
            builder.HasOne(t => t.Professor).WithMany(tp => tp.Turmas).HasForeignKey(i => i.IdProfessor);
        }
    }
}
