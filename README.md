Here’s a `README.md` that you can use for your Hangman game project:

---

# Hangman Game

This is a simple console-based Hangman game written in C# where players try to guess a word by inputting one letter at a time. The game will track incorrect guesses, and the player will have a limited number of attempts based on the length and difficulty of the word.

## Features

- Random word selection from a predefined dictionary of words.
- Track correct and incorrect guesses.
- Display the current state of the word with underscores (`_`) for unguessed letters.
- Limited number of attempts based on the difficulty of the word.
- Clear feedback after each guess (correct, incorrect, or repeated guesses).

## How to Play

1. The program will randomly choose a word from the list of possible words.
2. You will have to guess one letter at a time.
3. The number of incorrect guesses allowed depends on the length and difficulty of the word.
4. The game will display underscores (`_`) for each letter in the word. As you guess correctly, the letters will be revealed.
5. If you guess incorrectly too many times, you lose the game.
6. If you guess the word correctly before running out of attempts, you win!

## Game Rules

- Each word has a set number of wrong guesses allowed (based on its difficulty).
- Words are selected randomly from the predefined list.
  - Shorter words (`shy`, `hello`) allow for 3 incorrect guesses.
  - Medium words (`giraffe`, `gigantic`) allow for 4 incorrect guesses.
  - Longer words (`oxymoron`) allow for 6 incorrect guesses.
- Only lowercase letters are accepted for guesses.

## Requirements

- .NET SDK (6.0 or higher) installed.
- A terminal or command-line interface to run the program.

## How to Run the Game

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/hangman.git
   ```

2. Navigate to the project directory:

   ```bash
   cd hangman
   ```

3. Open the project in Visual Studio or your preferred code editor.

4. Build and run the application:

   - In Visual Studio, press `Ctrl+F5` to run without debugging.
   - Alternatively, use the command line:

     ```bash
     dotnet run
     ```

## Code Overview

### Main Components

- **Word Dictionary**: The game uses a dictionary of words and selects one at random. The list currently includes words like `shy`, `hello`, `giraffe`, etc.
  
- **Game Loop**: The game continues to prompt the user for guesses until they either guess the word correctly or run out of attempts.

- **Input Validation**: The game ensures that players only enter lowercase letters and that they don’t repeat guesses.

- **Feedback**: After each guess, the program shows the current state of the word with underscores, the incorrect guesses, and the number of tries left.

### Key Variables

- **`words`**: A dictionary that contains words indexed by numbers.
- **`random`**: A randomly selected index that chooses the word from the `words` dictionary.
- **`wrongMax`**: The maximum number of wrong guesses allowed based on the difficulty of the word.
- **`wrongCurrent`**: Tracks how many wrong guesses the player has made so far.
- **`update`**: A string that holds the current state of the word (with underscores for unguessed letters).
- **`playerInput`**: The letter the player guesses during each round.
- **`correct`**: The number of correct guesses made.

### Game Outcome

- **Win**: If the player guesses all the letters correctly before reaching the maximum number of wrong guesses, they win.
- **Lose**: If the player exhausts all their attempts without guessing the word, they lose.

## Example Output

```
Welcome to Hangman! :)

The word is: _ _ _ _
Incorrect guesses: 
You have 3 tries left

Type your guess: e
The word is: _ e _ _
Incorrect guesses: 
You have 3 tries left

Type your guess: r
The word is: _ e r _
Incorrect guesses: 
You have 3 tries left

Type your guess: t
The word is: _ e r t
Incorrect guesses: 
You have 3 tries left

Type your guess: a
The word is: a e r t
Incorrect guesses: a
You have 3 tries left

You won! The word was: a e r t
```
![hangmangif](https://github.com/user-attachments/assets/8b3c6eb1-eb36-440f-bcd5-ac8c44fa5080)

## License

This project is open source and available under the MIT License. See the [LICENSE](LICENSE) file for more details.

---

### Notes:

- **Repository URL**: Be sure to replace `yourusername` in the GitHub link with your actual GitHub username.
- **Customizations**: You can modify the `words` dictionary to add more words or adjust the rules as you see fit.
