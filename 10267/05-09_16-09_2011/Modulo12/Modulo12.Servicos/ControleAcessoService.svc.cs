namespace Modulo12.Servicos
{
    public class ControleAcessoService : IControleAcessoService
    {
        public bool Validar(string nome, string senha)
        {
            bool usuarioValido = nome.Equals("tiago") &&
                                    senha.Equals("123");

            return usuarioValido;
        }

        public bool ValidarNome(string nome)
        {
            return string.IsNullOrWhiteSpace(nome);
        }
    }
}
