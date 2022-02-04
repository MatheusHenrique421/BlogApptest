using FluentNHibernate.Mapping;
using Blog.Domain.Entities;

namespace Blog.Infra.Data.Mapping
{
  public class UsuarioMap : ClassMap<Usuario>
  {
    public UsuarioMap()
    {
      Table("Usuario");

      Id(x => x.Id);

      Map(x => x.Nome);
      Map(x => x.Sobrenome);
      Map(x => x.Idade);
    }
  }
}
