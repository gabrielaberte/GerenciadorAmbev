﻿namespace GerenciadorAmbev.Domain.Entities
{
    internal class ProdutoAcabado
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Ativo { get; set; }
    }
}
