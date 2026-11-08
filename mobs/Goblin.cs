using System;
using System.Security.Cryptography.X509Certificates;
using Rpg;

namespace RpgSystem
{
    class Goblin : Mob
    {
        public Goblin()
        {
            this.hp = 3;
            this.defense = 3;
            this.attack = 3 ;
            this.speed =3;
        }

        public override void Atacar()
        {
            Console.WriteLine("O goblin te atacou com arranhão");
        }
    }
}
