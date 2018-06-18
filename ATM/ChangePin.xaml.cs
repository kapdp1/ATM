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

namespace ATM
{
    /// <summary>
    /// Interaction logic for ChangePin.xaml
    /// </summary>
    public partial class ChangePin : Window
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void SubmitButton(object sender, RoutedEventArgs e)
        {
            if (currentPin.Password.Trim() == String.Empty || newPin.Password.Trim() == String.Empty || confirmNewPin.Password.Trim() == String.Empty)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("PLEASE FILL ALL FIELDS!  !", "Confirmation");
                currentPin.Password = "";
                newPin.Password = "";
                confirmNewPin.Password = "";
            }
            else {

                if (currentPin.Password.Equals("1234"))
                {
                    this.DialogResult = true;
                    this.Close();
                    PasswordResetMessageBox passwordResetMessageBox= new PasswordResetMessageBox();
                    passwordResetMessageBox.ShowDialog();


                }
                else {
                    MessageBoxResult messageBoxResult = MessageBox.Show("PLEASE ENTER YOUR CURRENT PASSWORD CORRECTLY!  !", "Confirmation");
                    currentPin.Password = "";
                    newPin.Password = "";
                    confirmNewPin.Password = "";
                }
            }
        }

        private void ClearButton(object sender, RoutedEventArgs e)
        {
            currentPin.Clear();
            newPin.Clear();
            confirmNewPin.Clear();
            
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
