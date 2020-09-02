using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Session03Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konvertera det inmatade värdena från strängar till siffror
            // Resultatet skall presentera:
            // Lägsta värdet
            // Högsta värdet
            // Medelvärde (snitt)
            // Programmet skall vara felhanterat
            // Felaktiga värden får inte påverka medelvärde, lägsta eller högsta.

            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");

            var input = Console.ReadLine();
            var inputArray = input.Split(new [] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            
            double totalValue = 0;

            for(int i = 0; i < inputArray.Length; i++)
            {
                if(i == num)
                totalValue += Convert.ToDouble(inputArray[i], System.Globalization.CultureInfo.InvariantCulture);
            }
            double averageNumber = totalValue / inputArray.Length;

            
            Console.WriteLine($"Listan innehåller {inputArray.Length} siffror.");
            Console.WriteLine($"Lägsta nummer: {inputArray.Min()}, Högsta nummer: {inputArray.Max()}");
            Console.WriteLine($"Medelvärdet blir: {averageNumber}");
        }
    }
}
