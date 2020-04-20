using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace BruteForcer
{
    class BruteForce
    {

        public static bool PasswordFound = false;
        public static string Password = "ZZZ";

        public static void Brute()
        {
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
    }
}
