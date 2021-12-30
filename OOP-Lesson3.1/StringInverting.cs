using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lesson3._1
{
    class StringInverting
    {
        public string InvertString(string AString)
        {
            return new string(AString.Reverse().ToArray());
        }
    }
}
