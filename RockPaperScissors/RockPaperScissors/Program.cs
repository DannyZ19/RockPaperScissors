int gamesPlayed = 0;
bool didGameFinish = false;
int playerCount = 0;
int botCount = 0;

Random Number = new Random();
int botChoice = Number.Next(1,4);
string systemInput;
Console.WriteLine("Rock Paper Scissors Game");



do
{
    Restart();
    Console.WriteLine("\nWhat will you choose?\n1 for Rock \n2 for Paper \n3 for Scissors");

    string response = Console.ReadLine();

    
switch (botChoice)
    {
        case 1:
            systemInput = "Rock";

            if (response == "1")
            {
                Console.WriteLine("You chose rock and the computer chose rock.\n\nIts a tie!");
            } else if (response == "2")
            {
                Console.WriteLine("You chose paper and the computer chose rock.\n\nYou win!");

                playerCount++;
                Console.WriteLine($"You: {playerCount} \n\nBot: {botCount}");
                didGameFinish = true;
            } else 
            {
                Console.WriteLine($"You chose scissors and the computer chose rock.\n\nYou lose!");
                botCount++;
                Console.WriteLine($"You: {playerCount} \n\nBot: {botCount}");
                didGameFinish = true;
            }


            break;
        case 2:
            systemInput = "Paper";

            if (response == "1")
            {
                Console.WriteLine("You chose rock and the computer chose paper.\n\nYou lose!");

                botCount++;
                Console.WriteLine($"You: {playerCount} \n\nBot: {botCount}");
                didGameFinish = true;

            } else if (response == "2")

            {
                Console.WriteLine("You chose paper and the computer chose paper.\n\nIts a tie!");
            } else
            {
                Console.WriteLine("You chose sccisors and the computer chose paper.\n\nYou win!");
                playerCount++;
                Console.WriteLine($"You: {playerCount} \n\nBot: {botCount}");
                didGameFinish = true;
            }

            break;

        case 3:
            systemInput = "Scissors";

            if (response == "1")
            {
                Console.WriteLine("You chose rock and the computer chose scissors.\n\nYou win!");
                
                playerCount++;
                Console.WriteLine($"You: {playerCount} \n\nBot: {botCount}");
                didGameFinish = true;

            } else if (response == "2")
            {
                Console.WriteLine("You chose paper and the computer chose scissors.\n\nYou lose!");

                botCount++;
                Console.WriteLine($"You: {playerCount} \n\nBot: {botCount}");
                didGameFinish = true;
            } else
            {
                Console.WriteLine("You chose scissors and the computer chose scissors.\n\nIts a tie!");
            }

            break;

            
    }
    

   
} while (true);


void Restart()
{
    botChoice = Number.Next(1, 4);
    didGameFinish= false;
}