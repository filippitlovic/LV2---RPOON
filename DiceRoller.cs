using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2___RPOON_zadaci
{
    /// 1. ZADATAK
    /*
     class DiceRoller
     {
         private List<Die> dice;
         private List<int> resultForEachRoll;

         public DiceRoller()
         {
             this.dice = new List<Die>();
             this.resultForEachRoll = new List<int>();
         }
         public void InsertDie(Die die)
         {
             dice.Add(die);
         }
         public void RollAllDice()
         {
             //brisanje prošlih rez
             this.resultForEachRoll.Clear();
             foreach (Die die in dice)
             {
                 this.resultForEachRoll.Add(die.Roll());
             }
         }

         public void print()
         {
             foreach(int broj in resultForEachRoll)
             {
                 Console.WriteLine(broj.ToString());
             }
         }

         public IList<int> GetRollingResults()
         {
             return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
             this.resultForEachRoll
             );
         }
         public int DiceCount
         {
             get { return dice.Count; }
         }
     }
 }*/




    /// 2. ZADATAK
    /*
    class DiceRoller
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            //brisanje prošlih rez
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

        public void print()
        {
            foreach (int broj in resultForEachRoll)
            {
                Console.WriteLine(broj.ToString());
            }
        }

        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
            this.resultForEachRoll
            );
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }
    }*/





    //3. ZADATAK
    /*
    class DiceRoller
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            //brisanje prošlih rez
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

        public void print()
        {
            foreach (int broj in resultForEachRoll)
            {
                Console.WriteLine(broj.ToString());
            }
        }

        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
            this.resultForEachRoll
            );
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }
    }*/




    //4. ZADATAK
    /*
    class DiceRoller
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        private ILogger logger;
        

        public DiceRoller(ILogger logger)
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            this.logger = logger;
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            //brisanje prošlih rez
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

        public void LogRollingResults()
        {
            foreach (int result in this.resultForEachRoll)
            {
                logger.Log(result.ToString());
            }
        }

        public void print()
        {
            foreach (int broj in resultForEachRoll)
            {
                Console.WriteLine(broj.ToString());
            }
        }

        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
            this.resultForEachRoll
            );
        }
        public int DiceCount
        {
            get { return dice.Count; }
        }
    }
    */

    //5. ZADATAK
    /*
    class DiceRoller : ILoggable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        private ILogger logger;


        public DiceRoller(ILogger logger)
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            this.logger = logger;
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            //brisanje prošlih rez
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

       

        public void print()
        {
            foreach (int broj in resultForEachRoll)
            {
                Console.WriteLine(broj.ToString());
            }
        }

        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
            this.resultForEachRoll
            );
        }

        public string GetStringRepresentation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(int broj in this.resultForEachRoll)
            {
                stringBuilder.Append(broj + " , ");
            }
            return stringBuilder.ToString();
        }

        public int DiceCount
        {
            get { return dice.Count; }
        }
    }*/

    //6. ZADATAK


    class DiceRoller : ILoggable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        private ILogger logger;


        public DiceRoller(ILogger logger)
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            this.logger = logger;
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            //brisanje prošlih rez
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }



        public void print()
        {
            foreach (int broj in resultForEachRoll)
            {
                Console.WriteLine(broj.ToString());
            }
        }

        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(
            this.resultForEachRoll
            );
        }

        public string GetStringRepresentation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (int broj in this.resultForEachRoll)
            {
                stringBuilder.Append(broj + " , ");
            }
            return stringBuilder.ToString();
        }

        public int DiceCount
        {
            get { return dice.Count; }
        }
    }
}
