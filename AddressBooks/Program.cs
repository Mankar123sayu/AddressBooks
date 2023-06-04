using AddressBooks;
using System;

namespace AddressBookProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBokkMain main = new AddressBokkMain();
            main.AddContact();
            main.Display();
        }
    }
}
