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
using System.Diagnostics;
using System.Threading;

namespace BruteForcer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static int Threads = 10000;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread timer = new Thread(new ThreadStart(Timer));
            timer.Start();
            for (int i = 0; i != Threads; i++){
                Trace.WriteLine("Creating thread " + i.ToString());
                Thread Brute = new Thread(new ThreadStart(BruteForce.Brute));
                Brute.Start();
            }
            BruteForce.PasswordFound = false;
            BruteForce.Brute();
        }

        public void Timer()
        {
            double TimeTook = 0;
            while (BruteForce.PasswordFound == false)
            {
                Thread.Sleep(100);
                TimeTook += 0.1;
            }
            Trace.WriteLine("This operation took " + TimeTook.ToString() + " Seconds!");

        }
                    
    }
            
}

