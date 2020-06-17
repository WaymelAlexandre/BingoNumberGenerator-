using System;
using System.Linq;
using System.Collections.Generic;


namespace task
{

    public class Selection
    {
        public int numbre;


        static void display(string MYTEXT)
        {

            System.Console.WriteLine("--------------------------------------------------------------------------------------");
            System.Console.WriteLine("   --------------------------------------------------------------------------------   ");
            System.Console.WriteLine("                        " + MYTEXT);
            System.Console.WriteLine("   --------------------------------------------------------------------------------   ");
            System.Console.WriteLine("--------------------------------------------------------------------------------------");


        }

        public void Menu(int Numbre)
        {
            this.numbre = Numbre;
            int[] Myarray = new int[Numbre];
            List<int> intList = new List<int>();

            while (true)
            {
                System.Console.WriteLine(" ");
                System.Console.WriteLine(" ");
                System.Console.WriteLine(" 1 Drawn the next number  ");
                System.Console.WriteLine(" 2 view all drawn number ");
                System.Console.WriteLine(" 3 Check specific number ");
                System.Console.WriteLine(" 4 Exit");
                System.Console.WriteLine(" ");
                System.Console.WriteLine(" ");

                int Pickmenu = 0;
                string PiMenu = System.Console.ReadLine();
                bool result = int.TryParse(PiMenu, out Pickmenu);
                DrawnNum Drawing = new DrawnNum(numbre);
                int TheNUMBRE = Drawing.Diplaynumbre(numbre);

                if ((Pickmenu % 1) == 0 && Pickmenu > 0)
                {
                    if (Pickmenu == 1)
                    {
                        for (int i = 0; i < Numbre; i++)
                        {
                            if (!Myarray.Contains(TheNUMBRE))
                            {


                                display(" The Numbre is " + TheNUMBRE);
                                Myarray[TheNUMBRE] = TheNUMBRE;
                                intList.Add(TheNUMBRE);
                                break;

                            }
                            else if (Myarray.Contains(TheNUMBRE))
                            {
                                if (i == (Numbre - 5))
                                {
                                    display(" No more numbre \n the game should be finish for long time no give me a breack XD  ");

                                    break;
                                }

                                TheNUMBRE = Drawing.Diplaynumbre(numbre);

                            }
                        }
                    }
                    else if (Pickmenu == 2)
                    {

                        display("\nTape 1 to see the numbre by order of drawning. \nTape 2 to see the numbre print all numbers in numerical order.\nTape 3 for back to the main menu\n");

                        Pickmenu = 0;
                        PiMenu = System.Console.ReadLine();
                        result = int.TryParse(PiMenu, out Pickmenu);

                        if (Pickmenu == 1)
                        {
                            display("this is the list by drawning");
                            for (int i = 0; i < intList.Count; i++)
                            {
                                Console.WriteLine(intList[i]);
                            }                            
                        }
                        else if (Pickmenu == 2)
                        {
                            display("This is the list by numerical order  ");

                            for (int i = 0; i < Myarray.Length; i++)
                            {
                                if (Myarray[i] != 0)
                                {
                                    System.Console.WriteLine(Myarray[i]);
                                }
                            }
                        }
                        else if (Pickmenu == 3)
                        {
                            display("ok let's back to the menu");
                        }
                        else
                        {
                            display("pls choose what you want by entre 1/2/3 ");
                        }
                    }
                    else if (Pickmenu == 3)
                    {
                        display("Pleas entree the numbre you want a check ");
                        int checkNUM = 0;
                        string blabla = System.Console.ReadLine();
                        bool result2 = int.TryParse(blabla, out checkNUM);

                        if (intList.Contains(checkNUM))
                        {
                            display(" The numbre " + checkNUM + " is been already drawn ");
                        }
                        else if (checkNUM > Numbre || checkNUM < 0)
                        {
                            display("This not part of the drawning, your limit was " + Numbre);
                        }
                        else if (checkNUM == 0)
                        {
                            display("Look like you use some lettre ");
                        }
                        else
                        {
                            display("This numbre  '" + checkNUM + "' it is still NOT been drawn");
                        }

                    }
                    else if (Pickmenu == 4)
                    {
                        display(" Thank you for play with me see you soon");
                        break;
                    }
                    else
                    {
                        display("you should pick the good numbre");
                    }
                }
                else
                {
                    display("pls choose what you want a do by tapping \n 1 for drwing numbre / 2 for list all the numbre be drawn / 3 check your numbre / 4 exit the game  ");
                }
            }
        }
    }
}