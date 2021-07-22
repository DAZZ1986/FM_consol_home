using System;
using System.Collections.Generic;
using System.Text;

namespace FM_consol
{
    class Update
    {


        public void UpdateMethod(Club obj) 
        {
            Console.WriteLine("Введите номер пункта меню:");
            Console.WriteLine("1 - баланс клуба");
            Console.WriteLine("2 - состав клуба");
            Console.WriteLine("3 - сила игроков клуба");
            Console.WriteLine("4 - места в таблице РПЛ");
            Console.WriteLine("5 - матчей сыграно и осталось");
            Console.WriteLine("6 - провести трансферы");
            Console.WriteLine("7 - Далее");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Баланс вашего клуба = ");
                    obj.ClubBalans(obj);
                    break;

                case 2:
                    Console.Write("Состав вашего клуба = ");
                    obj.ShowPlayerList();
                    break;

                case 3:
                    Console.Write("Сила игроков вашего клуба = ");
                    obj.ClubPowerCounter(obj.team);
                    break;

                case 4:
                    byte a = obj.ScorePoint;
                    Console.Write("Ваша команда {0} набрала {1} очков в РПЛ.", obj.Name, a);
                    break;

                case 5:
                    Console.Write("матчей сыграно и осталось = ");
                    break;

                case 6:
                    Console.Write("провести трансферы ");
                    break;

                case 7:
                    Console.Write("Далее ...");
                    break;

                default:
                    Console.WriteLine("Выбрали неверное число.");
                    break;
            }

        }

    }







}
