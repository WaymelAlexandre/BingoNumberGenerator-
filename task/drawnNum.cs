using System;
using System.Linq;
using System.Collections.Generic;

namespace task
{

    class DrawnNum
    {
        public int nombre;

        public DrawnNum(int Nombre)
        {
            this.nombre = Nombre;
        }

        public int Diplaynumbre(int Nombre)
        {
            Random r = new Random();
            int RandomNum= 0;
            
            for (int i = 0; i < Nombre; i++)
            {
                
                RandomNum = r.Next(1, Nombre);
            }
            

            return RandomNum;
        }


        /*Random rnd = new Random(); // <-- This line goes out of the loop        
for (int i = 0; i < 20; i++) {
    int temp = 0;
    temp = rnd.Next(0, 9);
    page[i] = temp;
}*/

    }
}

