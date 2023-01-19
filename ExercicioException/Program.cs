using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioException.Entities;
using ExercicioException.Entities.Exceptions;

class URI
{

    static void Main(string[] args)
    {
        try
        {
            Account ac = new Account();

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            ac.Number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            ac.Holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            ac.Balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            ac.WithDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ac.WithDraw(amount);


            Console.WriteLine("New balance: " + ac.Balance);
        }
        catch(DomainException e)
        {
            Console.WriteLine(e.Message);
        }
    }

}