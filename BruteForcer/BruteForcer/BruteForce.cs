using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace BruteForcer
{
    class BruteForce
    {
        public static int Threads = 3;


        public static bool PasswordFound = false;
        public static string password = "CLOVE";
        static int guesses = 0;


        public static void setup()
        {
            BruteForce.PasswordFound = false;
            Thread timer = new Thread(new ThreadStart(Timer));
            timer.Start();
            for (int i = 0; i != Threads; i++)
            {
                 Trace.WriteLine("Creating thread " + i.ToString());
                Thread Brute = new Thread(new ThreadStart(BruteForce.newBrute));
                Brute.Start();
            }
            

        }

        public static void newBrute()
        {
            string[] Characters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X",
                "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "" };
            List<string> PasswordGuess = new List<string>();
            
            while (PasswordFound == false)
            {
                string passguess = "";
                for (int i = 0; i != 15; i++)
                {
                   // Trace.WriteLine(password);
                    Random rand = new Random();
                    int A = rand.Next(0, 34);
                    passguess = passguess.Insert(i, Characters[A]);
                    //Console.UserConsole(passguess);
                    guesses++;
                    //Console.UserConsole(Characters.Length);
                    if (passguess == password)
                    {
                        Console.UserConsole("DONE!");
                        PasswordFound = true;
                    }
                }
            }
            Console.UserConsole("Done!");


        }


        public static void Timer()
        {
            double TimeTook = 0;
            while (PasswordFound == false)
            {
                Thread.Sleep(100);
                TimeTook += 0.1;
            }
            Console.UserConsole("This operation took " + TimeTook.ToString() + " Seconds!");
            Console.UserConsole("It took " + guesses + " guesses!");

        }
    }
}

