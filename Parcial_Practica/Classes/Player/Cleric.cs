using System;
using System.Collections.Generic;
using System.Text;
using Parcial_Practica.Classes.Player;

namespace Parcial_Practica.Classes
{
    public abstract class Cleric : Character
    {
        public Cleric()
        {
            Health = 8000;
            Power = 20;
            Level = 1;
        }
    }
}
