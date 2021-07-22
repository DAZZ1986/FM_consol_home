using System;
using System.Collections.Generic;
using System.Text;

namespace FM_consol
{
    public class Club
    {
        string name;
        public string Name { get; set; }

        int balanse;
        public int Balanse { get; set; }

        int clubPower;
        public int ClubPower { get; set; }  // сила клуба на основе силы игроков

        byte scorePoint;
        public byte ScorePoint { get; set; } // сколько команда набрала очков в конце сезона

        byte gamesCount;
        public byte GamesCount { get; set; }

        public List<Player> team;



        public Club()
        {
            //Club myClub = rotor;
            team = new List<Player>();

        }




        // составы команд
        public void ShowPlayerList()
        {
            Console.WriteLine("----------------");
            Console.WriteLine(Name);
            foreach (Player item in team)
            {
                Console.WriteLine(item.LastName);
            }
            Console.WriteLine("----------------");
        }

        // баланс клуба
        public void ClubBalans(Club obj)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Баланс клуба {0} = {1}", obj.Name, obj.Balanse);
            Console.WriteLine("----------------");
        }

        // сила игроков клубов РПЛ
        public int ClubPowerCounter(List <Player> team)
        {
            foreach (Player item in team)
            {
                ClubPower += item.SkillPoint;
            }
            return ClubPower;
        }





    }
}
