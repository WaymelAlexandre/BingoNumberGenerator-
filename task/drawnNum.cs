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

        public int Diplaynumbre(int Nombre){
            Random r = new Random();
            int RandomNum = r.Next(1, Nombre);

            return RandomNum;
        }
        
    }
}

