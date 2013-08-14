namespace Modulo16.Wpf
{
	using System.ComponentModel;
	using System.Runtime.InteropServices;
	using System.Threading;
	using System.Windows;
	using System.Windows.Input;
	using MVVM;

	public class LoginViewModel : BaseNotifyPropertyChanged
	{
		private string _senha;
		private string _usuario;
		private int _valorSlider;

		public LoginViewModel()
		{
			Usuario = "usuario";
			ValorSlider = 500;
		}

		public int ValorSlider
		{
			get { return _valorSlider; }
			set
			{
				_valorSlider = value;
				RaisePropertyChanged("ValorSlider");
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

		public ICommand ResetCommand
		{
			get
			{
				return new RelayCommand(Reset);
			}
		}

		private void Reset()
		{
			Usuario = string.Empty;
			Senha = string.Empty;

			var bw = new BackgroundWorker();

			bw.DoWork += delegate
			{
				for (int i = ValorSlider; i < 500; i++)
				{
					ValorSlider++;
					Thread.Sleep(10);
				}
			};

			bw.RunWorkerAsync();
		}

		public ICommand LoginCommand
		{
			get
			{
				return new RelayCommand(Logar, PodeLogar);
			}
		}

		private bool PodeLogar()
		{
			return !string.IsNullOrWhiteSpace(Usuario) &&
				!string.IsNullOrWhiteSpace(Senha);
		}

		private void Logar()
		{
			MessageBox.Show("Usuário: " + Usuario + ", senha: " + Senha);
		}
	}
}
