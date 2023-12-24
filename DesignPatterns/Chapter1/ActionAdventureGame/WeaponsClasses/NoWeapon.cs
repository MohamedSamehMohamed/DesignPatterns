using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TheStrategyPattern.ActionAdventureGame.WeaponsClasses
{
    class NoWeapon : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("I have no Weapon Yet"); 
        }
    }
}
