using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2___RPOON_zadaci
{
    /// 1. ZADATAK
    /*
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceroller = new DiceRoller();
            for(int i=0; i < 20; i++)
            {
                diceroller.InsertDie(new Die(6));
            }

            diceroller.RollAllDice();
            diceroller.print();
            
        }
    }*/





    // 2. ZADATAK
    /*
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceroller = new DiceRoller();
            Random randomGenerator = new Random();

            for (int i = 0; i < 20; i++)
            {
                diceroller.InsertDie(new Die(6,randomGenerator));
            }

            diceroller.RollAllDice();
            diceroller.print();

        }
    }*/





    //3. ZADATAK
    /*
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceroller = new DiceRoller();
            RandomGenerator randomGen = RandomGenerator.GetInstance(); /// jedna instanca

            for (int i = 0; i < 20; i++)
            {
                diceroller.InsertDie(new Die(6, randomGen));
            }

            diceroller.RollAllDice();
            diceroller.print();

        }
    }*/





    //4. ZADATAK
    /*
    class Program
    {
        static void Main(string[] args)
        {
            
            
            RandomGenerator randomGen = RandomGenerator.GetInstance(); 
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger("poruka");

            DiceRoller diceroller = new DiceRoller(fileLogger);

            for (int i = 0; i < 20; i++)
            {
                diceroller.InsertDie(new Die(6, randomGen));
            }

            diceroller.RollAllDice();
            

            foreach( int broj in diceroller.GetRollingResults())
            {
                consoleLogger.Log(broj.ToString());
            }

            /// ili za upis u datoteku
            
            foreach(int broj in diceroller.GetRollingResults())
            {
                fileLogger.Log(broj.ToString());
            }
         }

       }*/






    // 5. ZADATAK
    /*
    

    class Program
    {
    static void Main(string[] args)
    {


        RandomGenerator randomGen = RandomGenerator.GetInstance();
        ConsoleLogger consoleLogger = new ConsoleLogger();
        FileLogger fileLogger = new FileLogger("poruka");

        DiceRoller diceroller = new DiceRoller(fileLogger);

        for (int i = 0; i < 20; i++)
        {
            diceroller.InsertDie(new Die(6, randomGen));
        }

        diceroller.RollAllDice();

        consoleLogger.Log(diceroller);






    }
}
*/

    
            






}

