using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks for users name and stores it as variable
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        // Coin flip question
        Console.WriteLine($"Hi {name}, do you want to do the COIN FLIP CHALLENGE? (Yes/No)");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "no")
        {
            // Call the user a coward and end the program
            Console.WriteLine($"{name} you are a coward. Good day!");
        }
        else if (answer.ToLower() == "yes")
        {
            // Start of the challenge score tracks the value
            int score = 0;
            Console.WriteLine("Let's start the challenge!");

            // Loop that will run 5 times
            for (int i = 1; i <= 5; i++)
            {
                // draws a random number and assigns it a variable
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, 2);

                // Asks the user for heads or tails and stores there response as a variable
                Console.WriteLine($"Round {i}: Enter heads or tails");
                string guess = Console.ReadLine();

                // Tough part had to google - it compares the user's guess to the random generated number
                if ((guess.ToLower() == "heads" && randomNumber == 0) || (guess.ToLower() == "tails" && randomNumber == 1))
                {
                    // This will give the user a +1 in score if guessed correctly
                    score++;
                    Console.WriteLine("Correct!");
                }
                else //User is wrong and messaged is displayed
                {
                    Console.WriteLine("Wrong!");
                }
            }

            // Gives user there final score
            Console.WriteLine($"Your final score is: {score}");
        }
        else
        {
            Console.WriteLine("Invalid answer. Please try again.");
        }       
    }
}
