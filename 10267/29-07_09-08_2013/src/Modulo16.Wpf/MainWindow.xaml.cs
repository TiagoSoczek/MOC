namespace Modulo16.Wpf
{
	using System.Windows;

	/// <summary>
	///     Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = new LoginViewModel();
		}
	}
}