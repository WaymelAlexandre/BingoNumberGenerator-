using System;
using System.Linq;
using System.Collections.Generic;


namespace task
{

    public class Selection
    {
        public int numbre;

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
                                System.Console.WriteLine("--------------------------------------------------------------------------------------");
                                System.Console.WriteLine("--------------------------------------------------------------------------------------");
                                System.Console.WriteLine(TheNUMBRE);
                                System.Console.WriteLine("--------------------------------------------------------------------------------------");
                                System.Console.WriteLine("--------------------------------------------------------------------------------------");
                                Myarray[TheNUMBRE] = TheNUMBRE;
                                intList.Add(TheNUMBRE);
                                break;

                            }


                            else if (Myarray.Contains(TheNUMBRE))

                            {
                                if (i == (Numbre - 5))
                                {
                                    System.Console.WriteLine("--------------------------------------------------------------------------------------");
                                    System.Console.WriteLine("--------------------------------------------------------------------------------------");
                                    System.Console.WriteLine("No more numbre \n the game should be finish for long time no give me a breack XD ");
                                    System.Console.WriteLine("--------------------------------------------------------------------------------------");
                                    System.Console.WriteLine("--------------------------------------------------------------------------------------");
                                    break;
                                }

                                TheNUMBRE = Drawing.Diplaynumbre(numbre);

                            }



                        }

                    }



                    else if (Pickmenu == 2)
                    {
                        System.Console.WriteLine("--------------------------------------------------------------------------------------");
                        System.Console.WriteLine("--------------------------------------------------------------------------------------");
                        System.Console.WriteLine("Tape 1 to see the numbre by order of drawning. \nTape 2 to see the numbre print all numbers in numerical order.\n 3 for back to the menu");
                        System.Console.WriteLine("--------------------------------------------------------------------------------------");
                        System.Console.WriteLine("--------------------------------------------------------------------------------------");

                        Pickmenu = 0;
                        PiMenu = System.Console.ReadLine();
                        result = int.TryParse(PiMenu, out Pickmenu);



                        if (Pickmenu == 1)
                        {
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("this is the list by drawning");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");


                            for (int i = 0; i < intList.Count; i++)
                            {
                                Console.WriteLine(intList[i]);
                            }
                        }
                        else if (Pickmenu == 2)
                        {
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("This is the list by numerical order  ");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");

                            // intList.Sort();
                            // for (int i = 0; i < intList.Count ; i++)
                            // {
                            //     System.Console.WriteLine(intList[i]);

                            // }

                            for (int i = 0; i < Myarray.Length; i++)
                            {
                                if (Myarray[i] != 0)
                                {
                                    System.Console.WriteLine(Myarray[i]);
                                }
                            }
                            //}
                        }
                        else if (Pickmenu == 3)
                        {
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine(" ok let's back to the menu");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                        }
                        else
                        {
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("pls choose what you want a do by ");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                        }

                        // for (int i = 0; i < Numbre; i++)
                        // {
                        //     System.Console.WriteLine(Myarray[i]);
                        // }
                    }

                    else if (Pickmenu == 3)
                    {
                        System.Console.WriteLine("Please writ the numbre you want a check");
                        int checkNUM = 0;
                        string blabla = System.Console.ReadLine();
                        bool result2 = int.TryParse(blabla, out checkNUM);

                        if (intList.Contains(checkNUM))
                        {
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("The numbre '" + checkNUM + "' is been already drawn");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            
                        }
                        else
                        {
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("This numbre  '" + checkNUM + "' it is still NOT been drawn ");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------------------------------------------------");
                            
                        }

                    }
                    else if (Pickmenu == 4)
                    {
                        System.Console.WriteLine("--------------------------------------------------------------------------------------");
                        System.Console.WriteLine("--------------------------------------------------------------------------------------");
                        System.Console.WriteLine(" Thank you for play \n ");
                        System.Console.WriteLine("--------------------------------------------------------------------------------------");
                        System.Console.WriteLine("--------------------------------------------------------------------------------------");
                        break;
                    }
                    else

                    {
                        System.Console.WriteLine("you should pick the good numbre");

                    }

                }
                else
                {
                    System.Console.WriteLine("pls choose what you want a do by tapping \n 1 for drwing numbre / 2 for list all the numbre be drawn / 3 check your numbre / 4 exit the game  ");
                }
            }
        }
    }
}