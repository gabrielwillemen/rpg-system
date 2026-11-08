using System;
using Rpg;

namespace RpgSystem
{
    abstract class Mob
    {
        public double hp {get; set;}
        public double defense {get; set;}
        public double attack {get;set;}
        public double speed {get; set;}
        public double specialattack {get; set;}
        public double specialdefense {get;set;}

    

        public Mob()
        {
            this.hp = hp;
            this.defense = defense;
            this.attack = attack;
            this.speed = speed;
            this.specialattack = specialattack;
            this.specialdefense = specialdefense;
        }

    public abstract void Atacar();
        
            
        
    }
}