using System;

namespace GameOfLife
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amountToStartWith"></param>
        /// <param name="gamefield"></param>
        public static void FillFirstGamefield(int amountToStartWith, ref bool[,] gamefield)
        {
            Random rand = new Random();
            do
            {
                int x = rand.Next(0, gamefield.GetLength(0) - 1);
                int y = rand.Next(0, gamefield.GetLength(1) - 1);
                if (gamefield[x, y]==false)
                {
                    gamefield[x, y] = true;
                    amountToStartWith--;
                }
            } while (amountToStartWith != 0);     
            
            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="gamefield"></param>
        public static void DrawGamefield(ref bool[,] gamefield)
        {
            for (int i = 0; i < gamefield.GetLength(0); i++)
            {
                for (int j = 0; j < gamefield.GetLength(1); j++)
                {
                    if(gamefield[i, j])
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }  
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="gamefield"></param>
        public static void CalculateNewGamefield(ref bool[,] gamefield)
        {

        }




        static void Main(string[] args)
        {
            int userInput = 0, counter = 0;
            
            do
            { 
                Console.Write("Wie viele Zellen belegen(max. 1580):");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput < 0)
                {
                    Console.WriteLine("Bitte nur positive Ganzzahlen eingeben!");
                }
            } while (userInput<0);

            bool[,] gamefield = new bool[20, 79];
            FillFirstGamefield(userInput, ref gamefield);
            DrawGamefield(ref gamefield);
            int livingCells = userInput;
            
            do
            {
                System.Threading.Thread.Sleep(500);
                counter++;
                Console.Clear();

                DrawGamefield(ref gamefield);
                
            } while (livingCells > 0);

            Console.WriteLine("Runden bis letzte Zelle gestorben ist: {0}",counter);



            

            
            
        }
    }
}
