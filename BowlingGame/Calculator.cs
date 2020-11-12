using System.Collections.Generic;

namespace BowlingGame
{
    public class Calculator
    {
        /// <summary>
        /// This function calculates the score for all rolls in the game
        /// </summary>
        /// <param name="rolls"></param>
        /// <returns></returns>
        public int GetScore(IList<int> rolls)
        {
            int score = 0;
            int i = 0;
 
            for (int f = 0; f < 10; f++)
            {
                if (IsStrike(rolls, i))
                {
                    score += 10 + rolls[i + 1] + rolls[i + 2];
                }
                else if(IsSpare(rolls, i))
                {
                    score += 10 + rolls[i + 2];
                    i++;
                }                 
                else
                {
                    score += rolls[i] + rolls[i + 1];
                    i++;
                }
                i++;
            }
            return score;
        }

        private bool IsStrike(IList<int> rolls, int i)
        {
            return rolls[i] == 10;
        }

        private bool IsSpare(IList<int> rolls, int i)
        {
            return rolls[i] + rolls[i + 1] == 10 && rolls[i] != 10;
        }
    }
}
