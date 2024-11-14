using System;


public struct Produto{
    public string Nome;
    public int Codigo;
    public float Preco;
    public int Quantidade;
}

class HelloWorld {
  static void Main() {
      
    Produto[] mercadoria = new Produto [3];
    
    while(true) {
    Console.WriteLine ("Digite o número do produto que deseja: ");
    Console.WriteLine ("1)Produto 1 ");
    Console.WriteLine ("2)Produto 2 ");
    Console.WriteLine ("3)Produto 3 ");
    int escolha = int.Parse(Console.ReadLine());
    
    switch(escolha) {
        
    case 1:
    Console.WriteLine("Digite as informações do produto 1 abaixo: ");
    Console.Write("Nome: ");
      mercadoria[0].Nome = Console.ReadLine();
    Console.Write("Codigo: ");
      mercadoria[0].Codigo = int.Parse(Console.ReadLine());
    Console.Write("Preco: ");
      mercadoria[0].Preco = int.Parse(Console.ReadLine());
    Console.Write("Quantidade: ");
      mercadoria[0].Quantidade = int.Parse(Console.ReadLine());
      
     float valor1 = mercadoria[0].Quantidade*mercadoria[0].Preco;
    
    Console.WriteLine($"O nome do produto 1 é {mercadoria[0].Nome}, seu código é {mercadoria[0].Codigo} e seu valor total é {valor1}");
    break;
    
    case 2:
    Console.WriteLine("Digite as informações do produto 2 abaixo: ");
    Console.Write("Nome: ");
      mercadoria[1].Nome = Console.ReadLine();
    Console.Write("Codigo: ");
      mercadoria[1].Codigo = int.Parse(Console.ReadLine());
    Console.Write("Preco: ");
      mercadoria[1].Preco = int.Parse(Console.ReadLine());
    Console.Write("Quantidade: ");
      mercadoria[1].Quantidade = int.Parse(Console.ReadLine());
      
    float valor2 = mercadoria[1].Quantidade*mercadoria[1].Preco;
    Console.WriteLine($"O nome do produto 2 é {mercadoria[1].Nome}, seu código é {mercadoria[1].Codigo} e seu valor total é {valor2}");
    break;

    case 3: 
    Console.WriteLine("Digite as informações do produto 3 abaixo: ");
    
    Console.Write("Nome: ");
    mercadoria[2].Nome = Console.ReadLine();
    
    Console.Write("Codigo: ");
    mercadoria[2].Codigo = int.Parse(Console.ReadLine());
    
    Console.Write("Preco: ");
    mercadoria[2].Preco = int.Parse(Console.ReadLine());
    
    Console.Write("Quantidade: ");
    mercadoria[2].Quantidade = int.Parse(Console.ReadLine());
    
    float valor3 = mercadoria[2].Quantidade * mercadoria[2].Preco;

    Console.WriteLine($"O nome do produto 3 é {mercadoria[2].Nome}, seu código é {mercadoria[2].Codigo} e seu valor total é {valor3}");
    break;
    
    default:
    Console.WriteLine("ERR0 - Digite um valor válido!");
    break;
    }
    }
}
}