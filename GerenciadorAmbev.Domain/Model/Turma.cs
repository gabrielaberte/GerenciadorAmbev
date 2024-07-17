﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorAmbev.Domain.Model
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int IdProfessor { get; set; }
        public Professor Professor { get; set; }
    }
}
