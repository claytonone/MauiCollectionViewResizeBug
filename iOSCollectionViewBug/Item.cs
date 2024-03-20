using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace iOSCollectionViewBug
{
	public class Item : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _content;
        public string Content
        {
            get { return _content; }
            set { _content = value; OnPropertyChanged(); }
        }

        public Item()
		{
		}

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}