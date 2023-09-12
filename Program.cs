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
            int number = rand.Next(0, 25);
            return number; // A method to generate a random number from 0 to 25
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök:");
            int count = 0;
            int randomNumber = RandomNumber(); // Veriable that calls the method and holds that output from the method

            for (int round = 0; round < 5; round++) 
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
                    Console.WriteLine("Tyvärr, du gissade för högt!"); // output message if the guessed number is to high
                }

                else 
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!"); // output message if the guessed number is to low.
                }
                count++;
            } // A loop that will loop 5 times or untill the user have guessed the right number.

            Console.WriteLine();

            if (count == 5)
            {
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!"); // output message if you've guessed wrong 5 times
            }
        }
    }
}