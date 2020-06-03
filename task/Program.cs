using System;
using System.Linq;
using System.Collections.Generic;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic menu
            //starting game by asking the limmit

            System.Console.WriteLine("How mush is yours upper limit of numbers to be drawn ");
            System.Console.WriteLine(" ");
            string blabla = Console.ReadLine();
            int LimitC = int.Parse(blabla);

            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");

            // player choose what he whant a do 

            System.Console.WriteLine("Welcom to the bingo club of swinburne");
            System.Console.WriteLine(" 1 Drawn the next number  ");
            System.Console.WriteLine(" 2 view all drawn number ");
            System.Console.WriteLine(" 3 Check specific number ");
            System.Console.WriteLine(" 4 Exit");
            string TheInputPlayer = Console.ReadLine();
            int ChooseNum = int.Parse(TheInputPlayer);

            ChooseNum = Convert.ToInt32(TheInputPlayer);
            System.Console.WriteLine();
            System.Console.WriteLine();


            ///start  to work  

            //need to have a the limit ok the total number can be drawn

            //all number stock in list<> 
            List<int> listnum = new List<int>();

            for (int i = 0; i <= LimitC; i++)
            {
                listnum.Add(i);
            }

            //find solotion how to check if it is a numbre only
            /*
            if (LimitC.GetType() != typeof(int))
                {
                    System.Console.WriteLine("thats is not a num");
                }
            */
            if (ChooseNum == 1)
            {
                Random r = new Random();
                int RandomNum = r.Next(0, LimitC);

                System.Console.WriteLine(RandomNum);
            }
            else if (ChooseNum == 2)
            {
                System.Console.WriteLine(" drawen list ");
            }
            else if (ChooseNum == 3)
            {
                System.Console.WriteLine(" check num ");
            }
            else if (ChooseNum == 4)
            {
                System.Console.WriteLine(" exit ");
            }
            




        }
    }

}
