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
        public static int status;

        public ProcessingMessageBox()
        {
           

            InitializeComponent();

            //_loadProgressbar();

           // if (status != 2) {
            //    this.Close();
           // }
        


        }

        //private void _loadProgressbar()
        //{


        //        //status = 2;

        //        //Duration duration = new Duration(TimeSpan.FromSeconds(5));
        //        //DoubleAnimation doubleAnimation = new DoubleAnimation(200.0, duration);

        //        //progressBar.BeginAnimation(ProgressBar.ValueProperty, doubleAnimation);
                

        //        //if (progressBar.Value == 100)
        //        //    this.Close();
            
        //}

        private void processingMessageWindow_Loaded(object sender, RoutedEventArgs e)
        {
           

            Duration duration = new Duration(TimeSpan.FromSeconds(5));
            DoubleAnimation doubleAnimation = new DoubleAnimation(200.0, duration);
            progressBar.BeginAnimation(ProgressBar.ValueProperty, doubleAnimation);

            //status = 2;

            //this.Close();


            //if (progressBar.Value == 100)
            //    this.Close();
        }

        
    }
}
