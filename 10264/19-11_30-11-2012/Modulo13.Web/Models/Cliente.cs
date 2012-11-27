using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modulo13.Web.Models
{
	public class Cliente
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public DateTime DataNascimento { get; set; }
		public int TotalPedidos { get; set; }
	}
}