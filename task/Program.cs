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
            //ok need to fix No lettre sur le choise du menu
            //frist choose if is it incorect mais ce second et bon is not working 
            System.Console.WriteLine("---------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("---------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("welcome let's play a bingo befor starting choose the upper limit  ");
            System.Console.WriteLine("                    Mine limit is 20 to 999");
            System.Console.WriteLine("---------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("---------------------------------------------------------------------------------------------------");
            string MaxNumbre = Console.ReadLine();
            int MaxNum = int.Parse(MaxNumbre);



            //fix the limit of  20 to 999
            if (MaxNum <= 20 || MaxNum > 1000)
            {

                System.Console.WriteLine("------------------------------------------------------------");
                System.Console.WriteLine("Have some limit ;) by the way mine is 999 and 20 drawns as minumun");
                System.Console.WriteLine("------------------------------------------------------------");
                for (int i = 0; i < 5; i++)
                {

                    MaxNumbre = Console.ReadLine();
                    MaxNum = int.Parse(MaxNumbre);

                    if (MaxNum! < 20 || MaxNum! > 1000)
                    {

                        System.Console.WriteLine("again");
                    }
                    else
                    {
                        System.Console.WriteLine("You limit for this game is " + MaxNum + " know is time to ");
                        break;
                    }

                }


            }
            //else if (check fir the lettre thing here )
            
            
            
                
            //the Numbre to use in array/list
            else if (MaxNum >= 21)
            {
                System.Console.WriteLine("You limit for this game is " + MaxNum + " know is time to ");

            }

            else
            {
                System.Console.WriteLine("--------------------------------------------------");
                System.Console.WriteLine("--------------------------------------------------");
                System.Console.WriteLine(" || You have 5 try after you will simply exit the game || ");
                System.Console.WriteLine("--------------------------------------------------");
                System.Console.WriteLine("--------------------------------------------------");
                for (int i = 0; i < 5; i++)
                {
                    System.Console.WriteLine("try again" + i++);
                    MaxNumbre = Console.ReadLine();
                }
            }


            //--------------------------------------Pick numbre form Menu()--------------------------------



            //----------------------------------if numbre one (random numbre)
            int MenuNumbre = Menu();
            for (int i = 0; i < MaxNum; i++)
            {


                //No duplicate numbers should be drawn need to work on it 

                if (MenuNumbre == 1)
                {

                    Random r = new Random();
                    int RandomNum = r.Next(0, MaxNum);
                    System.Console.WriteLine("--------------------------------------------------");
                    System.Console.WriteLine("--------------------------------------------------");
                    System.Console.WriteLine("the Drawn numbre is  " + RandomNum);
                    System.Console.WriteLine("--------------------------------------------------");
                    System.Console.WriteLine("--------------------------------------------------");


                }

                //----------------------------------if numbre 2 (Numbre list) not started

                else if (MenuNumbre == 2)
                {
                    System.Console.WriteLine("not finish");
                    break;
                }

                //----------------------------------if numbre3 prompted to enter numbers one by one to check if they have been drawn
                else if (MenuNumbre == 3)
                {
                    System.Console.WriteLine("not finish");
                    break;
                }
                //----------------------------------if num 4  exit game need to finish it 
                else if (MenuNumbre == 4)
                {
                    System.Console.WriteLine("thank you for play");
                    break;
                }
                else
                {
                    System.Console.WriteLine("tape a numbre in a menue ");


                }

                MenuNumbre = Menu();
            }
        }


        static int Menu()
        {
            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("make your choose");
            System.Console.WriteLine(" ");
            System.Console.WriteLine(" 1 Drawn the next number  ");
            System.Console.WriteLine(" 2 view all drawn number ");
            System.Console.WriteLine(" 3 Check specific number ");
            System.Console.WriteLine(" 4 Exit");
            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");

            int Numbrechoos = int.Parse(Console.ReadLine());

            return Numbrechoos;


        }
        static void checkBe()
        {


        }



    }
}


















/*

            Menu();
            string Dontcare = Console.ReadLine();
            int PickMenu = int.Parse(Dontcare);

            switch (PickMenu)
            {
                case 1:
                    if (PickMenu == 1)
                    {
                        Random r = new Random();
                        int RandomNum = r.Next(0, MaxNumbre);
                        System.Console.WriteLine(RandomNum);                        
                    }                    
                break;

                case 2:
                  
                default:
                    
                    System.Console.WriteLine("You mush Choose between the option");
                    break;
            }*/
