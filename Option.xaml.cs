using System.Windows;

namespace JocDameAnicaiBogdan
{
    /// <summary>
    /// Interaction logic for Option.xaml
    /// </summary>
    public partial class Option : Window
    {
        public static string size = "8";

        public Option()
        {
            InitializeComponent();
        }

        public Option(string size_)
        {
        }

        private void btnSetClick(object sender, RoutedEventArgs e)
        {
            size = txtBox.Text;
            MessageBox.Show("Board size was set to " + txtBox.Text);
            this.Close();
        }
    }
}