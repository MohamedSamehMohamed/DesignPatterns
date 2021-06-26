using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TheStrategyPattern.ActionAdventureGame
{
    abstract class Character
    {
        private IWeaponBehavior weaponBehavior;
        public void Fight()
        {
            weaponBehavior.UseWeapon(); 
        }
        public void setWeapon(IWeaponBehavior weaponBehavior)
        {
            this.weaponBehavior = weaponBehavior; 
        }

    }
}
