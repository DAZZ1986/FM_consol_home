using System;
using System.Collections.Generic;
using System.Text;

namespace FM_consol
{
    class Transfer
    {



        // transfer
        public void Transf(Player obj, Club clubBuy, Club clubSell=null)
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
                clubBuy.team.Add(obj);
                Console.WriteLine("{0} купил {1} {2} за {3}$!", clubBuy.Name, obj.Name, obj.LastName, obj.Price);
                clubBuy.Balanse -= obj.Price;
            }
            else
            {
                Console.WriteLine("Недостаточно денег на трансфер!");
            }
            


            if (clubSell != null)
            {
                clubSell.team.Remove(obj);
                Console.WriteLine("{0} {1} продан из {2} за {3}$!", obj.Name, obj.LastName, clubSell.Name, obj.Price);
                clubSell.Balanse += obj.Price;
            } else 
            {
                Console.WriteLine("{0} приобрел {1} {2} как свободного агента.", clubBuy.Name, obj.Name, obj.LastName);
            }

            Console.WriteLine("----------------");
        }


    }
}
