using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TucanPass
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ColorIt();

        }

        private void logInBTN_Click(object sender, RoutedEventArgs e)
        {
            LogedInView logedInView = new LogedInView();
            logedInView.Show();
            this.Close();
        }

        private void createBTN_Click(object sender, RoutedEventArgs e)
        {
            
            CreateAccountView createAccountView = new CreateAccountView();
            createAccountView.Show();
            this.Close();
        }

        private void ColorIt()
        {
            foreach (TextBox textBox in LayoutController.FindVisualChildren<TextBox>(mainPageGrid))
            {
                textBox.BorderBrush = LayoutController.tucanOrangeColor;
                textBox.BorderThickness = new Thickness(2);
            }

            foreach (Button button in LayoutController.FindVisualChildren<Button>(mainPageGrid))
            {
                button.Background = LayoutController.tucanOrangeColor;
                button.BorderBrush = LayoutController.tucanBlackColor;
                button.BorderThickness = new Thickness(2);
            }

            lineHorizontal.Fill = LayoutController.tucanBlackColor;
            orangeBackplate.Fill = LayoutController.tucanOrangeColor;
            manualTextBox.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            manualTextBox.BorderThickness = new Thickness(0);
            manualTextBox.AppendText("We are so much happy that your are with us! In this form you can log in into your Tucan or create new Tucan. Remember that all of your passwords are safe. After provide correct login and password we will ask about path to file with your PRIVATE KEY created during registration process. Without correct PRIVATE KEY access will be denied." + System.Environment.NewLine + "Have a great day and we wish you amazing feelsfrom using our app. ~TucanPass Developer");

            
        }

    }
}
