using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringInverting stringInverting = new StringInverting();

            Console.WriteLine(stringInverting.InvertString("abcdefghijklmnopqastuvwxyz"));

            Console.ReadKey();
        }
    }
}
