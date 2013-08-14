namespace Modulo12.Model
{
	public class ProdutoDto
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public decimal Preco { get; set; }
		public bool Ativo { get; set; }

		public override string ToString()
		{
			return string.Format("Id: {0}, Nome: {1}, Preco: {2}", Id, Nome, Preco);
		}
	}
}