using System;
using System.Dynamic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Rpg;
namespace RpgSystem
{

    class Rpg
    {
        static void Main()
        {
            
    
            Entidade Protagonista = new Entidade(new Stats(10,10,10,10,"Gabriel", 20, "Mago"));
            Protagonista.CriarProtagonista(); 

             bool GameON = true; 
            

            while (GameON)
            {

                Console.WriteLine("O que você quer fazer?");
                string Action = Console.ReadLine();
                switch (Action) {
                    case "Lutar":
                    Console.WriteLine("Bem vindo ao duelo");
                    
                    break;
                    case "Encerrar": 
                     GameON = false;
                    break;
            }
           
        }
    }
}
}
