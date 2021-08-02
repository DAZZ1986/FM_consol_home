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
        public void MatchMetod(List<Club> RPLclubs, Club my)
        {
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < RPLclubs.Count; i++)
            {
                for (int j = 0; j < RPLclubs.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    Console.WriteLine("Сегодня играет {0} vs {1}", RPLclubs[i].Name, RPLclubs[j].Name);
                    ClubPointCalc(RPLclubs[i], RPLclubs[j]);
                    RPLclubs[i].GamesCount++;
                    RPLclubs[j].GamesCount++;
                    Console.WriteLine("----------------------------------------------");
                    
                    Update dalee = new Update();
                    dalee.UpdateMethod(my); 
                }
            }
        }

        // начисление очков (победа, поражение, ничья) 
        public void ClubPointCalc(Club team1, Club team2)
        {
            if (team1.ClubPower > team2.ClubPower)
            {
                team1.ScorePoint += 3;
                Console.WriteLine("{0} победил {1} со счетом {2}", team1.Name, team2.Name, ScoreMethod(team1, team2));
            }
            if (team1.ClubPower < team2.ClubPower)
            {
                team2.ScorePoint += 3;
                Console.WriteLine("{0} проиграл {1} со счетом {2}", team1.Name, team2.Name, ScoreMethod(team1, team2));
            }
            if (team1.ClubPower == team2.ClubPower)
            {
                team1.ScorePoint += 1;
                team2.ScorePoint += 1;
                Console.WriteLine("{0} ничья {1} со счетом {2}", team1.Name, team2.Name, ScoreMethod(team1, team2));
            }
        }

        /* расчет счета в матче, учитываем:
            - сила игроков 1
            - форма команды
            - игра дома или на выезде
            - уровень тренера
        */
        public string ScoreMethod0(Club t1, Club t2) // тупо конверт в стринг 
        {
            int tt1 = t1.ClubPower / 100;
            int tt2 = t2.ClubPower / 100;
            string ab = Convert.ToString(tt1) + Convert.ToString(tt2);
            return ab;
        }
        public string ScoreMethod(Club t1, Club t2) // тупо конверт в стринг из массива 
        {
            int[] Src = new int[] { t1.ClubPower/100, t2.ClubPower/100 }; // тут баг тк счет 8 : 8
            string c = Src[0] + " : " + Src[1];
            return c;
        }
        public Object ScoreMethod1(Club t1, Club t2) // из этого метода нужно векрнуть 2 параметра - передал объекты
        {
            int[] Src = new int[] { t1.ClubPower, t2.ClubPower };
            return Src;
        }

        public int[] ScoreMethod2(Club t1, Club t2) // из этого метода нужно векрнуть 2 параметра - передал массив инт
        {
            int[] Src = new int[] { t1.ClubPower, t2.ClubPower };
            return Src;
        }

        public int[] ScoreMethod3(ref Club t1, ref Club t2) // из этого метода нужно векрнуть 2 параметра - передал по ссылке.
        {
            int[] Src = new int[] { t1.ClubPower, t2.ClubPower };
            return Src;
        }

    }

        


}
