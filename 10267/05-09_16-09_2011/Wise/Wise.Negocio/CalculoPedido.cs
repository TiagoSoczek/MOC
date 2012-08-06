namespace Wise.Negocio
{
    public class CalculoPedido
    {
        private int _qtdeProdutos;

        public CalculoPedido(int qtdeProdutos)
        {
            _qtdeProdutos = qtdeProdutos;
        }

        public int CalcularTotal()
        {
            return _qtdeProdutos * _qtdeProdutos;
        }

        public override string ToString()
        {
            return "Cálculo Padrão";
        }
    }
}
