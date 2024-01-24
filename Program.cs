using Wager;


Random random = new Random(); // new instance of the Random class

double odds = .75; //the odds to beat

Wager.Wager player = new Wager.Wager() { Cash = 100, Name = "The player" }; // a Wager variable called The player

Console.WriteLine($"Welcome to the casino. The odds are {odds}"); // Write a line to the console welcoming the player and printing the odds.

while (player.Cash > 0)
{
    player.WriteMyInfo(); // print the amount of cash the player has.

    Console.Write("How much do you want to bet: "); // Ask the player place their bet.

    string howMuch = Console.ReadLine(); // Read the line into a string variable called howMuch.

    if (howMuch == "") return; // if the input is empty return

    if (int.TryParse(howMuch, out int amount)); // Try to parse it into an int variable called amount.  

    int pot = amount * 2; // int variable called pot. It gets multiplied by two
    double randomOdds = random.NextDouble(); // The program picks a random number between 0 and 1.
    
    if (randomOdds > odds) // If the number is greater than odds, the player receives the pot.
    {
        Console.WriteLine($"You won {pot} bucks!");
       player.ReceiveCash(pot); // player won double their bet
    }
    else
    {
        player.GiveCash(amount); // player lost bet
    }

    if (player.Cash <= 0)
    {
        Console.WriteLine("Game Over, The House always wins!");
        return;
    }
    
}
