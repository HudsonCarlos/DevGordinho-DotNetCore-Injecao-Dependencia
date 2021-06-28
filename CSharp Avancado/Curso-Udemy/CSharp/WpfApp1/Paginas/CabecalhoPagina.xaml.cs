using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Interface;
using WpfApp1.Paginas.Thread;

namespace WpfApp1.Paginas
{
    /// <summary>
    /// Interação lógica para CabecalhoPagina.xam
    /// </summary>
    public partial class CabecalhoPagina : IBaseControl
    {
        private MainWindow owner;

        public UserControl paginaCorpoAtiva { get; private set; }

        public CabecalhoPagina()
        {
            InitializeComponent();
        }

        private void CarregaPagina()
        {
            try
            {
                paginaCorpoAtiva = AtivarControlePagina<CorpoPagina>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T AtivarControlePagina<T>() where T : UserControl
        {
            try
            {
                DesativarControlPagina();

                T control = Activator.CreateInstance<T>();
                //control.SetOwner(owner);
                owner.gridPaginaPrincipal.Children.Add(control);
                return control;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu ruim no metodo DesativarControlPagina");
                return null;
            }
        }

        public void DesativarControlPagina()
        {
            try
            {
                owner.gridPaginaPrincipal.Children.Clear();
            }
            catch
            {
                MessageBox.Show("Deu ruim no metodo DesativarControlPagina");
            }
        }

        public void SetOwner(MainWindow owner)
        {
            this.owner = owner;
            CarregaPagina();
        }

        private void ClickMenu(object sender, RoutedEventArgs e)
        {
            paginaCorpoAtiva = AtivarControlePagina<PrimeiroPasso>();
        }
    }
}
