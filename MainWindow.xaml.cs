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
            lvEntries.Items.Add("a1");
            lvEntries.Items.Add("a2");
            lvEntries.Items.Add("a3");
            lvEntries.Items.Add("a4");
        }

    }
}