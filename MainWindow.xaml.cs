using Microsoft.Win32;

using System.Windows;

namespace WpfApp2
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("a");
            lvEntries.Items.Add("b");
            lvEntries.Items.Add("c");
            lvEntries.Items.Add("d");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //int index = lvEntries.SelectedIndex;
            object item = lvEntries.SelectedItem;
            var result = MessageBox.Show($"Are you sure you want to delete: {(string) item}?",
                "Sure?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if ( result == MessageBoxResult.Yes)
                lvEntries.Items.Remove(item);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}