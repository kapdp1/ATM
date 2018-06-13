using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for LoginPin.xaml
    /// </summary>
    public partial class LoginPin : Window
    {

        public LoginPin()
        {
            InitializeComponent();
        }
        

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SubmitButton(object sender, RoutedEventArgs e)
        {
            this.Close();
            SessionClass._sumbitSuccess = true;
            
        }

        private void ClearButton(object sender, RoutedEventArgs e)
        {
            //TextBox.MaxLength = 4;
            passwordBox.Clear();
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            //AccountNumberPage accountNumberpage = new AccountNumberPage();
            this.Close();
        }



    }
}
