using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public abstract class Warrior : IAttacker        //Abstract Parent Class with interface
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public string Rank { get; set; }

        public IWeapon Weapon { get; set; }  // Our class is now dependent on IWeapon

        public Warrior(IWeapon weapon)
        {
            this.Weapon = weapon;
        }

        public void Attack()
        {
            this.Weapon.DoDamage();

        }
    }
}
