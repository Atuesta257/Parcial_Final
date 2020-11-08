using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Practica.Classes.Player
{
    public class Knight : Character
    {

        public override String Taunt()
        {
            return "By my Lord";
        }


        public override String ShowCharacter()
        {
            return "Remember my name " + Name.ToUpper() + " and My Power " + Level;
        }

    }
}
