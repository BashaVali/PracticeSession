using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSession
{ 
    
        public class Ascii
        {
            public void Asci()
            {
                char c;
                for (c = 'A'; c <= 'Z'; c++)
                {
                    int num = Convert.ToInt32(c);
                    Console.WriteLine("The ASCII value {0} is {1} ", c, num);
                }
            }
        }
    
}