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
using System.Windows.Shapes;

namespace TucanPass
{
    /// <summary>
    /// Logika interakcji dla klasy CreateAccountView.xaml
    /// </summary>
    public partial class CreateAccountView : Window
    {
        public CreateAccountView()
        {
            InitializeComponent();
            ColorIt();
            this.DataContext = new ViewModel();
        }

        private void ColorIt()
        {
            var customBorder = new Thickness(2);
            foreach (TextBox tb in LayoutController.FindVisualChildren<TextBox>(Gridek))
            {
                tb.BorderBrush = LayoutController.tucanOrangeColor;
                tb.BorderThickness = customBorder;
            }
            foreach (PasswordBox tb in LayoutController.FindVisualChildren<PasswordBox>(Gridek))
            {
                tb.BorderBrush = LayoutController.tucanOrangeColor;
                tb.BorderThickness = customBorder;
            }

            registerBTN.Foreground = LayoutController.tucanBlackColor;
            registerBTN.Background = LayoutController.tucanOrangeColor;
            registerBTN.BorderBrush = LayoutController.tucanOrangeColor;
            registerBTN.BorderThickness = customBorder;
            tipBackPlate.Fill = LayoutController.tucanOrangeColor;
            toolTipText.Background = new SolidColorBrush(Color.FromArgb(0,0,0,0));

            publicKeyBTN.BorderThickness = new Thickness(2);
            publicKeyBTN.BorderBrush = LayoutController.tucanBlackColor;
            publicKeyBTN.Background = LayoutController.tucanOrangeColor;

            privateKeyBTN.BorderThickness = new Thickness(2);
            privateKeyBTN.BorderBrush = LayoutController.tucanBlackColor;
            privateKeyBTN.Background = LayoutController.tucanOrangeColor;

            toolTipText.BorderThickness = new Thickness(0);
            
            toolTipText.AppendText("Hi! I am your TucanHelper" + System.Environment.NewLine);
            
            toolTipText.AppendText("I have some informations for you. Now, you're creating new Tucan."+System.Environment.NewLine);
            toolTipText.AppendText("Set really strong MASTER PASSWORD. On mouse hover you can see a requirements for specific field." + System.Environment.NewLine);
            toolTipText.AppendText("Your PRIVATE KEY is your HOLY GRAIL. If you lost it - access to your Tukan will be unavaliable.");
            toolTipText.AppendText("KEEP SAFE!");

        }

        private void loginBox_LostFocus(object sender, RoutedEventArgs e)
        {
            bool xd = CheckCorrectLogin();
            MessageBox.Show(xd.ToString(), "RESULT");
        }

        private bool CheckCorrectLogin()
        {
            char[] downloadedValue = loginBox.Text.ToCharArray();
            if ((downloadedValue.Length > 3)&&(downloadedValue.Length<25))
            {
                for(int i = 0; i < downloadedValue.Length; i++)
                {
                    if (!(((int)downloadedValue[i] > 64) && ((int)downloadedValue[i] < 91) || ((int)downloadedValue[i] > 96) && ((int)downloadedValue[i] < 123)))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void privateKeyBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void publicKeyBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
