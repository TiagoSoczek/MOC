namespace Modulo1.Wpf.MVVM
{
	using System.ComponentModel;

	/// <summary>
	/// Classe base para <see cref="INotifyPropertyChanged"/>
	/// </summary>
	public abstract class BaseNotifyPropertyChanged : INotifyPropertyChanged
	{
		/// <summary>
		/// Evento de notificação de alteração de valores
		/// </summary>
		public virtual event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Dispara a notificação de alteração de propriedade
		/// </summary>
		/// <param name="propertyName">Nome da propriedade</param>
		protected virtual void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}