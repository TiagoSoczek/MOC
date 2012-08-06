namespace Modulo3.Core
{
    public class Autenticacao
    {
        public bool Autenticar(string login, string senha)
        {
            // TODO: Utilizar o banco de dados
            return login == "tiago" && senha == "soczek";
        }
    }
}
