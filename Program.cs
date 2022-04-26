using System;

namespace diceGameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable to get a random number
            int playerRandomNum;
            int enemyRandomNum;
            int playerPoints = 0;
            int enemyPoints = 0;

            // random number object
            Random random = new Random();

            // intro message
            Console.WriteLine("Welcome to my die game!");

            // for loop to roll the dice
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice ");

                Console.ReadKey();

                playerRandomNum = random.Next(1,7); // highest number generated will be 6
                Console.WriteLine(" You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000); // makes thread wait for a 1000 milliseconds(1 sec) before displaying enemy
                // number
                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player won!");
                }
                else if(enemyRandomNum > playerRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy won...sad face");
                }
                else
                {
                    Console.WriteLine("Tie");
                }
                Console.WriteLine("The score is now..player:  " + playerPoints + " Enemy: " + enemyPoints);
                Console.WriteLine();
                
            }//end forloop

            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("Player wins!");
            }
            else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("Player loses");
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadKey();
           

        }// end Main method
    }// end class Program
}//end namespace
