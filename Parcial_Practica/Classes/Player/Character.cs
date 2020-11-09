using Parcial_Practica.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Practica.Classes.Player
{
    public abstract class Character : IDescribable
    {
        private String name;
        private int level;
        
        private int health;
        private int power;

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Health { get => health; set => health = value; }
        public int Power { get => power; set => power = value; }


        public string ShowInformation()
        {
            return "This is a level " + level + " character";
        }
    }
}
