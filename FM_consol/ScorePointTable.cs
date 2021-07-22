using System;
using System.Collections.Generic;
using System.Text;

namespace FM_consol
{
    class ScorePointTable
    {
        
        public void DrawTable(List <Club> RPLtable) 
        {
            Console.WriteLine("ID Нименование Очков");
            for (int i = 0; i < RPLtable.Count; i++)
            {
                Console.WriteLine("{0,-3} | {1,-10} | {2,-3}", i, RPLtable[i].Name, RPLtable[i].ScorePoint );
            }

        }
        



    }
}
