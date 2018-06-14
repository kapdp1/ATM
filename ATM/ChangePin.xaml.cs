﻿using System;
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
            if (currentPin.Password.Equals("1234"))
            {
                this.DialogResult = true;
                this.Close();
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
