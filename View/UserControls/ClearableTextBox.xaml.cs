using System.Windows;
using System.Windows.Controls;

namespace WpfApp2.View.UserControls
{

    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set 
            { 
                placeholder = value;

                //DO NOT DO THIS
                txtPlaceholder.Text = placeholder;
            }
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
                txtPlaceholder.Visibility = Visibility.Visible;
            else
                txtPlaceholder.Visibility = Visibility.Hidden;
        }
    }
}
