using Blog.Domain.Interfaces;
using Blog.Domain.Entities;
using System;
namespace Blog.Infra.Data.Repositories
{
  public class UsuarioRepository : IUsuarioRepository
  {
    public Usuario GetByID(long usuarioId)
    {
      throw new NotImplementedException();
    }
    public Usuario GetTodos()
    {
      throw new NotImplementedException();
    }
    public void Salvar(Usuario usuario)
    {
      throw new NotImplementedException();
    }
  }
}
