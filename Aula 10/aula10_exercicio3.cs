using System.Collections.Generic;
using System;

class HelloWorld {
    static void Main() {
        Dictionary<string, int> infoPessoa = new Dictionary<string, int> {
            { "Davi", 17 },
            { "DosSantos", 2 },
            { "Vinicin", 100 },
            { "Matue", 30 }
        };

    
        int somaIdades = 0;
        foreach (var pessoa in infoPessoa) {
            somaIdades += pessoa.Value;
        }

       
        double media = somaIdades / (double)infoPessoa.Count;
        Console.WriteLine("Média das idades: " + media);

       
        Console.WriteLine("Nomes das pessoas com idade acima da média:");
        foreach (var pessoa in infoPessoa) {
            if (pessoa.Value > media) {
                Console.WriteLine(pessoa.Key);
            }
        }

   
        string pessoaMaisVelha = null;
        string pessoaMaisNova = null;
        int maiorIdade = int.MinValue;
        int menorIdade = int.MaxValue;

        foreach (var pessoa in infoPessoa) {
            if (pessoa.Value > maiorIdade) {
                maiorIdade = pessoa.Value;
                pessoaMaisVelha = pessoa.Key;
            }
            if (pessoa.Value < menorIdade) {
                menorIdade = pessoa.Value;
                pessoaMaisNova = pessoa.Key;
            }
        }

        Console.WriteLine($"Pessoa mais velha: {pessoaMaisVelha} com {maiorIdade} anos");
        Console.WriteLine($"Pessoa mais nova: {pessoaMaisNova} com {menorIdade} anos");

      
        Console.WriteLine("Digite um valor inteiro correspondente a uma idade para remover do dicionário de idades: ");
        int valor = int.Parse(Console.ReadLine());

        List<string> pessoasRemovidas = new List<string>();
        foreach (var pessoa in infoPessoa) {
            if (pessoa.Value == valor) {
                pessoasRemovidas.Add(pessoa.Key);
            }
        }
        
        foreach (string nome in pessoasRemovidas) {
            infoPessoa.Remove(nome);
            Console.WriteLine(nome);
        }

        Console.WriteLine("O dicionário foi atualizado:");
        foreach (var pessoa in infoPessoa) {
            Console.WriteLine(pessoa.Key + ": " + pessoa.Value);
        }
    }
}
