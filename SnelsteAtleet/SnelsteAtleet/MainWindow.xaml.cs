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

namespace SnelsteAtleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nameFastest;
        int timeFastest = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Clear();
            timeTextBox.Clear();
            resultTextBox.Clear();

            nameTextBox.Focus();
        }
        private void addNewButton_Click(object sender, RoutedEventArgs e)
        {
            //int timeCurrent;
            bool isValidNumber = int.TryParse(timeTextBox.Text, out int timeCurrent);

            //if (isValidNumber == true)
            if (isValidNumber) 
            {
                if(timeFastest == 0 || timeCurrent < timeFastest)
                {
                    timeFastest = timeCurrent;
                    nameFastest = nameTextBox.Text;
                }
            }
        }
        private void fastestAthleteButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = $"De snelste atleet is {nameFastest} met een tijd van {timeFastest} seconden";
        }


    }
}