int predefined = 98;
int x;
int attempts = 0;

while(true)
{
    Console.Write("Make your guess : ");
    x = Convert.ToInt32(Console.ReadLine());
    attempts++;

    if (x > predefined)
    {
        Console.WriteLine("Guess Lower");
    }
    else if (x < predefined)
    {
        Console.WriteLine("Guess Higher");
    }
    else
    {
        break;
    }
}
 Console.WriteLine("Congratulations! you got that!");
 Console.WriteLine("You guessed the number in " + attempts   + " attempts");
