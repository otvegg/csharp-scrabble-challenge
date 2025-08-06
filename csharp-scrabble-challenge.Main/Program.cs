// See https://aka.ms/new-console-template for more information

using csharp_scrabble_challenge.Main;

Console.WriteLine("Welcome to Scrabble! To exit press q and Enter.");
while  (true)
{
    Console.WriteLine("Enter a word and get the score! Add a {} or [] around a letter or multiple letters to multiply score by 2 or 3 respectively");
    string word = Console.ReadLine();
    
    Scrabble scrabble = new Scrabble(word);
    scrabble.score();


}