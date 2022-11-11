using PracticeSession;
using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine(" \n \n Practice Session");
                Console.WriteLine("Press The Below Options");
                Console.WriteLine(" 1.Alphabet \n 2.Ascii \n 3.Factorial \n 4.Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        Alphabet alphabets = new Alphabet();
                        alphabets.Aplhabets();
                        break;
                    case 2:
                        Ascii ascii = new Ascii();
                        ascii.Asci();
                        break;
                    case 3:
                        Factorial factorial = new Factorial();
                        factorial.Fact();
                        break;
                    case 4:
                        flag = false;
                        break;
                }

            }
        }
    }
}

