using System;
using System.Diagnostics;
using System.Numerics;

namespace Rpg
{
    
   class Stats 
    {
    
        public double hp {get; set;}
        public double attack {get; set;}
        public double defense {get; set;}
        public double speed {get; set;}
        public string name {get; set;}
        public int age {get; set;}
        public string arquetipo {get; set;}

        public Stats(double hp, double attack, double defense, double speed, string name, int age, string arquetipo)
        {
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.speed = speed;
            this.name = name;
            this.age = age;
            this.arquetipo = arquetipo;
        }
    }
}