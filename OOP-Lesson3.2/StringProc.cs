using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OOP_Lesson3._3
{
    class StringProc  //Работа со строками
    {
        private void SearchMail(ref string S)
        {
            S = S.Trim();
            if (S.Length > 0)
            {
                int Pos = S.IndexOf('&');
                if (Pos >= 0)
                    S = S.Remove(0, Pos + 1).Trim();
                else
                    S = "Нет почтового ящика";
            }
        }

        public void ProcessFile(string FromFile, string ToFile)
        {
            using (StreamReader SRead = new StreamReader(FromFile, System.Text.Encoding.Default))
            {
                using (StreamWriter SWrite = new StreamWriter(ToFile, false, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = SRead.ReadLine()) != null)
                    {
                        Console.Write($"{line} -> ");
                        SearchMail(ref line);
                        SWrite.WriteLine(line);
                        Console.WriteLine(line);
                    }
                    SWrite.Close();
                }
                SRead.Close();
            }
            Console.WriteLine("");
            Console.WriteLine($"Файл {FromFile} обработан.");
            Console.WriteLine($"Результат в файле {ToFile}.");
        }
    }
}
