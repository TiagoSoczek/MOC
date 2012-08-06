namespace Modulo10.DataAccess
{
    using System.Data.Objects;
    using System.Linq;

    public class AutenticacaoService
    {
        public bool Autenticar(string nome, string senha)
        {
            UsuarioRepository repository = new UsuarioRepository();

            Usuario usuario = repository.ObterPorNome(nome);

            if (usuario == null)
            {
                return false;
            }

            return usuario.Senha.Equals(senha);
        }
    }

    public class UsuarioRepository
    {
        public Usuario ObterPorNome(string nome)
        {
            MOC10267Entities db = new MOC10267Entities();

            var usuario = db.Usuarios.FirstOrDefault(u => u.Email.Equals(nome));

            return usuario;
        }
    }
}