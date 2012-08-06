namespace Modulo9.Shell
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Produto> todosProdutos = CarregarProdutos();

            bool todosAbaixoDe100 = todosProdutos.All(p => p.Preco < 100);
            bool algumAbaixoDe100 = todosProdutos.Any(p => p.Preco < 100);

            var primeiro = todosProdutos.First();
            var primeiroMaior50 = todosProdutos.
                OrderBy(p => p.Preco).First(p => p.Preco > 50);

            List<string> nomes = 
                todosProdutos.Select(p => p.Nome).ToList();

            List<Produto> produtosAcima50 = new List<Produto>();

            produtosAcima50 = todosProdutos.Where(p => p.Preco > 50).ToList();

            var produtosPorDiaSemana = todosProdutos.
                GroupBy(p => p.CadastradoEm.DayOfWeek).ToList();

            foreach (var grupo in produtosPorDiaSemana)
            {
                Console.WriteLine(grupo.Key);
                Console.WriteLine("Min: " + grupo.Min(g => g.Preco));
                Console.WriteLine("Med: " + grupo.Average(g => g.Preco));
                Console.WriteLine("Max: " + grupo.Max(g => g.Preco));
            }

            var produtosAcima50NaQuarta = todosProdutos.
                Where(p => p.Preco > 50 && 
                    p.CadastradoEm.DayOfWeek == DayOfWeek.Wednesday).ToList();

            var produtosCom5 = todosProdutos.
                Where(p => p.Nome.Contains("5") &&
                    p.Preco.ToString().Contains("5")).
                  OrderByDescending(p => p.Preco).
                  ThenBy(p => p.CadastradoEm)
                  .ToList();

            var produtosAcima10 = from p in todosProdutos 
                                  where p.Preco > 10 
                                  select p;
            
            Produto primeiroMaiorQue100 =
                todosProdutos.FirstOrDefault(p => p.Preco > 100);

            Produto ultimoMaiorQue100 =
                todosProdutos.LastOrDefault(p => p.Preco > 100);
        }

        private static List<Produto> CarregarProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            Random rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                Produto p = new Produto();
                p.Id = i;
                p.Nome = "Produto#" + i;
                p.CadastradoEm = DateTime.Now.Subtract(TimeSpan.FromDays(i));
                p.Preco = rnd.Next(0, 100);

                produtos.Add(p);
            }

            return produtos;
        }
    }

    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        
        public DateTime CadastradoEm { get; set; }

        public double Preco { get; set; }
    }
}
