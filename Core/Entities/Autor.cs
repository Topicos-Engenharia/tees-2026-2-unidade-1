using Core.Interfaces.Entity;

namespace Core.Entities;

public partial class Autor : IEntity
{
    public uint Id { get; set; }

    public string Nome { get; set; } = null!;

    public DateTime DataNascimento { get; set; }

    public virtual ICollection<Livro> IdLivros { get; set; } = new List<Livro>();
}
