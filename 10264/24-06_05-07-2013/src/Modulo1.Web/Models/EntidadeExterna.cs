namespace Modulo1.Web.Models
{
	public class EntidadeExterna
	{
		public int Id { get; set; }
		public string Sistema { get; set; }

		public override string ToString()
		{
			return string.Format("Id: {0}, Sistema: {1}", Id, Sistema);
		}
	}
}