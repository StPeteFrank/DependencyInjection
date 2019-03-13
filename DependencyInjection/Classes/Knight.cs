using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Classes
{
    public class Knight : Warrior, IAttacker
    {
        public void Attack()
        {
            throw new NotImplementedException();
        }
    }


}
