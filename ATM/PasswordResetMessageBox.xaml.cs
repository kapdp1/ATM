using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
    /// Interaction logic for PasswordResetMessageBox.xaml
    /// </summary>
    public partial class PasswordResetMessageBox : Window
    {
        public PasswordResetMessageBox()
        {
            InitializeComponent();
        }

        private void passworRestWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 2000;
            t.Elapsed += new ElapsedEventHandler(t_Elapsed);
            t.Start();
        }

        void t_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(new Action(() =>
            {
                this.Close();
            }), null);
        }
    }
}
