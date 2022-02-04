namespace Blog.Domain.Entities
{
  public class Usuario
  {
    public virtual long Id { get; set; }
    public virtual string Nome { get; set; }
    public virtual string Sobrenome { get; set; }
    public virtual string Idade { get; set; }
  }
}
