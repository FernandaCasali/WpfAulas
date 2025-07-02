using System.ComponentModel;
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
            }
        }

        private void tbSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "set from code";
        }
    }
}