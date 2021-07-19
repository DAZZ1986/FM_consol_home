using System;
using System.Collections.Generic;
using System.Text;

namespace FM_consol
{
    class Calendar
    {
        //  1. добавить факторы влияющие на счет игры (чтобы слабые могли выигрывать у сильных в силу опред. причин)
        //  2. создать трансферные периоды в середине сезона, когда GamesCount = 5 и в конце
        //  сезона когда GamesCount = 10. 

        // метод матчей между клубами
        public void MatchMetod(List <Club> clubCalenTemp)
        {
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < clubCalenTemp.Count; i++)
            {
                for (int j = 0; j < clubCalenTemp.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    Console.WriteLine("Сегодня играет {0} vs {1}", clubCalenTemp[i].Name, clubCalenTemp[j].Name);
                    ClubPointCalc(clubCalenTemp[i], clubCalenTemp[j]);
                    Console.WriteLine("----------------------------------------------");
                    //Console.ReadKey();
                }
            }
        }

        // метод определение победителя в матче 
        public void ClubPointCalc(Club team1, Club team2)
        {
            if (team1.ClubPower > team2.ClubPower)
            {
                team1.ScorePoint += 3;
                Console.WriteLine("{0} победил {1} со счетом {2}", team1.Name, team2.Name, ScoreMethod(team1)); 
            }
            if (team1.ClubPower < team2.ClubPower)
            {
                team2.ScorePoint += 3;
                Console.WriteLine("{0} проиграл {1} со счетом {2}", team1.Name, team2.Name, ScoreMethod(team1));
            }
            if (team1.ClubPower == team2.ClubPower)
            {
                team1.ScorePoint += 1;
                team2.ScorePoint += 1;
                Console.WriteLine("{0} ничья {1} со счетом {2}", team1.Name, team2.Name, ScoreMethod(team1));
            }
        }
         
        public int ScoreMethod(Club t1) // из этого метода нужно векрнуть 2 параметра, либо ссылке либо через структурку 000 0111222 000
        {
            return t1.ClubPower / 100;
        }


    }
}
