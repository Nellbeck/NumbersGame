using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;


/*
 * Fredrik Nellbeck
 * .NET23_OOP
 * Systemutveckling.NET med AI-kompetens
*/
namespace NumbersGame
{
    internal class Program
    {
        public static int RandomNumber()
        {
            Random random = new Random();
            int number = random.Next(26, 26);
            return number; // A method to generate a random number from 0 to 25
        }
        static void Main(string[] args)
        {
            int tryAgainCount = 0;

            do
            {
                int randomNumber = RandomNumber(); // Veriable that calls the method and holds a new value when called. 
                Console.Clear(); // clears the console from text.
                Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 0 och 25. Kan du gissa vilket? Du får fem försök:");
                int tryCount = 5;
                Console.WriteLine(randomNumber);
                for (int userTrys = 5; userTrys > 0; userTrys--)
                {
                    int userNumber;

                    while (!int.TryParse(Console.ReadLine(), out userNumber))
                    {
                        Console.WriteLine("Skriv in bara siffror.");
                    } // Loop that will check so that user only use numbers as input.

                    if (userNumber == randomNumber)
                    {
                        Console.WriteLine("Wohoo! Du klarade det!"); // output message if the guessed number matches the random generated one.
                        break;
                    }

                    else if (userNumber >= 26)
                    {
                        Console.WriteLine("Gissa bara på tal mellan 0 och 25."); // output message if the guessed number is higher then 25 and won't count it as a try.
                        userTrys++;
                    }

                    else if (userNumber > randomNumber)
                    {
                        tryCount--;
                        Console.WriteLine($"Tyvärr, du gissade för högt! Du har {tryCount} gissningar kvar."); // output message if the guessed number is to high
                    }

                    else
                    {
                        tryCount--;
                        Console.WriteLine($"Tyvärr, du gissade för lågt! Du har {tryCount} gissningar kvar."); // output message if the guessed number is to low.
                    }

                } // A loop that will loop 5 times or untill the user have guessed the right number.
                Console.WriteLine();

                if (tryCount == 0)
                {
                    Console.WriteLine("Du lyckades inte gissa talet på fem försök!"); // output message if you've guessed wrong 5 times
                }
                Console.WriteLine();
                Console.WriteLine("Tryck på en tangent...");
                Console.ReadKey(); // wait for the user to push a key.
                Console.Clear(); // clears the console.
                Console.WriteLine("Vill du spela igen? Ja eller nej:");

                while (true)
                {
                    string tryAgain = Console.ReadLine();
                    if (tryAgain.ToLower() == "ja")
                    {
                        Console.WriteLine("Då kör vi en gång till!");
                        Console.WriteLine();
                        Console.WriteLine("Tryck på en tangent...");
                        Console.ReadKey(); // wait for the user to push a key. 
                        break;
                    }

                    else if (tryAgain.ToLower() == "nej")
                    {
                        Console.WriteLine("Spelet avslutas!");
                        Console.WriteLine();
                        Console.WriteLine("Tryck på en tangent...");
                        Console.ReadKey();// wait for the user to push a key.
                        tryAgainCount = 1;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Förlåt, jag förstod inte.");
                    }  // loop that will ask the user if they want to play again.
                }
            }
            while (tryAgainCount == 0);
        }
    }
}