namespace Wise.Negocio
{
    public class AutenticacaoService
    {
        public bool Autenticar(string nome, string senha)
        {
            return nome.Equals("tiago") && senha.Equals("!@#");
        }
    }
}
