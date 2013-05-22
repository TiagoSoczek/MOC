namespace Modulo1.Wpf
{
	using System.Windows;
	using System.Windows.Input;
	using MVVM;

	public class LoginViewModel : BaseNotifyPropertyChanged
	{
		private string _senha;
		private string _usuario;

		public LoginViewModel()
		{
			Usuario = "usuario";
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
