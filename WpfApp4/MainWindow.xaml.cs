using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 secondWindow = new Window2();
            secondWindow.Show();
            foreach (CheckBox checkbox in F1.Children)
            {
                if (checkbox.IsChecked == true)
                {
                    secondWindow.lblf1.Content = checkbox.Content + " tölti";
                }
            }
            secondWindow.lblf2.Content = ((ComboBoxItem)F2.SelectedItem).Content;
            foreach (RadioButton radiobutton in F3.Children)
            {
                if (radiobutton.IsChecked == true)
                {
                    secondWindow.lblf3.Content = radiobutton.Content;
                }
            }
            secondWindow.lblf4.Content = ((ComboBoxItem)F4.SelectedItem).Content;
            secondWindow.txbf5.Text = ((ListBoxItem)F5.SelectedItem).Content.ToString();
            secondWindow.Nev2.Content += Nev.Text.ToString();
        }
    }
}