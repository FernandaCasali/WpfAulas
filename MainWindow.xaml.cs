using Microsoft.Win32;
using System.Collections;
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
            //object item = lvEntries.SelectedItem;
            var items = lvEntries.SelectedItems;

            var result = MessageBox.Show($"Are you sure you want to delete {items.Count} items?",
                "Sure?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if ( result == MessageBoxResult.Yes)
            {
                var itemsList = new ArrayList(items);
                foreach (var item in itemsList)
                    lvEntries.Items.Remove(item);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}