using System.Windows;

namespace WpfApp1.Paginas
{
    /// <summary>
    /// Interação lógica para CorpoPagina.xam
    /// </summary>
    public partial class CorpoPagina
    {
        private MainWindow owner;
        public CorpoPagina()
        {
            InitializeComponent();
        }

        public void SetOwner(MainWindow owner)
        {
            this.owner = owner;
        }

        private void ButtonLog_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Testando Click");
        }
    }
}
