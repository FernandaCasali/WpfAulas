using System.ComponentModel;
using System.Runtime.CompilerServices;
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
            //MessageBox.Show("Could not open file", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);

            MessageBoxResult result = MessageBox.Show
                ("Do you agree?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                tbinfo.Text = "Agreed";
            }
            else
            {
                tbinfo.Text = "Disagreed";
            }
        }
    }
}