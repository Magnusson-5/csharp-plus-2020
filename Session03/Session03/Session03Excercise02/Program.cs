using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            string numbersOnly = Regex.Replace(input, "[^0-9.,-]", "");
            var inputArray = numbersOnly.Split(new [] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            double totalValue = 0;
            double minValue = Convert.ToDouble(inputArray[0], System.Globalization.CultureInfo.InvariantCulture);
            double maxValue = Convert.ToDouble(inputArray[0], System.Globalization.CultureInfo.InvariantCulture);

            foreach (var i in inputArray)
            {
                
                double number = Convert.ToDouble(i, System.Globalization.CultureInfo.InvariantCulture);
                totalValue += number;

                if(number > maxValue)
                {
                    maxValue = number;
                }
                if(number < minValue)
                {
                    minValue = number;
                }

            }

            double averageNumber = totalValue / inputArray.Length;

            Console.WriteLine($"Listan innehåller {inputArray.Length} siffror.");
            Console.WriteLine($"Lägsta nummer: {minValue} Högsta nummer: {maxValue}");
            Console.WriteLine($"Medelvärdet blir: {averageNumber}");
        }
    }
}
