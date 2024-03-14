using System;
class HelloWorld {
  static void Main() {
      
    Console.WriteLine("Bem vindo ao RPG DS!");
    Console.WriteLine("Vamos escolher seu personagem!");
    Console.Write("Digite o número da classe (1-Guerreiro, 2-Mago/a ou 3-Arqueiro): ");
    int classe = int.Parse (Console.ReadLine());
    
    switch (classe) {
        
    case 1:
    Console.WriteLine("Parabéns você é um Guerreiro agora!");
    Console.WriteLine("Suas habilidades são: Ataque Pesado e Defesa Total");
     break;
     
    case 2:
    Console.WriteLine("Parabéns você é um Mago agora!");
    Console.WriteLine("Suas habilidades são: Bola de Fogo e Escudo de Gelo");
     break;
     
    case 3:
    Console.WriteLine("Parabéns você é um Arqueiro agora!");
    Console.WriteLine("Suas habilidades são: Flecha Precisa e Disparo Triplo");
     break;
     
    default:
    Console.WriteLine("ERR0 - Escolha uma classe válida!");
     break;
    }
  }
}