using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Witaj w grze Zgadnij Liczbe \n aby wygrac zgadnij liczbe z zakresu 0-100");
                GameCore();
                if (ExitMenu())
                    break;

            }

            Console.WriteLine("Dzieki za gre");
            Console.ReadLine();

        }

        private static int DrawNumber()
        {
            Random random = new Random();
            return random.Next(0, 100);
        }

        private static void GameCore()
        {
            var number = DrawNumber();
            int numberOfTries = 0;
            while (true)
            {
                Console.WriteLine("Podaj twoja liczbę : ");
                if (!int.TryParse(Console.ReadLine(), out int playerNumber))
                {
                    Console.WriteLine("Podano nie prawidłową wartość sprobuj jeszcze raz \n");
                    continue;
                }
                numberOfTries++;

                if (playerNumber > number)
                {
                    Console.WriteLine("Twoja liczna jest za wysoka");
                    continue;
                }

                if (playerNumber < number)
                {
                    Console.WriteLine("Twoja liczna jest za niska");
                    continue;
                }

                if (playerNumber == number)
                    break;
            }

            Console.WriteLine($"Gratulacje Zgadłeś za {numberOfTries} razem !! \nWygrana Liczba to {number} \n");
        }

        private static bool ExitMenu()
        {
            while (true)
            {
                Console.WriteLine("Nacisnij S aby sprobowac jeszczre raz lub X aby zakonczyć");
                var choose = Console.ReadLine().ToUpper();
                if (choose.Equals("X"))
                    return true;

                if (choose.Equals("S"))
                    return false;

                continue;
            }
        }
    }
}
