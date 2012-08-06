
namespace Modulo2.Web
{
    public class ValidacaoNome
    {
        public bool Validar(string nome)
        {
            if (nome == "tiago")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}