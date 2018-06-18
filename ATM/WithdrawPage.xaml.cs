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
            //dbcon
            ProcessingMessageBox processingMessageBox = new ProcessingMessageBox();
            processingMessageBox.ShowDialog();
            withdrawAmmount.Clear();
            MessageBoxResult resultRecipt = MessageBox.Show("YOUR TRANSACTION IS COMPLETED! DO YOU WANT A PRINTED RECIPT ?", "ATM", MessageBoxButton.YesNo);

            if (resultRecipt == MessageBoxResult.Yes)
            {
                ProcessingMessageBox processingMessageBox_2 = new ProcessingMessageBox();
                processingMessageBox_2.ShowDialog();

                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                   SessionMenu sessionMenu = new SessionMenu();
                   NavigationService.Navigate(sessionMenu);
                }           
              
            }
            else if (resultRecipt == MessageBoxResult.No) {
                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }
            }     
        }

        private void _300WithdrawButton(object sender, RoutedEventArgs e)
        {
            //dbcon
            ProcessingMessageBox processingMessageBox = new ProcessingMessageBox();
            processingMessageBox.ShowDialog();
            withdrawAmmount.Clear();
            MessageBoxResult resultRecipt = MessageBox.Show("YOUR TRANSACTION IS COMPLETED! DO YOU WANT A PRINTED RECIPT ?", "ATM", MessageBoxButton.YesNo);

            if (resultRecipt == MessageBoxResult.Yes)
            {
                ProcessingMessageBox processingMessageBox_2 = new ProcessingMessageBox();
                processingMessageBox_2.ShowDialog();

                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }

            }
            else if (resultRecipt == MessageBoxResult.No)
            {
                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }
            }
        }

        private void _500WithdrawButton(object sender, RoutedEventArgs e)
        {
            //dbcon
            ProcessingMessageBox processingMessageBox = new ProcessingMessageBox();
            processingMessageBox.ShowDialog();
            withdrawAmmount.Clear();
            MessageBoxResult resultRecipt = MessageBox.Show("YOUR TRANSACTION IS COMPLETED! DO YOU WANT A PRINTED RECIPT ?", "ATM", MessageBoxButton.YesNo);

            if (resultRecipt == MessageBoxResult.Yes)
            {
                ProcessingMessageBox processingMessageBox_2 = new ProcessingMessageBox();
                processingMessageBox_2.ShowDialog();

                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }

            }
            else if (resultRecipt == MessageBoxResult.No)
            {
                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }
            }
        }

        private void _1000WithdrawButton(object sender, RoutedEventArgs e)
        {
            //dbcon
            ProcessingMessageBox processingMessageBox = new ProcessingMessageBox();
            processingMessageBox.ShowDialog();
            withdrawAmmount.Clear();
            MessageBoxResult resultRecipt = MessageBox.Show("YOUR TRANSACTION IS COMPLETED! DO YOU WANT A PRINTED RECIPT ?", "ATM", MessageBoxButton.YesNo);

            if (resultRecipt == MessageBoxResult.Yes)
            {
                ProcessingMessageBox processingMessageBox_2 = new ProcessingMessageBox();
                processingMessageBox_2.ShowDialog();

                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }

            }
            else if (resultRecipt == MessageBoxResult.No)
            {
                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }
            }
        }

        private void _1500WithdrawButton(object sender, RoutedEventArgs e)
        {
            //dbcon
            ProcessingMessageBox processingMessageBox = new ProcessingMessageBox();
            processingMessageBox.ShowDialog();
            withdrawAmmount.Clear();
            MessageBoxResult resultRecipt = MessageBox.Show("YOUR TRANSACTION IS COMPLETED! DO YOU WANT A PRINTED RECIPT ?", "ATM", MessageBoxButton.YesNo);

            if (resultRecipt == MessageBoxResult.Yes)
            {
                ProcessingMessageBox processingMessageBox_2 = new ProcessingMessageBox();
                processingMessageBox_2.ShowDialog();

                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }

            }
            else if (resultRecipt == MessageBoxResult.No)
            {
                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }
            }
        }

        private void _2000WithdrawButton(object sender, RoutedEventArgs e)
        {
            //dbcon
            ProcessingMessageBox processingMessageBox = new ProcessingMessageBox();
            processingMessageBox.ShowDialog();
            withdrawAmmount.Clear();
            MessageBoxResult resultRecipt = MessageBox.Show("YOUR TRANSACTION IS COMPLETED! DO YOU WANT A PRINTED RECIPT ?", "ATM", MessageBoxButton.YesNo);

            if (resultRecipt == MessageBoxResult.Yes)
            {
                ProcessingMessageBox processingMessageBox_2 = new ProcessingMessageBox();
                processingMessageBox_2.ShowDialog();

                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }

            }
            else if (resultRecipt == MessageBoxResult.No)
            {
                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }
            }
        }

        private void _3000WithdrawButton(object sender, RoutedEventArgs e)
        {
            //dbcon
            ProcessingMessageBox processingMessageBox = new ProcessingMessageBox();
            processingMessageBox.ShowDialog();
            withdrawAmmount.Clear();
            MessageBoxResult resultRecipt = MessageBox.Show("YOUR TRANSACTION IS COMPLETED! DO YOU WANT A PRINTED RECIPT ?", "ATM", MessageBoxButton.YesNo);

            if (resultRecipt == MessageBoxResult.Yes)
            {
                ProcessingMessageBox processingMessageBox_2 = new ProcessingMessageBox();
                processingMessageBox_2.ShowDialog();

                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }

            }
            else if (resultRecipt == MessageBoxResult.No)
            {
                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }
            }
        }

        private void _5000WithdrawButton(object sender, RoutedEventArgs e)
        {
            //dbcon
            ProcessingMessageBox processingMessageBox = new ProcessingMessageBox();
            processingMessageBox.ShowDialog();
            withdrawAmmount.Clear();
            MessageBoxResult resultRecipt = MessageBox.Show("YOUR TRANSACTION IS COMPLETED! DO YOU WANT A PRINTED RECIPT ?", "ATM", MessageBoxButton.YesNo);

            if (resultRecipt == MessageBoxResult.Yes)
            {
                ProcessingMessageBox processingMessageBox_2 = new ProcessingMessageBox();
                processingMessageBox_2.ShowDialog();

                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }

            }
            else if (resultRecipt == MessageBoxResult.No)
            {
                MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                if (resultAnotherTransaction == MessageBoxResult.No)
                {
                    SessionMenu sessionMenu = new SessionMenu();
                    NavigationService.Navigate(sessionMenu);
                }
            }
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (withdrawAmmount.Text.Trim() != String.Empty)
            {
                //dbcon
                ProcessingMessageBox processingMessageBox = new ProcessingMessageBox();
                processingMessageBox.ShowDialog();
                MessageBoxResult resultRecipt = MessageBox.Show("YOUR TRANSACTION IS COMPLETED! DO YOU WANT A PRINTED RECIPT ?", "ATM", MessageBoxButton.YesNo);

                if (resultRecipt == MessageBoxResult.Yes)
                {
                    ProcessingMessageBox processingMessageBox_2 = new ProcessingMessageBox();
                    processingMessageBox_2.ShowDialog();

                    MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                    if (resultAnotherTransaction == MessageBoxResult.No)
                    {
                        SessionMenu sessionMenu = new SessionMenu();
                        NavigationService.Navigate(sessionMenu);
                    }
                    else {
                        withdrawAmmount.Clear();
                    }

                }
                else if (resultRecipt == MessageBoxResult.No)
                {
                    MessageBoxResult resultAnotherTransaction = MessageBox.Show("WOULD YOU LIKE TO PERFORM ANOTHER TRANSACTION?", "ATM", MessageBoxButton.YesNo);

                    if (resultAnotherTransaction == MessageBoxResult.No)
                    {
                        SessionMenu sessionMenu = new SessionMenu();
                        NavigationService.Navigate(sessionMenu);
                    }
                    else {
                        withdrawAmmount.Clear();
                    }
                }
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
        }
    }
}
