using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Classes
{
    public class Archer : Warrior
    {
          public Archer() : base(new BowAndArrow())
        {

        }
    }
}
