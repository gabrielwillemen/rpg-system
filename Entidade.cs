using System;
using System.Reflection;
using Rpg;


namespace RpgSystem
{
    class Entidade {

        public Stats status {get; set;}
    
    
    public Entidade (Stats stats)
    {
        this.status = stats;
        
    }

    public void CriarProtagonista()
    {
       // Console.WriteLine("Qual seu nome?");
        //status.name = Console.ReadLine();
       // Console.WriteLine("Quantos anos tem?");
      //  status.age = int.Parse(Console.ReadLine());
        Console.WriteLine("Escolha uma classe entre as seguintes:\n Mago\n Guerreiro\n Assassino ");
        status.arquetipo = Console.ReadLine();
        switch (status.arquetipo)
            {
                case "Mago":
                this.status.attack = 10;
                this.status.defense = 5;
                this.status.hp = 5;
                this.status.speed = 5;
                break;
                case "Guerreiro":
                this.status.attack = 5;
                this.status.defense = 5;
                this.status.hp = 10;
                this.status.speed = 5;
                break;
                case "Assassino":
                this.status.attack = 10;
                this.status.defense = 5;
                this.status.hp = 5;
                this.status.speed = 5;
                break;

            }
        Console.WriteLine($"Nome: {status.name} | Idade: {status.age} | Classe: {status.arquetipo}\n|HP: {status.hp} | Ataque: {status.attack} | Defesa: {status.defense}\n | Speed: {status.speed}");
    }
    public void CriarRival()
    {
      //  Console.WriteLine("Qual o nome do seu rival?");
      //  status.name = Console.ReadLine();
       // Console.WriteLine("Quantos anos tem?");
        //status.age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Nome: {status.name} | Idade: {status.age} \n|HP: {status.hp} | Ataque: {status.attack} | Defesa: {status.defense}\n");

    }

    public void Menu()
        {
              Console.WriteLine($"Nome: {status.name} | Idade: {status.age} | Classe: {status.arquetipo}\n|HP: {status.hp} | Ataque: {status.attack} | Defesa: {status.defense}\n");
             
        }
}
}