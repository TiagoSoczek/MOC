namespace Modulo1.Web.Models
{
	public class EntidadeExterna
	{
		private string _valores;

		public EntidadeExterna()
		{
		}

		public EntidadeExterna(string item)
		{
			string[] valores = item.Split('@');

			var id = int.Parse(valores[0]);
			var sistema = valores[1];

			Id = id;
			Sistema = sistema;
		}

		public int Id { get; set; }
		public string Sistema { get; set; }

		public override string ToString()
		{
			return string.Format("Id: {0}, Sistema: {1}", Id, Sistema);
		}
	}
}