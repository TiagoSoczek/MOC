namespace Modulo5.Editor
{
	using System;
	using System.Windows;
	using Microsoft.Win32;
	using System.IO;

	/// <summary>
	///     Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();

			bool? resultado = dialog.ShowDialog();

			if (!resultado.GetValueOrDefault())
			{
				return;
			}

			string conteudo = File.ReadAllText(dialog.FileName);

			txtConteudo.Text = conteudo;
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();

			var resultado = dialog.ShowDialog();

			if (!resultado.GetValueOrDefault())
			{
				return;
			}

			var conteudo = txtConteudo.Text;

			File.WriteAllText(dialog.FileName, conteudo);
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			// Caminho que iniciou o .EXE
			var currentDir = Environment.CurrentDirectory;

			// Caminho garantido do .EXE
			var pathDoExe = AppDomain.CurrentDomain.BaseDirectory;

			var pathCompleto = Path.Combine(pathDoExe, "readme.txt");

			File.WriteAllText(pathCompleto, txtConteudo.Text);

			var ioPath = Path.Combine(pathDoExe, "Teste", "IO");

			// Directory.CreateDirectory(ioPath);

			var ioDir = new DirectoryInfo(ioPath);

			ioDir.Refresh();

			if (!ioDir.Exists)
			{
				ioDir.Create();
			}

			FileInfo[] todosArquivos = ioDir.GetFiles();
			
			int i = 0;

			foreach (FileInfo arquivo in todosArquivos)
			{
				var nomeSemExtensao = Path.
					GetFileNameWithoutExtension(arquivo.FullName);

				int numeroArquivo;

				if (int.TryParse(nomeSemExtensao, out numeroArquivo))
				{
					i = Math.Max(i, numeroArquivo);
				}
			}

			var limite = i + 100;

			for (; i <  limite; i++)
			{
				using (var fileStream = File.Create(Path.Combine(ioPath, i + ".txt")))
				using (var streamWriter = new StreamWriter(fileStream))
				{
					streamWriter.Write(txtConteudo.Text);
				}
			}
		}
	}
}