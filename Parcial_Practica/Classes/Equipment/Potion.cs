﻿using Parcial_Practica.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Practica.Classes.Equipment
{
    public class Potion : IDescribable
    {
        public string ShowInformation()
        {
            return "This is a strange potion";
        }
    }
}
