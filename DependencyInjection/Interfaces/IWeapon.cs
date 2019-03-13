using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Interfaces
{
    public interface IWeapon
    {
        void DoDamage();
    }
    public class Sword : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Swing Sword");
        }
    }

    public class BowAndArrow : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Shooting Arrow");
        }
    }

    public class FireBall : IWeapon
    {
        public void DoDamage()
        {
            Console.WriteLine("Shooting FireBall");
        }
    }
}
