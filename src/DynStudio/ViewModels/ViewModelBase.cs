using System.ComponentModel;

namespace DynStudio.ViewModels
{
	class ViewModelBase : INotifyPropertyChanged
	{

		protected virtual void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}


		public event PropertyChangedEventHandler PropertyChanged;
	}
}
