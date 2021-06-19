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
            SyntaxChecker.FillSpecificCharacterLists();
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

            nextStepBTN.Background = LayoutController.tucanOrangeColor;
            nextStepBTN.Foreground = LayoutController.tucanBlackColor;
        

            //publicKeyBTN.BorderThickness = new Thickness(2);
            //publicKeyBTN.BorderBrush = LayoutController.tucanBlackColor;
            //publicKeyBTN.Background = LayoutController.tucanOrangeColor;

            //privateKeyBTN.BorderThickness = new Thickness(2);
            //privateKeyBTN.BorderBrush = LayoutController.tucanBlackColor;
            //privateKeyBTN.Background = LayoutController.tucanOrangeColor;

            toolTipText.BorderThickness = new Thickness(0);
            
            toolTipText.AppendText("Hi! I am your TucanHelper" + System.Environment.NewLine);
            toolTipText.AppendText("I have some informations for you. Now, you're creating new Tucan."+System.Environment.NewLine);
            toolTipText.AppendText("Set really strong MASTER PASSWORD. On mouse hover you can see a requirements for specific field." + System.Environment.NewLine);
            toolTipText.AppendText("Your PRIVATE KEY is your HOLY GRAIL. If you lost it - access to your Tukan will be unavaliable.");
            toolTipText.AppendText("KEEP SAFE!");

        }

        private void loginBox_LostFocus(object sender, RoutedEventArgs e)
        {
            bool recivedBoolValue = SyntaxChecker.DoesLoginPassLoginRequirments(loginBox.Text);
            if (recivedBoolValue)
            {
                loginBox.BorderBrush= LayoutController.GreenAcceptColor;
            }
            else
            {
                
                loginBox.BorderBrush = LayoutController.RedDeclineColor;
            }
        }
        private void emailBox_LostFocus(object sender, RoutedEventArgs e)
        {
            bool recivedCheckerResult = SyntaxChecker.DoesEmailPassRequirments(emailBox.Text);
            if (recivedCheckerResult)
            {
                emailBox.BorderBrush = LayoutController.GreenAcceptColor;
            }
            else
            {
                emailBox.BorderBrush = LayoutController.RedDeclineColor;
            }
        }

        private void passwordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (SyntaxChecker.DoesPasswordPassRequirments(passwordBox.Password))
            {
                passwordBox.BorderBrush = LayoutController.GreenAcceptColor;

            }
            else
            {
                passwordBox.BorderBrush = LayoutController.RedDeclineColor;
            }
        }


        public bool DoesAllTextBoxesAreGreen()
        {
            if(loginBox.BorderBrush == LayoutController.GreenAcceptColor)
            {
                if(emailBox.BorderBrush == LayoutController.GreenAcceptColor)
                {
                    if(passwordBox.BorderBrush == LayoutController.GreenAcceptColor)
                    {
                        if(confirmPasswordBox.BorderBrush == LayoutController.GreenAcceptColor)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }



        private void nextStepBTN_Click(object sender, RoutedEventArgs e)
        {
            AdditionalAccountComponents aac = new AdditionalAccountComponents(loginBox.Text, Encoding.ASCII.GetBytes(passwordBox.Password), emailBox.Text);
            ClearFormFields();
            MessageBox.Show("Listen to me, that's IMPORTANT !\n Your lucky number is: " + aac.TakeLuckyNumber() + " SAVE IT SOMEWHERE!\n After close that communicat you should select directory. We will save an secret data REQUIRED while login process.","INFORMATION + LUCKY NUMBER");
        }

        private void ClearFormFields()
        {
            loginBox.Clear();
            emailBox.Clear();
            passwordBox.Clear();
            confirmPasswordBox.Clear();
        }

        private void confirmPasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(passwordBox.BorderBrush == LayoutController.GreenAcceptColor)
            {
                if(passwordBox.Password == confirmPasswordBox.Password)
                {
                    confirmPasswordBox.BorderBrush = LayoutController.GreenAcceptColor;
                }
            }

            if (DoesAllTextBoxesAreGreen())
            {
                nextStepBTN.Visibility = Visibility.Visible;
            }

        }

        private void nextStepBTN_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
