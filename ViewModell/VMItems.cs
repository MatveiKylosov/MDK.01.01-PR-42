using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace ShopContent.ViewModell
{
    public class VMItems : INotifyPropertyChanged
    {
        public ObservableCollection<Context.ItemsContext> Items { get; set; }
        public Classes.RelayCommand NewItem
        {
            get
            {
                return new Classes.RelayCommand(obj =>
                    {
                        Context.ItemsContext newModell = new Context.ItemsContext(true);
                        Items.Add(newModell);
                        MainWindow.Instance.frame.Navigate(new View.Items.Add(newModell));
                    }
                );
            }
        }

        public VMItems() => Items = Context.ItemsContext.AllItems();
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
