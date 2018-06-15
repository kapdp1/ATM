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
    /// Interaction logic for TransferMenu.xaml
    /// </summary>
    public partial class TransferMenu : Page
    {
        public TransferMenu()
        {
            InitializeComponent();
        }

        private void TransferButton(object sender, RoutedEventArgs e)
        {
            if (transferText.Text.Trim() == String.Empty && amountText.Text.Trim() != String.Empty)
            {
                MessageBoxResult result = MessageBox.Show("PLEASE ENTER ACCOUNT NUMBER BEFORE PROCEED", "Confirmation");
                transferText.Text = "";
                amountText.Text = "";
            }
            else if (amountText.Text.Trim() == String.Empty && transferText.Text.Trim() != String.Empty)
            {
                MessageBoxResult result = MessageBox.Show("PLEASE ENTER TRANSFER AMOUNT BEFORE PROCEED", "Confirmation");
                transferText.Text = "";
                amountText.Text = "";
            }
            else if (transferText.Text.Trim() == String.Empty || amountText.Text.Trim() == String.Empty)
            {
                MessageBoxResult result = MessageBox.Show("PLEASE ENTER ACCOUNT NUMBER AND TRANSFER AMOUNT", "Confirmation");
                transferText.Text = "";
                amountText.Text = "";
            }
            else
            {                   
                MessageBoxResult result = MessageBox.Show("MONEY TRANSFERED!!   Do you want to   GET A RECIPT?",
                                     "Confirmation", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    ProcessingMessageBox processingMessageBox = new ProcessingMessageBox();
                    processingMessageBox.ShowDialog();
                }
                else if (result == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }
                else
                {
                    transferText.Text = "";
                    amountText.Text = "";
                }
            }
        }

        private void ClearButton(object sender, RoutedEventArgs e)
        {
            transferText.Text = "";
            amountText.Text = "";
        }

        private void ExitButton(object sender, RoutedEventArgs e)
        {
            SessionMenu sessionMenu = new SessionMenu();
            NavigationService.Navigate(sessionMenu);
        }
    }
}
