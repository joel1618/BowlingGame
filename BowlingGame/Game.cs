using BowlingGame;
using System.Collections.Generic;

namespace BowlingGame
{
    public class Game
    {
        // initializes rolls array
        private List<int> rolls = new List<int>();

        Calculator calculator;
        public Game(Calculator calculator)
        {
            this.calculator = calculator;
        }
        /// <summary>
        /// Adds a roll
        /// </summary>
        /// <param name="pins"></param>
        /// <param name="roll"></param>
        public void Roll(int pins)
        {
            rolls.Add(pins);
        }

        /// <summary>
        /// Calculates the score for a game
        /// </summary>
        /// <returns>the score</returns>
        public int Score()
        {
            var score = calculator.GetScore(this.rolls);
            return score;
        }
    }
}
