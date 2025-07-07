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
            bool? success = fileDialog.ShowDialog();

            if (success == true)
            {
               string path = fileDialog.FileName;
               string fileName = fileDialog.SafeFileName;

                tbinfo.Text = fileName;

            }
            else
            {
                //didnt pick anything
            }
        }
    }
}