using System;
using System.Collections.Generic;
using System.Text;
using Parcial_Practica.Classes.Player;

namespace Parcial_Practica.Classes.Player
{
    class Wizard : Character
    {
        private int mp;

        public int Mp { get => mp; set => mp = value; }

        public override String Taunt()
        {
            return "By the Magic";
        }

        public string CastSpell()
        {

            return "KAAAA NBUM";
        }
    }
}
