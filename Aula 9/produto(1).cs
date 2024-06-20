using System;

public struct Produto {
    public string Nome;
    public int Codigo;
    public int Quantidade;
    public float Preco;
}

class Program {
    static void Main() {
        Produto[] loja = new Produto[3];
        int opcao = 0;
        float x0 = 0, x1 = 0, x2 = 0; 
        int y0 = 0, y1 = 0, y2 = 0; 
        float precoTotal = 0;
    

        while (opcao != 5) {
            Console.WriteLine("1) Primeiro Produto ");
            Console.WriteLine("2) Segundo Produto ");
            Console.WriteLine("3) Terceiro Produto ");
            Console.WriteLine("4) Calcular o preco total em estoque");
            Console.WriteLine("5) Fechar Programa");
            Console.Write("Escolha uma das opções: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:    
                    Console.WriteLine("Forneça as informações do primeiro produto: ");
                    Console.Write("Nome: ");
                    loja[0].Nome = Console.ReadLine();

                    Console.Write("Código: ");
                    loja[0].Codigo = int.Parse(Console.ReadLine());

                    Console.Write("Preço: ");
                    loja[0].Preco = float.Parse(Console.ReadLine());
                    x0 = loja[0].Preco;
                    
                    Console.Write("Quantidade: ");
                    loja[0].Quantidade = int.Parse(Console.ReadLine());
                    y0 = loja[0].Quantidade;
                    break;

                case 2:    
                    Console.WriteLine("Forneça as informações do segundo produto: ");
                    Console.Write("Nome: ");
                    loja[1].Nome = Console.ReadLine();

                    Console.Write("Código: ");
                    loja[1].Codigo = int.Parse(Console.ReadLine());

                    Console.Write("Preço: ");
                    loja[1].Preco = float.Parse(Console.ReadLine());
                    x1 = loja[1].Preco;

                    Console.Write("Quantidade: ");
                    loja[1].Quantidade = int.Parse(Console.ReadLine());
                    y1 = loja[1].Quantidade;
                    break;

                case 3:    
                    Console.WriteLine("Forneça as informações do terceiro produto: ");
                    Console.Write("Nome: ");
                    loja[2].Nome = Console.ReadLine();

                    Console.Write("Código: ");
                    loja[2].Codigo = int.Parse(Console.ReadLine());

                    Console.Write("Preço: ");
                    loja[2].Preco = float.Parse(Console.ReadLine());
                    x2 = loja[2].Preco;

                    Console.Write("Quantidade: ");
                    loja[2].Quantidade = int.Parse(Console.ReadLine());
                    y2 = loja[2].Quantidade;
                    break;

                case 4:
                float soma0, soma1, soma2;
                soma0 = x0 * y0;
                soma1 = x1 * y1;
                soma2 = x2 * y2;
                precoTotal = soma0 + soma1 + soma2;
                
               Console.WriteLine($"O valor total em estoque é de {precoTotal} reais");
                    break;

                case 5:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("ERRO - OPÇÃO INVÁLIDA");
                    break;
            }
        }
    }
}