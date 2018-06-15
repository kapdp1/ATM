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

namespace ATM
{
    /// <summary>
    /// Interaction logic for SessionMenu.xaml
    /// </summary>
    public partial class SessionMenu : Page
    {
        public SessionMenu()
        {
            InitializeComponent();
        }

        private void WithdrawButton(object sender, RoutedEventArgs e)
        {
            WithdrawPage withdrawPage = new WithdrawPage();
            NavigationService.Navigate(withdrawPage);
        }

        private void BalanceButton(object sender, RoutedEventArgs e)
        {
            AvailableBalance availableBalance = new AvailableBalance();
            NavigationService.Navigate(availableBalance);
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            
            AccountNumberPage accountNumberPage = new AccountNumberPage();
            NavigationService.Navigate(accountNumberPage);

        }

        private void ChangePinButton(object sender, RoutedEventArgs e)
        {
            ChangePin changePin = new ChangePin();
            bool? result = changePin.ShowDialog();

            if (result.HasValue && result.Value)
            {
                SessionMenu sessionMenu = new SessionMenu();
                NavigationService.Navigate(sessionMenu);
            }
        }
        
        private void SignOutButton(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            NavigationService.Navigate(mainPage);
        }

      
        private void TransferButton(object sender, RoutedEventArgs e)
        {
            TransferMenu transferMenu = new TransferMenu();
            NavigationService.Navigate(transferMenu);
        }
    }
}
