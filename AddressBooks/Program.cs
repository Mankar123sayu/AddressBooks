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

            Console.Write("Enter the number of contact you want to save: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                main.AddContact();
                main.Display();
            }
        }
    }
}
