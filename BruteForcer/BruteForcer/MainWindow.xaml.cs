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

namespace BruteForcer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool PasswordFound = false;
        public string Password = "CAR";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PasswordFound = false;
            BruteForce();
        }

        public void BruteForce(){
            string[] Characters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            while (PasswordFound == false)
            {
                int i = 0;
               while (i != 25 && PasswordFound == false)
               {

                    string PasswordGuess = Characters[i];
                    Trace.WriteLine(PasswordGuess);
                   
                    if (PasswordGuess == Password)
                    {
                        PasswordFound = true;
                        Trace.WriteLine("Found the password!");
                    }

                    int A = 0;
                    while (A != 25 || PasswordFound == false)
                    {
                        PasswordGuess = Characters[i] + Characters[A];
                        Trace.WriteLine(PasswordGuess);
                        if (PasswordGuess == Password)
                        {
                            PasswordFound = true;
                            Trace.WriteLine("Found the password!");
                        }
                        int B = 0;
                        while (B != 25 || PasswordFound == false)
                        {
                            PasswordGuess = Characters[i] + Characters[A] + Characters[B];
                            Trace.WriteLine(PasswordGuess);
                            if (PasswordGuess == Password)
                            {
                                PasswordFound = true;
                                Trace.WriteLine("Found the password!");
                            }
                            B++;
                        }
                        A++;
                    }


            /*        if(PasswordGuess == Password)
                    {
                        PasswordFound = true;
                        Trace.WriteLine("Found the password!");
                    }*/
                    i++;
                    
                }
            }
    }
    }
}
