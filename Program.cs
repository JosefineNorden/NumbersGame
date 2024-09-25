namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)

        {
            bool playAgain = true; 
            Console.WriteLine("Hej och välkommen till Gissa numret! Vill du spela? Svara med Ja/Nej:"); 
            while (playAgain) // While-Loop that handles the choices of the users input.
            {

                string choice = Console.ReadLine().ToUpper();

                if (choice == "JA") // If statement that starts "numbersgame" if the userinput is yes.
                {
                    Console.WriteLine("Då startar vi spelet!");
                    CheckGuess();    // Summons the method CheckGuess.
                }
                else if (choice == "NEJ") // If the userinput is no the game ends.
                {
                    playAgain = false;
                    Console.WriteLine("Spelet avslutas.");                   
                }
                else // If the users input is incorrect the program ask for correct input.
                {
                    Console.WriteLine("Ogiltligt val.");  
                }
                Console.WriteLine("Vill du spela igen? 'Ja'/'Nej'"); //The program ask user if they want to play again.
                string playAgainChoice = Console.ReadLine().ToUpper();
                if (playAgainChoice == "JA")
                {
                    CheckGuess(); // If the input is yes, the program summons the method with the game again.
                }
                else if (playAgainChoice == "NEJ") // if the input is no, the game ends.
                {
                    playAgain = false;
                    Console.WriteLine("Spelet avslutas.");                  
                }
            }
        }
        public static void CheckGuess() // Method with the game "CheckGuess".
        {
            Console.WriteLine("Jag tänker på ett nummer, kan du gissa vilket? Du får fem försök.");
            Console.WriteLine("Skriv in ditt nummer i siffror:");

            var userAttempts = 0; //Declare variables
            bool playOn = true;
            Random random = new Random(); // Creates a random number
            var randomResult = random.Next(1, 21); // Decides that the number should be somwhere in  between 1-20.

            while (playOn) // While-loop that runs the game when the bool "PlayOn" is true.
            {
                int playerNum = 0;  // Declares the variable playerNum to the value of 0.

                while (!Int32.TryParse(Console.ReadLine(), out playerNum)) // A statement that handles the wrong input if the input is not a number.
                { // the variable playerNum gets the users input value.
                    Console.WriteLine("Felaktig input, skriv in en siffra!"); // Error-message if the input is invalid.
                }

                if (playerNum > randomResult) // Checks if the users number is higher than the random number.
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
                else if (playerNum < randomResult) // Checks if the users number is lower than the random number.
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                else if (playerNum == randomResult) // Checks if the users number is the same as the random number.
                {
                    Console.WriteLine("Wooho! Du gjorde det!");
                    playOn = false; // If the user wins, the playOn statement turns into false and the game ends.
                }

                userAttempts++; // increases each try.
                if (userAttempts == 5 && playOn == true) // if the user attempts to guess the number wrong more than five times the statement is false.
                {
                    playOn = false; // Statement is false. Game ends.
                    Console.WriteLine("Tyvärr du lyckades inte gissa rätt på fem försök.");
                }
            }
        }

    }

}
