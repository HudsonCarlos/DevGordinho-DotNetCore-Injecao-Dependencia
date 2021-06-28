using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Load()
        {
            OnLoaded(null, null);
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            cabecalhoPagina.SetOwner(this);
        }
    }
}
