using System;
using System.Linq;
using System.Collections.Generic;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //basic menu
            //starting game by asking the limmit

            System.Console.WriteLine("How mush is yours upper limit of numbers to be drawn ");
            System.Console.WriteLine(" ");
            string blabla = Console.ReadLine();
            int LimitC = int.Parse(blabla);
            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");
            int test = welcome();



            if (test == 1)
            {
                Random r = new Random();
                int RandomNum = r.Next(0, LimitC);
                System.Console.WriteLine(RandomNum);

            }
            else if (test == 2)
            {
                System.Console.WriteLine(" drawen list ");
            }
            else if (test == 3)
            {
                System.Console.WriteLine(" check num ");
            }
            else if (test == 4)
            {
                System.Console.WriteLine(" exit ");
            }
            else if (test != 1 || 2 || 3 || 4)
            {
                System.Console.WriteLine("pls entre one a the following choose");
                welcome();
            }





        }



            static int welcome()
            {

            // player choose what he whant a do 
            System.Console.WriteLine("Welcom to the bingo club of swinburne");
            System.Console.WriteLine(" 1 Drawn the next number  ");
            System.Console.WriteLine(" 2 view all drawn number ");
            System.Console.WriteLine(" 3 Check specific number ");
            System.Console.WriteLine(" 4 Exit");
            // choose inpute for the menu 

            string TheInputPlayer = Console.ReadLine();
            int ChooseNum = int.Parse(TheInputPlayer);
            ChooseNum = Convert.ToInt32(TheInputPlayer);
            return ChooseNum;



            */






















































            //start the game et gice the limit value 
            System.Console.WriteLine("welcome let's play a bingo befor starting choose the limit of the numbre ");
            string blabla = Console.ReadLine();
            int MaxNumbre = int.Parse(blabla);

            //Array of all Numbre
            int[] ArrayNUM = new int[MaxNumbre];
            for (int i = 1; i < ArrayNUM.Length; i++)
            {
                ArrayNUM[i] = i;
            }

            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("ok les's start make your choose");
            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");
            System.Console.WriteLine(" 1 Drawn the next number  ");
            System.Console.WriteLine(" 2 view all drawn number ");
            System.Console.WriteLine(" 3 Check specific number ");
            System.Console.WriteLine(" 4 Exit");

            //Select menu and selector 

            string Dontcare = Console.ReadLine();
            int PickMenu = int.Parse(Dontcare);
            if (PickMenu == 1)
            {
                Random r = new Random();
                int RandomNum = r.Next(0, MaxNumbre);
                //change the random num in array by zero  and fine le possition of the array to print the numbre again  
                ArrayNUM[RandomNum] = 0;
                
                
                System.Console.WriteLine(" ");
                System.Console.WriteLine("------------------------------------------- ");
                System.Console.WriteLine("le numbre IS  || " + RandomNum + " ||");
                System.Console.WriteLine("------------------------------------------- ");
                System.Console.WriteLine(" ");
                System.Console.WriteLine("what know ????");
                

            }
            
           
            
           






        }
        static void Menu()
        {
            System.Console.WriteLine(" 1 Drawn the next number  ");
            System.Console.WriteLine(" 2 view all drawn number ");
            System.Console.WriteLine(" 3 Check specific number ");
            System.Console.WriteLine(" 4 Exit");

            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");


        }
    }
}
