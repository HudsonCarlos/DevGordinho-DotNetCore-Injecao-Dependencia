using System.Windows;

namespace WpfApp1.Paginas.Thread
{
    /// <summary>
    /// Interação lógica para PrimeiroPasso.xam
    /// </summary>
    public partial class PrimeiroPasso
    {
        
        public PrimeiroPasso()
        {
            InitializeComponent();
        }

        public void TesteFunçãoInterface(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("teste");
        }
    }
}
