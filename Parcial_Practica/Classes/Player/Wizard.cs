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

        public Wizard()
        {
            Health = 5000;
            Power = 30;
            Level = 1;
        }

    }
}
