using System;
using System.Collections.Generic;
using System.Text;

namespace FM_consol
{
    class ScorePointTable
    {
        
        public void DrawTable(List <Club> RPLtable) 
        {
            Console.WriteLine("{0,-3} | {1,-11} | {2,-3}", "№", "Нименование", "Очков");
            for (int i = 0; i < RPLtable.Count; i++)
            {
                Console.WriteLine("{0,-3} | {1,-11} | {2,-3}", i, RPLtable[i].Name, RPLtable[i].ScorePoint );
            }

        }
        



    }
}
