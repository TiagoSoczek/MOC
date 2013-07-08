namespace ExemploADO.Model
{
	public class Modelo
	{
		public int Id { get; set; }
		public string Marca { get; set; }
		public string Nome { get; set; }

		public override string ToString()
		{
			return string.Format("Id: {0}, Marca: {1}, Nome: {2}", Id, Marca, Nome);
		}
	}
}