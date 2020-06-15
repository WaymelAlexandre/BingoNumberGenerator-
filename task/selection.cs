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



                        if (Myarray.Contains(TheNUMBRE))
                        {
                            while (Myarray.Contains(TheNUMBRE) != Myarray.Contains(TheNUMBRE)  )
                            {
                                TheNUMBRE = Drawing.Diplaynumbre(numbre);
                            }
                            
                        }
                        else
                        {
                            System.Console.WriteLine("--------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------");
                            System.Console.WriteLine(TheNUMBRE);
                            System.Console.WriteLine("--------------------------------------------");
                            System.Console.WriteLine("--------------------------------------------");
                        }
                        Myarray[TheNUMBRE] = TheNUMBRE;




                    }

                    else if (Pickmenu == 2)
                    {
                        for (int i = 0; i < Numbre; i++)
                        {
                            System.Console.WriteLine(Myarray[i]);
                        }
                    }
                    else if (Pickmenu == 3) { }
                    else if (Pickmenu == 4)
                    {
                        System.Console.WriteLine(" Thank you for play \n ");
                        break;
                    }
                    else

                    {
                        System.Console.WriteLine("you should pick the good numbre");

                    }






                }
                else
                {
                    System.Console.WriteLine("pls choose what you want a do by tapping \n 1 / 2 / 3 / 4 ");
                }
                for (int i = 0; i < Numbre; i++)
                {
                    System.Console.WriteLine(Myarray[i]);
                }




            }
        }

    }


}