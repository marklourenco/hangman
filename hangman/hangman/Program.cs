// Mark Jeremy Lourenco Rojas
// Chin Tang

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary with words possible

            Dictionary<int, string> words = new Dictionary<int, string>();
            words.Add(1, "shy");
            words.Add(2, "hello");
            words.Add(3, "giraffe");
            words.Add(4, "gigantic");
            words.Add(5, "oxymoron");

            // Random number to decide word

            Random rnd = new Random();

            int random = rnd.Next(1, 6);

            string chosenWord = words[random];

            // How many wrong answers possible per word

            int wrongMax;
            int wrongCurrent = 0;

            if (random <= 2)
            {
                wrongMax = 3;
            }
            else if (random == 3)
            {
                wrongMax = 4;
            }
            else
            {
                wrongMax = 6;
            }

            // Add underscores depending on how many letters

            int letters = words[random].Length;
            string update = "_";

            for (int i = 1; i < letters; i++)
            {
                update += "_";
            }

            char[] individualLetters = words[random].ToCharArray();
            char[] updateToChar = update.ToCharArray();

            // Print start

            Console.WriteLine("Welcome to Hangman! :)");

            string wrongGuesses = "";

            char playerInput;

            bool valid = true;

            bool added = true;
            bool repeat = false;

            int correct = 0;

            // Game while loop

            while (wrongCurrent < wrongMax + 1 && correct != words[random].Length)
            {
                // Print underscores

                Console.Write("\nThe word is: ");
                for (int i = 0; i < letters; i++)
                {
                    Console.Write($"{updateToChar[i]} ");
                }

                // Print incorrect guesses

                Console.Write("\n\nIncorrect guesses: ");
                for (int i = 0; i < wrongGuesses.Length; i++)
                {
                    Console.Write($"{wrongGuesses[i]} ");
                }

                Console.Write($"\n\nYou have {wrongMax - wrongCurrent + 1} tries left");

                // Ask for player input

                do
                {
                    Console.Write("\n\nType your guess: ");
                    playerInput = Console.ReadLine()[0];

                    valid = true;
                    repeat = false;

                    if (playerInput < 97 || playerInput > 122)
                    {
                        Console.Write("\nOnly use lowercase!");
                        valid = false;
                    }

                    for (int i = 0; i < letters; i++)
                    {
                        if (playerInput == updateToChar[i])
                        {
                            valid = false;
                            repeat = true;
                        }
                        foreach (char c in wrongGuesses)
                        {
                            if (playerInput == c)
                            {
                                valid = false;
                                repeat = true;
                            }
                        }
                    }
                    if (repeat == true)
                    {
                        Console.Write("\nYou have already guessed that letter.");
                    }
                } while (valid == false);

                for (int i = 0; i < letters; i++)
                {
                    if (playerInput == individualLetters[i])
                    {
                        updateToChar[i] = individualLetters[i];
                        added = false;
                        correct++;
                    }
                }
                if (added == true)
                {
                    wrongGuesses += playerInput;
                    wrongCurrent++;
                }
                added = true;
                Console.Clear();
            }
            if (wrongCurrent >= wrongMax + 1)
            {
                Console.Write("\nYou lost! The word was: ");
                for (int i = 0; i < letters; i++)
                {
                    Console.Write($"{individualLetters[i]}");
                }
                Console.WriteLine();
            }
            else
            {
                Console.Write("\nYou won! The word was: ");
                for (int i = 0; i < letters; i++)
                {
                    Console.Write($"{individualLetters[i]}");
                }
                Console.WriteLine();
            }

        }
    }
}