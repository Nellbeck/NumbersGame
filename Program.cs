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
            Random rand = new Random();
            int number = rand.Next(0, 26);
            return number; // A method to generate a random number from 0 to 25
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök:");
            int randomNumber = RandomNumber(); // Veriable that calls the method and holds that output from the method
            int count = 5;
            Console.WriteLine(randomNumber);

            for (int round = 5; round > 0; round--) 
            {
                int userNumber;

                while (true) 
                {
                    try
                    {
                        userNumber = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception) 
                    {
                        Console.WriteLine("Skriv bara siffror.");
                    }
                } // Loop that will check so that user only use numbers as input.

                if (userNumber == randomNumber)
                {
                    Console.WriteLine("Wohoo! Du klarade det!"); // output message if the guessed number matches the random generated one.
                    break;
                }

                else if (userNumber > randomNumber)
                {
                    count--;
                    Console.WriteLine($"Tyvärr, du gissade för högt! Du har {count} gissningar kvar."); // output message if the guessed number is to high
                }

                else 
                {
                    count--;
                    Console.WriteLine($"Tyvärr, du gissade för lågt! Du har {count} gissningar kvar."); // output message if the guessed number is to low.
                }
                
            } // A loop that will loop 5 times or untill the user have guessed the right number.
            Console.WriteLine();

            if (count == 0)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök! Spelet är slut."); // output message if you've guessed wrong 5 times
            }
        }
    }
}