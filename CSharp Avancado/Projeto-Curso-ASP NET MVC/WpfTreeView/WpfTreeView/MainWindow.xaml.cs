using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        
        #region Carregar TreeView

        #region Folder Expanded

        /// <summary>
        ///  Espande diretorios e encotra pastas, sub pastas e arquivos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EspandirItensTreeView(object sender, RoutedEventArgs e)
        {
            #region Initial Checks

            var item = (TreeViewItem)sender;

            // Se o item tiver somente o diretório null
            if (item.Items.Count != 1 || item.Items[0] != null)
                return;

            // Limpando os dados do treeview
            item.Items.Clear();

            // Busco caminho completo
            var CamionhoCompletoPasta = (string)item.Tag;

            #endregion

            #region Get Folders

            // Crio uma lista em branco de diretorios
            var listaDiretorio = new List<string>();

            // Tenta obter os diretórios das pastas ignorando qualquer problema
            try
            {
                // Busco todos os diretorio do caminho informado
                var dirs = Directory.GetDirectories(CamionhoCompletoPasta);

                if (dirs.Length > 0)
                {
                    // Se no caminho informado existir pasta adiciono a lista
                    listaDiretorio.AddRange(dirs);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado ao adicioanr as pastas a listaDiretorio");
            }

            // Percorro a lista de diretórios para criar novos itens
            listaDiretorio.ForEach(directoryPath =>
            {
                // Cria um novo item
                var subItem = new TreeViewItem()
                {
                    // Preeche o cabeçalho com o nome da pasta
                    Header = GetFileFolderName(directoryPath),
                    // E a Tag com o caminho da pasta
                    Tag = directoryPath
                };

                // Adiciona um item null
                subItem.Items.Add(null);

                // Chamada recursiva para espandir os itens
                subItem.Expanded += EspandirItensTreeView;

                //Adiciona este item ao pai
                item.Items.Add(subItem);
            });

            #endregion

            #region Get Files

            // Crio uma lista em branco de arquivos
            var files = new List<string>();

            // Tenta obter os arquivos das pastas ignorando qualquer problema
            try
            {
                // Busco todos os diretorio do caminho informado
                var fs = Directory.GetFiles(CamionhoCompletoPasta);

                if (fs.Length > 0)
                {
                    // Se no caminho informado existir pasta adiciono a lista
                    files.AddRange(fs);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado ao adicioanr os arquivos a files");
            }

            // Percorro a lista de arquivos para criar novos itens
            files.ForEach(filePath =>
            {
                // Cria um novo item
                var subItem = new TreeViewItem()
                {
                    // Preeche o cabeçalho com o nome dos arquivos
                    Header = GetFileFolderName(filePath),
                    // E a Tag com o caminho do arquivo 
                    Tag = filePath
                };

                //Adiciona este item ao pai
                item.Items.Add(subItem);
            });

            #endregion
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Buscando o nome do diretorio
        /// </summary>
        /// <param name="diretorioPai"></param>
        /// <param name="noPai"></param>
        public static string GetFileFolderName(string path)
        {

            // Se não tem o caminho retorna vazio
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }

            // Replace alterando as barras
            var caonhoCorrigido = path.Replace('/', '\\');

            // Encontra a ultima barra no caminha da pasta
            var lastIndex = caonhoCorrigido.LastIndexOf("\\");

            // Se não encontrar a barra retornamos o caminho em si
            if (lastIndex <= 0)
            {
                return path;
            }

            // Retorna o nome depois da ultima barrra
            return path.Substring(lastIndex + 1);
        }

        #endregion

        /// <summary>
        /// Carregando e listando todos os diretórios
        /// </summary>
        /// <param name="caminho"></param>
        private void ListarPastasnoTreeView(string caminho)
        {
            //// diretorio raiz
            //DirectoryInfo dir = new DirectoryInfo(caminho);
            //// no raiz
            //TreeViewItem noRaiz = new TreeViewItem() { Header = dir.FullName, IsExpanded = true };
            //// lista diretorios a partir do no raiz
            //ListaDiretorios(dir, noRaiz);
            //// adiciona os nos à TreeView
            //pereira.treeView1.Items.Clear();

            //pereira.treeView1.Items.Add(noRaiz);

            //dir = null;
            //noRaiz = null;

            // Busco o caminho dos discos.
            foreach (var drive in Directory.GetLogicalDrives())
            {
                // Crio um novo item para o treeview
                var item = new TreeViewItem()
                {
                    // Insiro o cabeçalho e o caminho
                    Header = drive,
                    Tag = drive
                };

                // Adiciono um item null
                item.Items.Add(null);

                // Espadir todos os itens
                item.Expanded += EspandirItensTreeView;

                // Adiciono um item ao treeview
                FolderView.Items.Add(item);
            }
        }

        #endregion
    }
}
