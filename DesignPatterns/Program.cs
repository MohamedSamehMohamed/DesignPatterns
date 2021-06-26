using System;
using DesignPatterns.TheStrategyPattern.ActionAdventureGame.Characters;
using DesignPatterns.TheStrategyPattern.ActionAdventureGame.WeaponsClasses;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            King obj = new King();
            obj.Fight();
            obj.setWeapon(new SwordBehavior());
            obj.Fight(); 
        }
    }
}
