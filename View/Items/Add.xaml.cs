using System.Windows.Controls;

namespace ShopContent.View.Items
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        public Add(object Context)
        {
            InitializeComponent();
            DataContext = new { item = Context, categories = new ViewModell.VMCategories() };
        }
    }
}
