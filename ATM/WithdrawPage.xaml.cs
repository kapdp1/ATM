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
    /// Interaction logic for WithdrawPage.xaml
    /// </summary>
    public partial class WithdrawPage : Page
    {
        public WithdrawPage()
        {
            InitializeComponent();
        }

        private void _200WithdrawButton(object sender, RoutedEventArgs e)
        {

        }

        private void _300WithdrawButton(object sender, RoutedEventArgs e)
        {

        }

        private void _500WithdrawButton(object sender, RoutedEventArgs e)
        {

        }

        private void _1000WithdrawButton(object sender, RoutedEventArgs e)
        {

        }

        private void _1500WithdrawButton(object sender, RoutedEventArgs e)
        {

        }

        private void _2000WithdrawButton(object sender, RoutedEventArgs e)
        {

        }

        private void _3000WithdrawButton(object sender, RoutedEventArgs e)
        {

        }

        private void _5000WithdrawButton(object sender, RoutedEventArgs e)
        {

        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            ProcessingMessageBox processingMessageBox = new ProcessingMessageBox();
            processingMessageBox.ShowDialog();

            SessionMenu sessionMenu = new SessionMenu();
            NavigationService.Navigate(sessionMenu);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            withdrawAmmount.Clear();
        }
    }
}
