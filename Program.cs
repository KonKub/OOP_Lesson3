using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем счета
            BankAccount bankAccount1 = new BankAccount(0, AccountType.Current);
            BankAccount bankAccount2 = new BankAccount(0, AccountType.Current);
            BankAccount bankAccount3 = new BankAccount(0, AccountType.Current);
            BankAccount bankAccount4 = new BankAccount(0, AccountType.Current);
            BankAccount bankAccount5 = new BankAccount(0, AccountType.Current);


            //Выводим номера счетов
            Console.WriteLine(bankAccount1.Number);
            Console.WriteLine(bankAccount2.Number);
            Console.WriteLine(bankAccount3.Number);
            Console.WriteLine(bankAccount4.Number);
            Console.WriteLine(bankAccount5.Number);

            //Положить на счета
            bankAccount1.Balance = 100;
            bankAccount2.Balance = 200;
            bankAccount3.Balance = 300;
            bankAccount4.Balance = 400;
            bankAccount5.Balance = 500;

            //Снять с другого счета
            bankAccount1.TransferFromAnotherAccount(bankAccount4, 120);
            bankAccount2.TransferFromAnotherAccount(bankAccount3, 1020);

            Console.ReadKey();
        }
    }
}
