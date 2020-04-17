﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2___RPOON_zadaci
{
    class ClosedDiceRoller : IDiceRoller, IDiceRoller2
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public ClosedDiceRoller(int diceCount, int numberOfSides)
        {
            this.dice = new List<Die>();
            for (int i = 0; i < diceCount; i++)
            {
                this.dice.Add(new Die(numberOfSides));
            }
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            throw new NotImplementedException();
        }
        public void RemoveAllDice()
        {
            throw new NotImplementedException();
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
    }
}
