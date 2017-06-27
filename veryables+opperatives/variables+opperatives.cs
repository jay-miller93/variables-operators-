using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veryables_opperatives
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reservation");
            string reserveName = Console.ReadLine();
            Console.WriteLine("How many people are in your party");
            int numberOfPeople = int.Parse(Console.ReadLine());
            Console.WriteLine("Total Due=");

            double amountEach = 13.53d;

            double totalBill = numberOfPeople * amountEach;
            Console.WriteLine(totalBill);
            Console.WriteLine("Reservation: " + reserveName);
            Console.WriteLine("Total Due: $" + totalBill);



        




            Console.WriteLine("Cups of sugar");
            int cupsOfSugar= int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups of sugar do you have?");
            int totalCupsLisaHas = int.Parse(Console.ReadLine());
            int totalCupsNeeded = cupsOfSugar - totalCupsLisaHas;
            Console.WriteLine(totalCupsNeeded);
            Console.WriteLine("Cups of sugar");







    
        }
    }
}
