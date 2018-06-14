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
    /// Interaction logic for AvailableBalance.xaml
    /// </summary>
    public partial class AvailableBalance : Page
    {
        public AvailableBalance()
        {
            InitializeComponent();
        }

        private void WithdrawButton(object sender, RoutedEventArgs e)
        {
            WithdrawPage withdrawPage = new WithdrawPage();
            NavigationService.Navigate(withdrawPage);
        }

        private void ExitButton(object sender, RoutedEventArgs e)
        {
            SessionMenu session_menu = new SessionMenu();
            NavigationService.Navigate(session_menu);
        }
    }
}
