using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringProc stringProc = new StringProc();

            stringProc.ProcessFile("name_mail.txt", "mail.txt");

            Console.ReadKey();
        }
    }
}
