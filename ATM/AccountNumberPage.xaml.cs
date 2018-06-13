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

        private void submit_button(object sender, RoutedEventArgs e)
        {
            LoginPin loginpin = new LoginPin();
            loginpin.Show();
        }

        private void cancel_button(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            NavigationService.Navigate(mainPage);
        }
        
        private void accPage_MouseEnter(object sender, MouseEventArgs e)
        {
            if (SessionClass._sumbitSuccess)
            {
                SelectAccountPage selectAccountPage = new SelectAccountPage();
                NavigationService.Navigate(selectAccountPage);
                SessionClass._sumbitSuccess = false;
            }
        }
    }
}
