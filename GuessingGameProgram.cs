

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int guess;
        int guesses;
        int min = 1;
        int max = 100;
        int number;
        bool playAgain = true;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            number = random.Next(min, max + 1);

            
            
            while (guess != number)
            {
                Console.WriteLine("Guess a number from 1 to 100");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < number)
                {
                    Console.WriteLine(guess + " is too low!");
                }
                else if (guess > number)
                {
                    Console.WriteLine(guess + " is too high!");
                }
                else
                {
                    Console.WriteLine(" YOU WIN!");
                }
                guesses++;  
            }
            Console.WriteLine("You have guessed " + guesses + " times");
            Console.WriteLine("Number: " + number );
        }
        
    }
}