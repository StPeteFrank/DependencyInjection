using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Classes
{
    public class Wizard : Warrior
    {
        public Wizard() : base(new FireBall())
        {

        }
    }
}
