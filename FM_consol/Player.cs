using System;
using System.Collections.Generic;
using System.Text;

namespace FM_consol
{
    public class Player
    {
        string name;
        public string Name
        {
            set{name = value;}
            get{return name;}
        }

        string lastName;
        public string LastName
        {
            set{lastName = value;}
            get {return lastName;}
        }

        int price;
        public int Price
        {
            set{price = value;}
            get {return price;}
        }

        int skillPoint;
        public int SkillPoint
        {
            set { skillPoint = value; }
            get { return skillPoint; }
        }

        Club nameClub;
        public Club NameClub
        {
            set { nameClub = value; }
            get { return nameClub; }
        }


    }
}