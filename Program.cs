using GuyObject;


Random random = new Random(); // new instance of the Random class

double odds = .75; //the odds to beat

Wager player = new Wager() { Cash = 100, Name = "The player" }; // a Wager variable called The player

Console.WriteLine($"Welcome to the casino. The odds are {odds}"); // Write a line to the console welcoming the player and printing the odds.

//while (true) // changed this to read player.Cash
while (player.Cash > 0)
{
    player.WriteMyInfo(); // print the amount of cash the player has.

    Console.Write("How much do you want to bet: "); //Ask the user how much money to bet.

    string howMuch = Console.ReadLine(); // Read the line into a string variable called howMuch.

    if (howMuch == "") return;

    if (int.TryParse(howMuch, out int amount)) ; // Try to parse it into an int variable called amount.

    int pot = amount * 2;// int variable called pot. It gets multiplied by two
    double randomOdds = random.NextDouble();// 6. The program picks a random number between 0 and 1.

    if (randomOdds > odds) // 7. If the number is greater than odds, the player receives the pot.
    {
        Console.WriteLine($"You won {pot} bucks!");
        player.Cash += pot;
    }
    else
    {
        Console.WriteLine($"Bad Luck You loose"); // If not, the player loses the amount they bet.
        player.Cash -= amount;
    }

    if (player.Cash <= 0)
    {
        Console.WriteLine("Game Over, The House always wins!");
        return;
    }
    
}
