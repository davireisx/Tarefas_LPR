using System;

class Program {
    static void Main() {
        
    int[,] distancias = {
            {0, 524, 521, 882},
            {524, 0, 434, 586},
            {521, 434, 0, 429},
            {882, 586, 429, 0}
             };

    string[] cidades = {"Vitória", "Belo Horizonte", "Rio de Janeiro", "São Paulo"};

        while (true) {
            Console.WriteLine("Escolha um destino e uma origem de acordo com os seguintes números: ");
            Console.WriteLine("1. Vitória");
            Console.WriteLine("2. Belo Horizonte");
            Console.WriteLine("3. Rio de Janeiro");
            Console.WriteLine("4. São Paulo");

            Console.Write("Insira o número da cidade de origem: ");
            int origem = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Insira o número da cidade de destino: ");
            int destino = int.Parse(Console.ReadLine()) - 1;

    
            if (origem == destino) {
                Console.WriteLine("São a mesma cidade! Saindo...");
                break;
            }

            
            if (origem < 0 || origem >= cidades.Length || destino < 0 || destino >= cidades.Length) {
                Console.WriteLine("Uma ou ambas as cidades não foram encontradas. Tente novamente.");
                continue;
            }

            
            int distancia = distancias[origem, destino];
            Console.WriteLine($"A distância entre {cidades[origem]} e {cidades[destino]} é de {distancia} km.");
        }
    }
}
