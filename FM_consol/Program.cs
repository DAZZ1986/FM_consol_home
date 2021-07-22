using System;
using System.Collections.Generic;

namespace FM_consol
{
    class Program
    {
        static void Main(string[] args)
        {
            // todo: Сделать через Вариант 2 через коллекции и сделать через Вариант 2.1 через БД.

            Club rotor = new Club();
            rotor.Name = "Rotor";
            rotor.Balanse = 1000;
            rotor.GamesCount = 32;
            Club spartak = new Club();
            spartak.Name = "Spartak";
            spartak.Balanse = 1500;
            spartak.GamesCount = 32;
            Club dinamo = new Club();
            dinamo.Name = "Dinamo";
            dinamo.Balanse = 1000;
            dinamo.GamesCount = 32;
            Club zenit = new Club();
            zenit.Name = "Zenit";
            zenit.Balanse = 2100;
            zenit.GamesCount = 32;
            Club cska = new Club();
            cska.Name = "Cska";
            cska.Balanse = 1000;
            cska.GamesCount = 32;
            Club lokomotiv = new Club();
            lokomotiv.Name = "Lokomotiv";
            lokomotiv.Balanse = 1200;
            lokomotiv.GamesCount = 32;


            Player esipov = new Player();
            esipov.Name = "Valery";
            esipov.LastName = "Esipov";
            esipov.Price = 150;
            esipov.SkillPoint = 85;
            Player veritennikov = new Player();
            veritennikov.Name = "Oleg";
            veritennikov.LastName = "Veritennikov";
            veritennikov.Price = 300;
            veritennikov.SkillPoint = 90;
            Player chichkin = new Player();
            chichkin.Name = "Andrei";
            chichkin.LastName = "CHichkin";
            chichkin.Price = 180;
            chichkin.SkillPoint = 81;
            Player aldonin = new Player();
            aldonin.Name = "evgenii";
            aldonin.LastName = "aldonin";
            aldonin.Price = 90;
            aldonin.SkillPoint = 81;
            Player smirnov = new Player();
            smirnov.Name = "vladimir";
            smirnov.LastName = "smirnov";
            smirnov.Price = 80;
            smirnov.SkillPoint = 79;
            Player zernov = new Player();
            zernov.Name = "aleksandr";
            zernov.LastName = "zernov";
            zernov.Price = 90;
            zernov.SkillPoint = 78;
            Player zubko = new Player();
            zubko.Name = "denis";
            zubko.LastName = "zubko";
            zubko.Price = 100;
            zubko.SkillPoint = 79;
            Player krivov = new Player();
            krivov.Name = "andrei";
            krivov.LastName = "krivov";
            krivov.Price = 100;
            krivov.SkillPoint = 81;
            Player mogilevskii = new Player();
            mogilevskii.Name = "pavel";
            mogilevskii.LastName = "mogilevskii";
            mogilevskii.Price = 80;
            mogilevskii.SkillPoint = 79;
            Player nidergaus = new Player();
            nidergaus.Name = "vladimir";
            nidergaus.LastName = "nidergaus";
            nidergaus.Price = 190;
            nidergaus.SkillPoint = 84;
            Player misin = new Player();
            misin.Name = "Mihail";
            misin.LastName = "Misin";
            misin.Price = 60;
            misin.SkillPoint = 75;

            Player nigmatullin = new Player();
            nigmatullin.Name = "ruslan";
            nigmatullin.LastName = "nigmatullin";
            nigmatullin.Price = 200;
            nigmatullin.SkillPoint = 81;
            Player ananko = new Player();
            ananko.Name = "dmitrii";
            ananko.LastName = "ananko";
            ananko.Price = 100;
            ananko.SkillPoint = 75;
            Player gorlukovich = new Player();
            gorlukovich.Name = "sergei";
            gorlukovich.LastName = "gorlukovich";
            gorlukovich.Price = 100;
            gorlukovich.SkillPoint = 76;
            Player evseev = new Player();
            evseev.Name = "vadim";
            evseev.LastName = "evseev";
            evseev.Price = 140;
            evseev.SkillPoint = 80;
            Player khlestov = new Player();
            khlestov.Name = "dmitrii";
            khlestov.LastName = "khlestov";
            khlestov.Price = 190;
            khlestov.SkillPoint = 78;
            Player alenichev = new Player();
            alenichev.Name = "dmitrii";
            alenichev.LastName = "alenichev";
            alenichev.Price = 200;
            alenichev.SkillPoint = 85;
            Player meleshin = new Player();
            meleshin.Name = "aleksei";
            meleshin.LastName = "meleshin";
            meleshin.Price = 100;
            meleshin.SkillPoint = 75;
            Player titov = new Player();
            titov.Name = "egor";
            titov.LastName = "titov";
            titov.Price = 300;
            titov.SkillPoint = 88;
            Player tsymbalar = new Player();
            tsymbalar.Name = "ilia";
            tsymbalar.LastName = "tsymbalar";
            tsymbalar.Price = 350;
            tsymbalar.SkillPoint = 90;
            Player buznikin = new Player();
            buznikin.Name = "maksim";
            buznikin.LastName = "buznikin";
            buznikin.Price = 100;
            buznikin.SkillPoint = 78;
            Player tikhonov = new Player();
            tikhonov.Name = "andrei";
            tikhonov.LastName = "tikhonov";
            tikhonov.Price = 300;
            tikhonov.SkillPoint = 87;

            Player ovchinnikov = new Player();
            ovchinnikov.Name = "sergei";
            ovchinnikov.LastName = "ovchinnikov";
            ovchinnikov.Price = 220;
            ovchinnikov.SkillPoint = 84;
            Player cherevchenko = new Player();
            cherevchenko.Name = "igor";
            cherevchenko.LastName = "cherevchenko";
            cherevchenko.Price = 100;
            cherevchenko.SkillPoint = 75;
            Player solomatin = new Player();
            solomatin.Name = "andrei";
            solomatin.LastName = "solomatin";
            solomatin.Price = 140;
            solomatin.SkillPoint = 79;
            Player pashinin = new Player();
            pashinin.Name = "oleg";
            pashinin.LastName = "pashinin";
            pashinin.Price = 100;
            pashinin.SkillPoint = 72;
            Player gurenko = new Player();
            gurenko.Name = "sergei";
            gurenko.LastName = "gurenko";
            gurenko.Price = 100;
            gurenko.SkillPoint = 75;
            Player maminov = new Player();
            maminov.Name = "vladimir";
            maminov.LastName = "maminov";
            maminov.Price = 150;
            maminov.SkillPoint = 78;
            Player kharlachev = new Player();
            kharlachev.Name = "evgenii";
            kharlachev.LastName = "kharlachev";
            kharlachev.Price = 100;
            kharlachev.SkillPoint = 76;
            Player loskov = new Player();
            loskov.Name = "dmitrii";
            loskov.LastName = "loskov";
            loskov.Price = 280;
            loskov.SkillPoint = 83;
            Player dzhanashiia = new Player();
            dzhanashiia.Name = "zaza";
            dzhanashiia.LastName = "dzhanashiia";
            dzhanashiia.Price = 200;
            dzhanashiia.SkillPoint = 80;
            Player borodiuk = new Player();
            borodiuk.Name = "aleksandr";
            borodiuk.LastName = "borodiuk";
            borodiuk.Price = 130;
            borodiuk.SkillPoint = 79;
            Player iablochkin = new Player();
            iablochkin.Name = "valerii";
            iablochkin.LastName = "iablochkin";
            iablochkin.Price = 100;
            iablochkin.SkillPoint = 76;

            Player novosadov = new Player();
            novosadov.Name = "andrei";
            novosadov.LastName = "novosadov";
            novosadov.Price = 100;
            novosadov.SkillPoint = 79;
            Player semak = new Player();
            semak.Name = "sergei";
            semak.LastName = "semak";
            semak.Price = 280;
            semak.SkillPoint = 85;
            Player bokov = new Player();
            bokov.Name = "maksim";
            bokov.LastName = "bokov";
            bokov.Price = 100;
            bokov.SkillPoint = 74;
            Player minko = new Player();
            minko.Name = "valerii";
            minko.LastName = "minko";
            minko.Price = 100;
            minko.SkillPoint = 73;
            Player mamchur = new Player();
            mamchur.Name = "sergei";
            mamchur.LastName = "mamchur";
            mamchur.Price = 100;
            mamchur.SkillPoint = 75;
            Player sedunov = new Player();
            sedunov.Name = "petr";
            sedunov.LastName = "sedunov";
            sedunov.Price = 110;
            sedunov.SkillPoint = 76;
            Player iakovenko = new Player();
            iakovenko.Name = "dmitrii";
            iakovenko.LastName = "iakovenko";
            iakovenko.Price = 80;
            iakovenko.SkillPoint = 72;
            Player khomukha = new Player();
            khomukha.Name = "dmitrii";
            khomukha.LastName = "khomukha";
            khomukha.Price = 100;
            khomukha.SkillPoint = 74;
            Player ulianov = new Player();
            ulianov.Name = "dmitrii";
            ulianov.LastName = "ulianov";
            ulianov.Price = 110;
            ulianov.SkillPoint = 76;
            Player semshov = new Player();
            semshov.Name = "igor";
            semshov.LastName = "semshov";
            semshov.Price = 190;
            semshov.SkillPoint = 80;
            Player shutov = new Player();
            shutov.Name = "aleksandr";
            shutov.LastName = "shutov";
            shutov.Price = 120;
            shutov.SkillPoint = 78;

            Player prikhodko = new Player();
            prikhodko.Name = "sergei";
            prikhodko.LastName = "prikhodko";
            prikhodko.Price = 150;
            prikhodko.SkillPoint = 78;
            Player davydov = new Player();
            davydov.Name = "dmitrii";
            davydov.LastName = "davydov";
            davydov.Price = 90;
            davydov.SkillPoint = 73;
            Player kulkov = new Player();
            kulkov.Name = "vasilii";
            kulkov.LastName = "kulkov";
            kulkov.Price = 80;
            kulkov.SkillPoint = 72;
            Player dymarchuk = new Player();
            dymarchuk.Name = "konstantin";
            dymarchuk.LastName = "dymarchuk";
            dymarchuk.Price = 80;
            dymarchuk.SkillPoint = 72;
            Player zazulin = new Player();
            zazulin.Name = "igor";
            zazulin.LastName = "zazulin";
            zazulin.Price = 90;
            zazulin.SkillPoint = 74;
            Player ugarov = new Player();
            ugarov.Name = "denis";
            ugarov.LastName = "ugarov";
            ugarov.Price = 80;
            ugarov.SkillPoint = 70;
            Player gorshkov = new Player();
            gorshkov.Name = "aleksandr";
            gorshkov.LastName = "gorshkov";
            gorshkov.Price = 80;
            gorshkov.SkillPoint = 73;
            Player osipov = new Player();
            osipov.Name = "sergei";
            osipov.LastName =  "osipov";
            osipov.Price = 80;
            osipov.SkillPoint = 75;
            Player zezin = new Player();
            zezin.Name = "evgenii";
            zezin.LastName = "zezin";
            zezin.Price = 70;
            zezin.SkillPoint = 70;
            Player panov = new Player();
            panov.Name = "aleksandr";
            panov.LastName = "panov";
            panov.Price = 180;
            panov.SkillPoint = 81;
            Player gerasimets = new Player();
            gerasimets.Name = "sergei";
            gerasimets.LastName = "gerasimets";
            gerasimets.Price = 120;
            gerasimets.SkillPoint = 75;

            Player smetanin = new Player();
            smetanin.Name = "andrei";
            smetanin.LastName = "smetanin";
            smetanin.Price = 150;
            smetanin.SkillPoint = 79;
            Player shtaniuk = new Player();
            shtaniuk.Name = "sergei";
            shtaniuk.LastName = "shtaniuk";
            shtaniuk.Price = 150;
            shtaniuk.SkillPoint = 78;
            Player ostrovskii = new Player();
            ostrovskii.Name = "andrei";
            ostrovskii.LastName = "ostrovskii";
            ostrovskii.Price = 160;
            ostrovskii.SkillPoint = 79;
            Player kovtun = new Player();
            kovtun.Name = "iurii";
            kovtun.LastName = "kovtun";
            kovtun.Price = 160;
            kovtun.SkillPoint = 79;
            Player tochilin = new Player();
            tochilin.Name = "aleksandr";
            tochilin.LastName = "tochilin";
            tochilin.Price = 150;
            tochilin.SkillPoint = 79;
            Player skokov = new Player();
            skokov.Name = "vladimir";
            skokov.LastName = "skokov";
            skokov.Price = 100;
            skokov.SkillPoint = 75;
            Player grishin = new Player();
            grishin.Name = "sergei";
            grishin.LastName = "grishin";
            grishin.Price = 100;
            grishin.SkillPoint = 74;
            Player kulchii = new Player();
            kulchii.Name = "aleksandr";
            kulchii.LastName = "kulchii";
            kulchii.Price = 160;
            kulchii.SkillPoint = 79;
            Player gusev = new Player();
            gusev.Name = "rolan";
            gusev.LastName = "gusev";
            gusev.Price = 210;
            gusev.SkillPoint = 81;
            Player romashchenko = new Player();
            romashchenko.Name = "maksim";
            romashchenko.LastName = "romashchenko";
            romashchenko.Price = 180;
            romashchenko.SkillPoint = 80;
            Player terekhin = new Player();
            terekhin.Name = "oleg";
            terekhin.LastName = "terekhin";
            terekhin.Price = 110;
            terekhin.SkillPoint = 78;








            // Сделали тестовые трансферы.
            Transfer change = new Transfer();
            change.Transf(chichkin, rotor);
            change.Transf(veritennikov, spartak);
            change.Transf(veritennikov, rotor, spartak);


            //  добавить игроков в клубы
            change.Transf(aldonin, rotor);
            change.Transf(veritennikov, rotor);
            change.Transf(esipov, rotor);
            change.Transf(smirnov, rotor);
            change.Transf(zernov, rotor);
            change.Transf(zubko, rotor);
            change.Transf(krivov, rotor);
            change.Transf(mogilevskii, rotor);
            change.Transf(nidergaus, rotor);
            change.Transf(misin, rotor);

            change.Transf(nigmatullin, spartak);
            change.Transf(ananko, spartak);
            change.Transf(gorlukovich, spartak);
            change.Transf(evseev, spartak);
            change.Transf(khlestov, spartak);
            change.Transf(alenichev, spartak);
            change.Transf(meleshin, spartak);
            change.Transf(titov, spartak);
            change.Transf(tsymbalar, spartak);
            change.Transf(buznikin, spartak);
            change.Transf(tikhonov, spartak);

            change.Transf(ovchinnikov, lokomotiv);
            change.Transf(cherevchenko, lokomotiv);
            change.Transf(solomatin, lokomotiv);
            change.Transf(pashinin, lokomotiv);
            change.Transf(gurenko, lokomotiv);
            change.Transf(maminov, lokomotiv);
            change.Transf(kharlachev, lokomotiv);
            change.Transf(loskov, lokomotiv);
            change.Transf(dzhanashiia, lokomotiv);
            change.Transf(borodiuk, lokomotiv);
            change.Transf(iablochkin, lokomotiv);

            change.Transf(novosadov, cska);
            change.Transf(semak, cska);
            change.Transf(bokov, cska);
            change.Transf(minko, cska);
            change.Transf(mamchur, cska);
            change.Transf(sedunov, cska);
            change.Transf(iakovenko, cska);
            change.Transf(khomukha, cska);
            change.Transf(ulianov, cska);
            change.Transf(semshov, cska);
            change.Transf(shutov, cska);

            change.Transf(prikhodko, zenit);
            change.Transf(davydov, zenit);
            change.Transf(kulkov, zenit);
            change.Transf(dymarchuk, zenit);
            change.Transf(zazulin, zenit);
            change.Transf(ugarov, zenit);
            change.Transf(gorshkov, zenit);
            change.Transf(osipov, zenit);
            change.Transf(zezin, zenit);
            change.Transf(panov, zenit);
            change.Transf(gerasimets, zenit);

            change.Transf(smetanin, dinamo);
            change.Transf(shtaniuk, dinamo);
            change.Transf(ostrovskii, dinamo);
            change.Transf(kovtun, dinamo);
            change.Transf(tochilin, dinamo);
            change.Transf(skokov, dinamo);
            change.Transf(grishin, dinamo);
            change.Transf(kulchii, dinamo);
            change.Transf(gusev, dinamo);
            change.Transf(romashchenko, dinamo);
            change.Transf(terekhin, dinamo);


            // Создали массив с клубами РПЛ.
            List<Club> RPL = new List<Club>();
            RPL.Add(rotor);
            RPL.Add(spartak);
            RPL.Add(lokomotiv);
            RPL.Add(cska);
            RPL.Add(zenit);
            RPL.Add(dinamo);


            // Считаем ClubPower для всех клубов РПЛ.
            foreach (Club item in RPL)
            {
                item.ClubPowerCounter(item.team);
            }
            Console.WriteLine("Сила игроков клуба {0} = {1}", rotor.Name, rotor.ClubPower);
            Console.WriteLine("Сила игроков клуба {0} = {1}", spartak.Name, spartak.ClubPower);
            Console.WriteLine("Сила игроков клуба {0} = {1}", lokomotiv.Name, lokomotiv.ClubPower);
            Console.WriteLine("Сила игроков клуба {0} = {1}", cska.Name, cska.ClubPower);
            Console.WriteLine("Сила игроков клуба {0} = {1}", zenit.Name, zenit.ClubPower);
            Console.WriteLine("Сила игроков клуба {0} = {1}", dinamo.Name, dinamo.ClubPower);


            // Делаем матчи
            Calendar matches = new Calendar();
            matches.MatchMetod(RPL);


            Console.WriteLine("----------------");


            // Табличный Вывод кол-ва очков клуба
            Console.WriteLine("Таблица РПЛ");
            ScorePointTable table = new ScorePointTable();
            table.DrawTable(RPL);


            Console.WriteLine("----------------");



            /*
            // Вывели составы команд.
            Console.WriteLine("----------------");
            spartak.ShowPlayerList();
            Console.WriteLine("----------------");
            rotor.ShowPlayerList();
            Console.WriteLine("----------------");
            dinamo.ShowPlayerList();
            */















            /*
Вариант 1. Ну если тебе нужно просто указать клуб у игрока, то создаёшь ему свойства типа Club и при
 создании игрока передашь ему это свойство. Но вообще эт не оч. Потому что у тебя клубы принимают
игроков, а не игроки записываются в клубы.
Вариант 2. То есть у клуба должен быть метод добавить игрока и исключить игрока. Который будет 
добавлять их в коллекцию игроков ну и при добавлении у игрока должно свойство Club изменять.
Вариант 2.1 Через БД.
Вариант 3. Про трансфер... Я бы трансфер вообще отдельной сущностью сделал. Потому что это по сути 
уже 3 сторона, которая будет выполнять контракт.

             */
        }
    }
}
