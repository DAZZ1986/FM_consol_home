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
            Console.WriteLine("4 - кол-во очков в таблице РПЛ");
            Console.WriteLine("5 - матчей сыграно и осталось");
            Console.WriteLine("6 - провести трансферы");
            Console.WriteLine("7 - Далее");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    obj.ClubBalans(obj);
                    break;

                case 2:
                    Console.WriteLine("Состав вашего клуба ");
                    obj.ShowMyPlayerList();
                    break;

                case 3:
                    int c = obj.ClubPower;
                    Console.WriteLine("Сила игроков вашего клуба {0} = {1}", obj.Name, c); 
                    break;

                case 4:
                    byte a = obj.ScorePoint;
                    Console.WriteLine("Ваша команда {0} набрала {1} очков в РПЛ.", obj.Name, a);
                    break;

                case 5:
                    byte b = obj.GamesCount;
                    Console.WriteLine("Ваша команда {0} сыграла {1} матчей в РПЛ.", obj.Name, b);
                    break;

                case 6:
                    Console.WriteLine("Трансферы");
                    int d = obj.Balanse;
                    Console.WriteLine("Баланс вашего клуба {0} = {1}", obj.Name, d);
                    Console.WriteLine("Все игроки РПЛ:");
                    obj.ShowAllPlayerList(); // показываем List со всеми игроками RPLPlayerLocal
                    Console.WriteLine("Введите фамилию игрока которого хотите купить: (10 попыток)");

                    // 1.обраб. искл., 2.поиск по фамилии, 3.трансфер
                    string buyName = " ";
                    Transfer tempTransfer = new Transfer();
                    List<Player> AllPlayerListtemp = new List<Player>();
                    AllPlayerListtemp = obj.AllPlayerList();
                    // 1.обраб. искл.
                    bool outflag = false;
                    for (int i = 0; i < 10;)
                    {
                        try
                        {
                            buyName = Console.ReadLine();
                            for (int j = 0; j <= AllPlayerListtemp.Count;)
                            {
                                if (j == AllPlayerListtemp.Count)
                                {
                                    throw new Exception();
                                }
                                foreach (Player item in AllPlayerListtemp)
                                {
                                    if (buyName != item.LastName)
                                    {

                                    }
                                    else
                                    {
                                        outflag = true;
                                        break;
                                    }
                                    j++;
                                }
                                if (outflag)
                                {
                                    break;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Данного игрока не существует! Повторите попытку: ");
                            i++;
                        }
                        if (outflag)
                        {
                            break;
                        }
                    }

                    // 2.поиск по фамилии, 3.трансфер
                    foreach (Player item in AllPlayerListtemp)
                    {
                        if (item.NameClub != null)
                        {
                            if (buyName == item.LastName)
                            {
                                tempTransfer.Transf(item, obj, item.NameClub);
                                break;
                            }
                        }
                        else
                        {
                            if (buyName == item.LastName)
                            {
                                tempTransfer.Transf(item, obj);
                                break;
                            }
                        }

                    }
                    break;

                case 7:
                    Console.WriteLine("Далее ...");
                    break;

                default:
                    Console.WriteLine("Выбрали неверное число.");
                    break;
            }

        }

    }







}
