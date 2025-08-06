// See https://aka.ms/new-console-template for more information

using csharp_scrabble_challenge.Main;

Console.WriteLine("Welcome to Scrabble");
Console.WriteLine("Enter a word and get the score! Add a {} or [] around a letter or multiple letters to multiply score by 2 or 3 respectively");
Console.WriteLine("To exit press q and Enter.");
while  (true)
{
    string word = Console.ReadLine();
    if (word == "q") break;
    Scrabble scrabble = new Scrabble(word);
    Console.WriteLine($"{scrabble.score()}");
}

Console.WriteLine("Exiting... Thanks for playing!");