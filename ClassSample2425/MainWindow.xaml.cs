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

namespace ClassSample2425
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

        private void btnBig_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello WPF");
            Big_Button.Background = new SolidColorBrush(Colors.Honeydew);

        }

        private void Big_Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Big_Button.Background = new SolidColorBrush(Colors.DeepPink);
        }
    }
}

