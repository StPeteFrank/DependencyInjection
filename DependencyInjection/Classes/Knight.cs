using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Classes
{
    public class Knight : Warrior 
    {
        public Knight() : base(new Sword())
        {

        }
    }


}
