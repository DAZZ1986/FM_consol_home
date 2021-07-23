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

        public static List<Player> RPLPlayerLocal = new List<Player>(); // создал доп массив с игроками в методе



        public Club()
        {
            team = new List<Player>();
        }


        // return RPLPlayerLocal
        public List<Player> AllPlayerList()
        {
            return RPLPlayerLocal;
        }

        // Set dop List со всеми игроками РПЛ
        public void SetAllPlayerList(List<Player> all)
        {
            foreach (Player item in all) // заполнил доп массив
            {
                RPLPlayerLocal.Add(item);
            }
        }

        // Show List со всеми игроками РПЛ
        public void ShowAllPlayerList()
        {
            Console.WriteLine("{0,-13} | {1,-5} | {2,-4}", "Имя", "Скилл", "Цена");
            foreach (Player item in RPLPlayerLocal) // вывод доп массива
            {
                Console.WriteLine("{0,-13} | {1,-5} | {2,-4}", item.LastName, item.SkillPoint, item.Price);
            }
            Console.WriteLine("-----------------------------------");
        }

        // состав вашей команды
        public void ShowMyPlayerList()
        {
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
