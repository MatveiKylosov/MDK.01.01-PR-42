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
        public View.Items.Main Main = new View.Items.Main();
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            frame.Navigate(Main);
        }

        private void OpenIndex(object sender, MouseButtonEventArgs e) => frame.Navigate(Main);
    }
}
