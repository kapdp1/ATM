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
using System.ComponentModel;
using System.Windows.Media.Animation;

namespace ATM
{
    /// <summary>
    /// Interaction logic for PleaseWaitMessageBox.xaml
    /// </summary>
    public partial class ProcessingMessageBox : Window
    {

        public ProcessingMessageBox()
        {
            InitializeComponent();
        }


        private void processingMessageWindow_Loaded(object sender, RoutedEventArgs e)
        {

            Timer t = new Timer();
            t.Interval = 5000;
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
