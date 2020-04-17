using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2___RPOON_zadaci
{

    //1. ZADATAK
    /*
    class Die
    {
        private int numberOfSides;
        private Random randomGenerator;
        private int rolledNumber;

        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = new Random();
        }
        public int Roll()
        {
            rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }
    }*/




    //2. ZADATAK
    /*
    class Die
    {
        private int numberOfSides;
        private Random randomGenerator;
        private int rolledNumber;

        public Die(int numberOfSides, Random randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomGenerator; 
        }
        public int Roll()
        {
            rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }
    }*/



    //3. ZADATAK
    /*
    class Die
    {
        private int numberOfSides;
        private RandomGenerator randomGenerator;
        private int rolledNumber;

        public Die(int numberOfSides, RandomGenerator randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomGenerator;
        }
        public int Roll()
        {
            rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
    }*/




    //4.,5. ZADATAK
    /*
    class Die
    {
        private int numberOfSides;
        private RandomGenerator randomGenerator;
        private int rolledNumber;

        public Die(int numberOfSides, RandomGenerator randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomGenerator;
        }
        public int Roll()
        {
            rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
    */
    //6. zadatak

    class Die
    {
        private int numberOfSides;
        private RandomGenerator randomGenerator;
        private int rolledNumber;

        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator.GetInstance();
        }
        public int Roll()
        {
            rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
    }


}
