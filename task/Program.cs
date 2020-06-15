using System;
using System.Linq;
using System.Collections.Generic;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------welcoming part and set up the Upper limit 

            System.Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("------------------------------------------welcome let's play a bingo befor starting choose the upper limit ---------------------------------- ");
            System.Console.WriteLine("--------------------------------------------Mine limit is 20 to 999--------------------------------------------------------------------------");
            System.Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------");


            ////check if is a Numbre 
            int MaxNum = 0;

            for (int i = 0; i < 10; i++)
            {
                
                string s = Console.ReadLine();
                bool result = int.TryParse(s, out MaxNum);

                if (MaxNum > 20 && MaxNum < 1000 && (MaxNum % 1) == 0)
                {
                    System.Console.WriteLine("You limit for this game is " + MaxNum + " know is time to ");
                    
                    break;
                    
                }
                else if (i == 9)
                {
                    System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                    System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                    System.Console.WriteLine(" -------------------------------Last change and the game will close automaticly  ");
                    System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                    System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                }

                else
                {
                    System.Console.WriteLine("must be a numbre betteew 20 and 999");
                }

            }
            //the selection of the menu 
            Selection select = new Selection();
            select.Menu(MaxNum);

           
            


        }
    }
}