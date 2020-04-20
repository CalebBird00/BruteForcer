using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace BruteForcer
{
    class BruteForce
    {
        public static int Threads = 4;


        public static bool PasswordFound = false;
        public static string Password = "ZZZ";

        public static void setup()
        {

            Thread timer = new Thread(new ThreadStart(Timer));
            timer.Start();
            for (int i = 0; i != Threads; i++)
            {
                Trace.WriteLine("Creating thread " + i.ToString());
                Thread Brute = new Thread(new ThreadStart(BruteForce.Brute));
                Brute.Start();
            }
            BruteForce.PasswordFound = false;
            BruteForce.Brute();

        }
        public static void Brute()
        {
            string[] Characters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            while (PasswordFound == false)
            {
                string PasswordGuess;
                int i = 0;
 
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

                        int B = 0;
                        while (B < 25 && PasswordFound == false)
                        {
                            //Trace.WriteLine(i.ToString() + " " + A.ToString());
                            PasswordGuess = Characters[i] + Characters[A] + Characters[B];
                            Trace.WriteLine(PasswordGuess);

                            if (PasswordGuess == Password)
                            {
                                PasswordFound = true;
                                Trace.WriteLine("Found the password!");
                            }
                            B++;
                        }
                    }
                    i++;
                }

            }
        }

        public static void Timer()
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
