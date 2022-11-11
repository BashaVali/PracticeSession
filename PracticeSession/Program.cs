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
                Console.WriteLine(" 1.Alphabet \n 2.Ascii \n 3.Exit");
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
                        flag = false;
                        break;
                }

            }
        }
    }
}

