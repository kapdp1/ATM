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
using System.Text.RegularExpressions;

namespace ATM
{
    /// <summary>
    /// Interaction logic for AccountNumberPage.xaml
    /// </summary>
    public partial class AccountNumberPage : Page
    {
        public AccountNumberPage()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

      

        private void sign_outButton(object sender, RoutedEventArgs e)
        {
            SignOutMessage signoutMessage = new SignOutMessage();
            signoutMessage.ShowDialog();

            MainPage mainPage = new MainPage();
            NavigationService.Navigate(mainPage);
        }

        private void submit_button_Click(object sender, RoutedEventArgs e)
        {
            if (accountNumberText.Text.Trim() == String.Empty)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("PLEASE ENTER ACCOUNT NUMBER BEFORE PROCEED!", "Confirmation");
                accountNumberText.Text = "";
            }
            else
            {
                LoginPin loginpin = new LoginPin();
                bool? result = loginpin.ShowDialog();

                if (result.HasValue && result.Value)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }
            }
        }



        //private void signout_button(object sender, RoutedEventArgs e)
        //{
        //    MainPage mainPage = new MainPage();
        //    NavigationService.Navigate(mainPage);
        //}
    }
}
