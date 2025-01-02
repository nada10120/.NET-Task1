using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Islam's carpet cleaner ");
            Console.WriteLine("Enter how many Carpets Do you want to Clean ");
            Console.WriteLine("How many big ones ?");
            int big_Carpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many small ones ?");

            int small_Carpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small Carpet: $25 Price per Carpet room: $35");
            Console.WriteLine("Total price for small Carpets: $"+(small_Carpet*25) + "Total price for Big Carpets: $"+(big_Carpet*35));
            int Total = small_Carpet*25 + big_Carpet*35;
            int Tax = Total*6 /100;
            Console.WriteLine("Tax : $"+Tax);
            Console.WriteLine("total with tax : $"+ (Total+Tax) );
        }
    }
}