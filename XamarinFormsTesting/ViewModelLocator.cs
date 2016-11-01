using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinFormsTesting
{
	public class ViewModel : INotifyPropertyChanged
	{
		private string _input;
		public string Input
		{
			get
			{
				return _input;
			}

			set
			{
				_input = value;
				NotifyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyChanged([CallerMemberName] string name = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}

	public static class ViewModelLocator
	{
		public static readonly ViewModel ViewModel = new ViewModel();
	}
}