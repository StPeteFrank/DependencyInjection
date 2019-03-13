using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public abstract class Warrior        //Abstract Parent Class
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public string Rank { get; set; }



    }
}
