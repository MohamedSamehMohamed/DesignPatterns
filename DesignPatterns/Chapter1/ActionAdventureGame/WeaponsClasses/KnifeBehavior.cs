using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TheStrategyPattern.ActionAdventureGame.WeaponsClasses
{
    class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("This Is Knife");
        }
    }
}
