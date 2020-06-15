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

                int Pickmenu =0;
                string PiMenu = System.Console.ReadLine();
                bool result = int.TryParse(PiMenu, out Pickmenu);

                if ((Pickmenu % 1) == 0 && Pickmenu > 0)
                {


                    if (Pickmenu == 1){
                        
                        DrawnNum Drawing = new DrawnNum(numbre);
                        int TheNUMBRE = Drawing.Diplaynumbre(numbre);
                        System.Console.WriteLine("--------------------------------------------");
                        System.Console.WriteLine("--------------------------------------------");
                        System.Console.WriteLine(TheNUMBRE);
                        System.Console.WriteLine("--------------------------------------------");
                        System.Console.WriteLine("--------------------------------------------");
                        
                        
                      
                    }
                    else if (Pickmenu == 2){

                        

                        

                    }
                    else if (Pickmenu == 3){}
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
                else{
                    System.Console.WriteLine("pls choose what you want a do by tapping \n 1 / 2 / 3 / 4 ");
                }

            }
        }

    }


}