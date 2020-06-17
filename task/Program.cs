using System;
using System.Linq;
using System.Collections.Generic;

namespace task
{
    class Program
    {

        static void display(string MYTEXT)
        {

            System.Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            System.Console.WriteLine("   --------------------------------------------------------------------------------   ");
            System.Console.WriteLine("                        " + MYTEXT);
            System.Console.WriteLine("   --------------------------------------------------------------------------------   ");
            System.Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");


        }
        static void Main(string[] args)
        {
            //--------------------------------------welcoming part and set up the Upper limit    

            display("welcome let's play a bingo befor starting choose the upper limit \n                         Mine limit is 20 to 999");

            ////check if is a Numbre 
            int MaxNum = 0;

            for (int i = 0; i < 10; i++)
            {
                
                string s = Console.ReadLine();
                bool result = int.TryParse(s, out MaxNum);
                
                // limite the selection for 20 to 999 with no decimal 
                if (MaxNum > 19 && MaxNum < 1000 && (MaxNum % 1) == 0)
                {
                    display("You limit for this game is " + MaxNum + " know is time to ");
                    
                    break;
                    
                }
                //last chance after exite the game 
                else if (i == 9)
                {
                    
                    display("Last change and the game will close automaticly  ");
                    
                }
                // message error if wrong numbre lettre or decimal 
                else
                {
                    display("must be a numbre betteew 20 and 999");
                }
            }
            //the selection class of the menu 
            Selection select = new Selection();
            select.Menu(MaxNum);
        }
    }
}