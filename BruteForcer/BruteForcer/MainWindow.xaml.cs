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
        public bool PasswordFound = false;
        public string Password = "A";
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
            PasswordFound = false;
            BruteForce();
        }

        public void BruteForce(){
            string[] Characters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            while (PasswordFound == false)
            {
                string PasswordGuess;
                int i = 0;
                int B = 0;
                while (i != 25 && PasswordFound == false)
                {


                    PasswordGuess = Characters[i];
                    Trace.WriteLine(PasswordGuess);
                    
                    if (PasswordGuess == Password)
                    {
                        PasswordFound = true;
                        Trace.WriteLine("Found the password!");
                    }


                    int A = 0;
                    while (A < 25 && PasswordFound == false)
                    {
                        Trace.WriteLine(i.ToString() + " " + A.ToString());
                        PasswordGuess = Characters[i] + Characters[A];
                        Trace.WriteLine(PasswordGuess);
                       
                        if (PasswordGuess == Password)
                        {
                            PasswordFound = true;
                            Trace.WriteLine("Found the password!");
                        }
                        A++;
                    }
                    i++;
                }
        
            }
        }

        public void Timer()
        {
            double TimeTook = 0;
            while (PasswordFound == false)
            {
                Thread.Sleep(100);
                TimeTook += 0.1;
            }
            Trace.WriteLine("This operation took " + TimeTook.ToString() + " Seconds!");

        }
                    
    }
            
}

