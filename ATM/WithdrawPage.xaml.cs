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
        public static int status = 1;

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
            // withdrawAmmount

            if (withdrawAmmount.Text.Trim() != String.Empty)
            { 
                ProcessingMessageBox processingMessageBox = new ProcessingMessageBox();
                processingMessageBox.ShowDialog();

                SessionMenu sessionMenu = new SessionMenu();
                NavigationService.Navigate(sessionMenu);
            }
            else {
                MessageBoxResult messageBoxResult = MessageBox.Show("PLEASE ENTER WITHDRAWAL BEFORE PROCEED!", "Confirmation");
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            SessionMenu sessionMenu = new SessionMenu();
            NavigationService.Navigate(sessionMenu);

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
             withdrawAmmount.Clear();

            //int index = withdrawAmmount.SelectionStart;
            //withdrawAmmount.Text = withdrawAmmount.Text.Remove(withdrawAmmount.SelectionStart - 1, 1);
            //withdrawAmmount.Select(index - 1, 1);
            //withdrawAmmount.Focus();

            //int i = withdrawAmmount.Text.Length;
            //withdrawAmmount.Text = withdrawAmmount.Text.Substring(0, i - 1);

            //if (withdrawAmmount.Text.Length == 0)
            //{
            //    clearButton.IsEnabled = false;
            //    status = 2;
            //}
            //else 
            //{
            //    clearButton.IsEnabled = true;
            //}

           // (withdrawAmmount.Text.Length == 1 || withdrawAmmount.Text.Length == 2 || withdrawAmmount.Text.Length == 3 || withdrawAmmount.Text.Length == 4 || withdrawAmmount.Text.Length == 5 || withdrawAmmount.Text.Length == 6 || withdrawAmmount.Text.Length == 7)
        }
    }
}
