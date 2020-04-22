using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace BruteForcer
{
    class BruteForce
    {
        public static int Threads = 2;


        public static bool PasswordFound = false;
        public static string Password = "Z37AJ";

        public static void setup()
        {

            Thread timer = new Thread(new ThreadStart(Timer));
            timer.Start();
            for (int i = 0; i != Threads; i++)
            {
               // Trace.WriteLine("Creating thread " + i.ToString());
                Thread Brute = new Thread(new ThreadStart(BruteForce.Brute));
                Brute.Start();
            }
            BruteForce.PasswordFound = false;

        }
        public static void Brute()
        {
            string[] Characters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2","3","4","5","6","7","8","9" };
            while (PasswordFound == false)
            {
                string PasswordGuess;
                int i = 0;
                
                while (i != 34 && PasswordFound == false)
                {

                    Random rnd = new Random();
                    int num = rnd.Next(0, 34);
                    PasswordGuess = Characters[num];
                    //Trace.WriteLine(PasswordGuess);

                    if (PasswordGuess == Password)
                    {
                        PasswordFound = true;
                        Trace.WriteLine("Found the password!");
                        Trace.WriteLine(PasswordGuess);
                    }


                    int A = 0;
                    while (A < 34 && PasswordFound == false)
                    {
                        num = rnd.Next(0, 34);
                        int num2 = rnd.Next(0, 34);
                        //Trace.WriteLine(i.ToString() + " " + A.ToString());
                        PasswordGuess = Characters[num] + Characters[num2];
                       // Trace.WriteLine(PasswordGuess);

                        if (PasswordGuess == Password)
                        {
                            PasswordFound = true;
                            Trace.WriteLine("Found the password!");
                            Trace.WriteLine(PasswordGuess);
                        }
                        

                        int B = 0;
                        while (B < 34 && PasswordFound == false)
                        {
                            num = rnd.Next(0, 34);
                            num2 = rnd.Next(0, 34);
                            int num3 = rnd.Next(0, 34);
                            //Trace.WriteLine(i.ToString() + " " + A.ToString());
                            PasswordGuess = Characters[num] + Characters[num2] + Characters[num3];
                            //Trace.WriteLine(PasswordGuess);

                            if (PasswordGuess == Password)
                            {
                                PasswordFound = true;
                                Trace.WriteLine("Found the password!");
                                Trace.WriteLine(PasswordGuess);
                            }
                            int C = 0;
                            while (C <34 && PasswordFound == false)
                            {
                                num = rnd.Next(0, 34);
                                num2 = rnd.Next(0, 34);
                                num3 = rnd.Next(0, 34);
                                int num4 = rnd.Next(0, 34);
                                //Trace.WriteLine(i.ToString() + " " + A.ToString());
                                PasswordGuess = Characters[num] + Characters[num2] + Characters[num3] + Characters[num4];
                                //Trace.WriteLine(PasswordGuess);

                                if (PasswordGuess == Password)
                                {
                                    PasswordFound = true;
                                    Trace.WriteLine("Found the password!");
                                    Trace.WriteLine(PasswordGuess);
                                }
                                int D = 0;
                                while (D < 34 && PasswordFound == false)
                                {
                                    num = rnd.Next(0, 34);
                                    num2 = rnd.Next(0, 34);
                                    num3 = rnd.Next(0, 34);
                                    num4 = rnd.Next(0, 34);
                                    int num5 = rnd.Next(0, 34);
                                    //Trace.WriteLine(i.ToString() + " " + A.ToString());
                                    PasswordGuess = Characters[num] + Characters[num2] + Characters[num3] + Characters[num4] + Characters[num5];
                                    //Trace.WriteLine(PasswordGuess);

                                    if (PasswordGuess == Password)
                                    {
                                        PasswordFound = true;
                                        Trace.WriteLine("Found the password!");
                                        Trace.WriteLine(PasswordGuess);
                                    }
                                    D++;
                                }
                                C++;
                            }

                            B++;
                        }
                        A++;
                    }
                    i++;
                }

            }
        }

        public static void newBrute()
        {
            string[] Characters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string password = "Clover2014";
            List<string> PasswordGuess = new List<string>();
            string passguess = "";
            for (int i = 0; i < 25; i++)
            {
               
                passguess = Characters[i];
                Trace.WriteLine(passguess);
                for (int a = 0; a <25; a++)
                {
                    passguess += Characters[a];
                    Trace.WriteLine(passguess);
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
