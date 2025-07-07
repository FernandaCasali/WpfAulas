using Microsoft.Win32;

using System.Windows;

namespace WpfApp2
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "C# Source Files | *.cs";
            fileDialog.Title = "Select C# Source Files";

            fileDialog.Multiselect = true; // permite selecionar multiplos arquivos

            bool? success = fileDialog.ShowDialog();

            if (success == true)
            {
               string[] paths = fileDialog.FileNames;
               string[] fileNames = fileDialog.SafeFileNames;

                //tbinfo.Text = fileName;

            }
            else
            {
                //didnt pick anything
            }
        }
    }
}