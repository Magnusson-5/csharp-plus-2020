using System;

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

            foreach (var number in inputArray)
            {
                Console.WriteLine("Värdet är " + number);
            }










            Console.WriteLine("Ange siffror, separerat med kommatecken");

            var input = Console.ReadLine();
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);


            //Fungera med double.
            double[] listaN = new double[inputArray.Length];
            Console.WriteLine(listaN.ToString());
            
            
            double total = 0;
            double antalNummer = 0;

            foreach (var nummer in inputArray)
            {
                double.TryParse(nummer, out double v);

                total = total + v;
                listaN[(int)antalNummer++] = v; ;
            }

            double minNummer = Convert.ToDouble(listaN.Min());
            double maxNummer = listaN.Max();
            double medelvärdet = total / antalNummer;

            Console.WriteLine($"Listan innehåller {listaN.Length} siffror.");
            Console.WriteLine($"Medelvärdet blir: {medelvärdet}");
            Console.WriteLine($"Lägsta nummer: {listaN.ToArray().ToMin(}, Högsta nummer: {listaN.Max()}");

            Console.ReadKey();

            //*/

            /*
            List<int> nummerLista = new List<int>();
            int total = 0;
            int antalNummer = 0;

             foreach (var nummer in inputArray)
             {
                    total = total + Convert.ToInt32(nummer);
                    antalNummer++;
                    nummerLista.Add(Convert.ToInt32(nummer));
             }

            int medelvärdet = total / antalNummer;

            Console.WriteLine($"Medelvärdet blir: {medelvärdet}");
            Console.WriteLine($"Lägsta nummer: {Convert.ToInt32(nummerLista.Min())}, Högsta nummer: {Convert.ToInt32(nummerLista.Max())}");

            Console.ReadKey();
            */

        }
    }
}
