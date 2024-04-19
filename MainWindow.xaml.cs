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

namespace Module_9
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

        string[] Text;

        private void ButtonWork1_Click(object sender, RoutedEventArgs e)
        {
            ListBoxWork1.Items.Clear();
            Text = TextBoxWork1.Text.Split();
            foreach (string s in Text)
            {
                ListBoxWork1.Items.Add(s);
            }
        }

        string[] result2;
        string result;

        private void ButtonWork2_Click(object sender, RoutedEventArgs e)
        {
            result = "";
            result2 = TextBoxWork2.Text.Split();
            for (int i = result2.Length - 1; i >= 0; i--)
            {
                result += " " + result2[i];
            }
            LabelWork2.Content = result;
        }
    }
}