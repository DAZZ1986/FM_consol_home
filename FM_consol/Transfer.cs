using System;
using System.Collections.Generic;
using System.Text;

namespace FM_consol
{
    class Transfer
    {
        // transfer свободного агента
        public void Transf(Player obj, Club clubBuy)
        {
            Console.WriteLine("----------------");
            foreach (Player item in clubBuy.team) // проверка чтобы не добавить одного и того же игрока 2 раза.
            {
                if (obj.LastName == item.LastName)
                {
                    Console.WriteLine("{0} {1} уже состоит в клубе!", obj.Name, obj.LastName);
                    return;
                }
            }
            clubBuy.team.Add(obj);
            Console.WriteLine("{0} купил {1} {2} за {3}$ как свободного агента!", clubBuy.Name, obj.Name, obj.LastName, "0");
            obj.NameClub = clubBuy;
            Console.WriteLine("----------------");
        }


        // transfer из стороннего клуба
        public void Transf(Player obj, Club clubBuy, Club clubSell)
        {
            Console.WriteLine("----------------");
            if (clubBuy.Balanse >= obj.Price) // проверка на наличие средств у клуба.
            {
                foreach (Player item in clubBuy.team) // проверка чтобы не добавить одного и того же игрока 2 раза.
                {
                    if (obj.LastName == item.LastName)
                    {
                        Console.WriteLine("{0} {1} уже состоит в клубе!", obj.Name, obj.LastName);
                        return;
                    }
                }
                // добавление игрока в новый клуб с вычетом денег
                clubBuy.team.Add(obj);
                Console.WriteLine("{0} купил {1} {2} за {3}$ из {4}!", clubBuy.Name, obj.Name, obj.LastName, obj.Price, clubSell.Name);
                clubBuy.Balanse -= obj.Price;
                obj.NameClub = clubBuy;
            }
            else
            {
                Console.WriteLine("Недостаточно денег на трансфер!");
            }

            // удаление игрока из старого клуба с перечислением денег за трансфер
            clubSell.team.Remove(obj);
            Console.WriteLine("{0} получил от {1} {2}$!", clubSell.Name, clubBuy.Name, obj.Price);
            clubSell.Balanse += obj.Price;

            Console.WriteLine("----------------");
        }


    }
}
