using System.Collections.Generic;
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


        private string boundText;

        public string BoundText
        {
            get { return boundText; }
            set { boundText = value; }
        }

    }
}