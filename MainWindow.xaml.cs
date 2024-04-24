using System.Windows;
using System.Windows.Input;

namespace ShopContent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance { get; private set; }
        public View.Items.Main MainItems = new View.Items.Main();
        public View.Categories.Main MainCategories = new View.Categories.Main();
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            frame.Navigate(MainItems);
        }

        private void OpenIndex(object sender, MouseButtonEventArgs e) => frame.Navigate(MainItems);
        private void OpenCategory(object sender, MouseButtonEventArgs e) => frame.Navigate(MainCategories);
    }
}
