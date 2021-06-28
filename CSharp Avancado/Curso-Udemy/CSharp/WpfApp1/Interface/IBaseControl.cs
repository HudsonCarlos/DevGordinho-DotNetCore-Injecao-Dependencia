using System.Windows.Controls;

namespace WpfApp1.Interface
{
    public interface IBaseControl
    {
        void SetOwner(MainWindow pai);

        T AtivarControlePagina<T>() where T : UserControl;

        void DesativarControlPagina();
    }
}
