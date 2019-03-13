using DependencyInjection.Classes;
using System;
using System.Collections.Generic;

namespace DependencyInjection
{
    class Program
    {

        // Code up an army that has knights, archers, and wizards
        // Knights swing swords
        // Archers shoot arrows
        // Wizards shoot firballs
        // Store entire srmy in a data structure so I can manipulate it


        static void Main(string[] args)
        {

            var lancelot = new Knight();
          
            var legolas = new Archer();
           
            var merlin = new Wizard();
            
             var army = new List<Warrior>();
            army.Add(lancelot);
            army.Add(legolas);
            army.Add(merlin);

            army.ForEach(fighter => fighter.Attack());

            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
