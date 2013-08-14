namespace Modulo16.Wpf.MVVM
{
	using System;
	using System.Diagnostics;
	using System.Diagnostics.CodeAnalysis;
	using System.Windows.Input;

	/// <summary>
	/// A command whose sole purpose is to relay its functionality to other
	/// objects by invoking delegates. The default return value for the CanExecute
	/// method is 'true'.  This class does not allow you to accept command parameters in the
	/// Execute and CanExecute callback methods.
	/// </summary>
	public class RelayCommand : ICommand
	{
		private readonly Func<bool> _canExecute;
		private readonly Action _execute;

		/// <summary>
		/// Initializes a new instance of the RelayCommand class that 
		/// can always execute.
		/// </summary>
		/// <param name="execute">The execution logic.</param>
		/// <exception cref="ArgumentNullException">If the execute argument is null.</exception>
		public RelayCommand(Action execute)
			: this(execute, null)
		{
		}

		/// <summary>
		/// Initializes a new instance of the RelayCommand class.
		/// </summary>
		/// <param name="execute">The execution logic.</param>
		/// <param name="canExecute">The execution status logic.</param>
		/// <exception cref="ArgumentNullException">If the execute argument is null.</exception>
		public RelayCommand(Action execute, Func<bool> canExecute)
		{
			if (execute == null)
			{
				throw new ArgumentNullException("execute");
			}

			_execute = execute;
			_canExecute = canExecute;
		}

		#region ICommand Members

		/// <summary>
		/// Occurs when changes occur that affect whether the command should execute.
		/// </summary>
		public event EventHandler CanExecuteChanged
		{
			add
			{
				if (_canExecute != null)
				{
					CommandManager.RequerySuggested += value;
				}
			}

			remove
			{
				if (_canExecute != null)
				{
					CommandManager.RequerySuggested -= value;
				}
			}
		}

		/// <summary>
		/// Defines the method that determines whether the command can execute in its current state.
		/// </summary>
		/// <param name="parameter">This parameter will always be ignored.</param>
		/// <returns>true if this command can be executed; otherwise, false.</returns>
		[DebuggerStepThrough]
		public bool CanExecute(object parameter)
		{
			return _canExecute == null ? true : _canExecute();
		}

		/// <summary>
		/// Defines the method to be called when the command is invoked. 
		/// </summary>
		/// <param name="parameter">This parameter will always be ignored.</param>
		public void Execute(object parameter)
		{
			_execute();
		}

		#endregion

		/// <summary>
		/// Raises the <see cref="CanExecuteChanged" /> event.
		/// </summary>
		[SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate",
			Justification = "This cannot be an event")]
		public void RaiseCanExecuteChanged()
		{
			CommandManager.InvalidateRequerySuggested();
		}
	}
}