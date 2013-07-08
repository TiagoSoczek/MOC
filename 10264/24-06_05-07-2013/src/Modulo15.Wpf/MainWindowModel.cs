namespace Modulo15.Wpf
{
	using System;
	using System.ComponentModel;
	using System.Threading;
	using System.Windows.Input;
	using MVVM;

	public class MainWindowModel : BaseNotifyPropertyChanged
	{
		private string _usuario;
		private string _senha;
		private string _resultado;
		private bool _processando;

		public MainWindowModel()
		{
			Usuario = "tiago";
			Senha = "1234567890";
		}

		public bool Processando
		{
			get { return _processando; }
			set
			{
				_processando = value;
				RaisePropertyChanged("Processando");
			}
		}

		public string Resultado
		{
			get { return _resultado; }
			set
			{
				_resultado = value; 
				RaisePropertyChanged("Resultado");
			}
		}

		public string Usuario
		{
			get { return _usuario; }
			set
			{
				_usuario = value;
				RaisePropertyChanged("Usuario");
			}
		}

		public string Senha
		{
			get { return _senha; }
			set
			{
				_senha = value;
				RaisePropertyChanged("Senha");
			}
		}

		public ICommand LoginCommand
		{
			get
			{
				return new RelayCommand(Login, PodeLogar);
			}
		}

		private bool PodeLogar()
		{
			return  !Processando &&
					!string.IsNullOrWhiteSpace(Usuario) &&
			        !string.IsNullOrWhiteSpace(Senha);
		}

		private void Login()
		{
			Processando = true;

			BackgroundWorker bw = new BackgroundWorker();

			bw.DoWork += delegate(object sender, DoWorkEventArgs args)
			{
				Thread.Sleep(TimeSpan.FromSeconds(10));

				args.Result = "Login efetuado com sucesso!";
			};

			bw.RunWorkerCompleted += delegate(object sender, RunWorkerCompletedEventArgs args)
			{
				Processando = false;

				Resultado = args.Result.ToString();
			};

			bw.RunWorkerAsync();
		}
	}
}