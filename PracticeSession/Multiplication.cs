﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSession
{
    
    public class Multiplication
    {
        public void Multi()
        {
            Console.Write("Input the Table number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0} X {1} = {2} \n", n, i, n * i);

            }
        }
    }
}
