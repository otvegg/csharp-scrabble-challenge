using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class Scrabble
    {
        public string _word;
        private Dictionary<char, int> _dictionary = new Dictionary<char, int>
        {
            { 'A', 1 },
            { 'E', 1 },
            { 'I', 1 },
            { 'O', 1 },
            { 'U', 1 },
            { 'L', 1 },
            { 'N', 1 },
            { 'R', 1 },
            { 'S', 1 },
            { 'T', 1 },
            { 'D', 2 },
            { 'G', 2 },
            { 'B', 3 },
            { 'C', 3 },
            { 'M', 3 },
            { 'P', 3 },
            { 'F', 4 },
            { 'H', 4 },
            { 'V', 4 },
            { 'W', 4 },
            { 'Y', 4 },
            { 'K', 5 },
            { 'J', 8 },
            { 'X', 8 },
            { 'Q', 10 },
            { 'Z', 10 }
        };
        public Scrabble(string word)
        {
            _word = word;
        }

        public int score()
        {
            int sum = 0;
            int openCurly = 0;
            int openHard = 0;
            int BonusMultiplier = 1; // 1 -> no bonus, 2 -> double, 3 -> triple
            foreach (char item in _word)
            {
                if (char.IsWhiteSpace(item)) return 0;
                if (char.IsNumber(item)) return 0;
                if (item == '{')
                {
                    openCurly++;
                    BonusMultiplier = BonusMultiplier * 2;
                }
                else if (item == '[') 
                {
                    openHard++;
                    BonusMultiplier = BonusMultiplier * 3; 
                }
                else if (item == '}')
                {
                    if (openCurly == 0) return 0;
                    openCurly--;
                    BonusMultiplier = BonusMultiplier / 2;
                }
                else if (item == ']') 
                {
                    if (openHard == 0) return 0;
                    openHard--;
                    BonusMultiplier = BonusMultiplier / 3;
                }
                else
                {
                    char letter = char.Parse(item.ToString().ToUpper());
                    sum = sum + _dictionary[letter] * BonusMultiplier;
                }
            }
            return sum;
        }
    }
}
