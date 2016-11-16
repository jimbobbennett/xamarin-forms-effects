using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinFormsEffects.Test
{
	public class ViewModel : INotifyPropertyChanged
	{
        private string _removeBorderInput;
        public string RemoveBorderInput
        {
            get { return _removeBorderInput; }
            set
            {
                _removeBorderInput = value;
                NotifyChanged();
            }
        }

        private string _capitalizedInput;
        public string CapitalizedInput
        {
            get { return _capitalizedInput; }
            set
            {
                _capitalizedInput = value;
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