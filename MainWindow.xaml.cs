using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfApp2
{

    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            
        }


        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set 
            { 
                boundText = value;
                OnPropertyChanged();
            }
        }

        private void tbSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "set from code";
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}