using System;
using System.Security.Cryptography;
using Rpg;
namespace RpgSystem
{

    class Rpg
    {
        static void Main()
        {
            
    
            Entidade Protagonista = new Entidade(new Stats(10,10,10,10,"Gabriel", 20, "Mago"));
            Protagonista.CriarProtagonista();
           //Protagonista.Menu();
            
            Entidade Rival = new Entidade();
          //  Rival.CriarRival();
            //Rival.Menu();

            Goblin GoblinSelvagem = new Goblin();
            
            // Protagonista.Menu();  Isso aqui é uma função para status
        }
    }
}
