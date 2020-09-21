using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Characters
    {
        public int attack;
        public int defend;
        public int level;
        public int health;
        public int mana;
        public int gold;

        public Characters(int charAttack, int charDefend, int charLevel, int charHealth, int charMana, int charGold)
        {
            attack = charAttack;
            defend = charDefend;
            level = charLevel;
            health = charHealth;
            mana = charMana;
            gold = charGold;
        }


    }
}
