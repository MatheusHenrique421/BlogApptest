using Blog.Domain.Entities;
namespace Blog.Domain.Interfaces
{
  public interface IUsuarioRepository
  {
    Usuario GetByID(long usuarioId);
    Usuario GetTodos();
    void Salvar(Usuario usuario);
  }
}
