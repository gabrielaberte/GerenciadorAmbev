namespace GerenciadorAmbev.Domain.Entities
{
    public class MateriaPrima
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public UnitMeasure UnitMeasure { get; set; }
        public bool Ativo { get; set; }
    }
}


//Materia prima: guid, cod: ki01, nome: agua gas, un. med: mililitros