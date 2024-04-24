using ShopContent.ViewModell;
using System.Windows.Controls;

namespace ShopContent.View.Items
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
            this.DataContext = new VMItems();
        }
    }
}
