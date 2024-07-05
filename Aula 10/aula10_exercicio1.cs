using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
    
    List <string> nomes = new List <string> ();
     List<List<string>> ordenado = new List<List<string>>(15);
    
    Console.Write("Digite a quantidade de nomes que serão inseridos na lista: ");
    int quantidade = int.Parse(Console.ReadLine());
    
    for(int i=0; i < quantidade; i++) {
        
    Console.Write($"Insira o nome {i+1}: ");
    string name = Console.ReadLine();
    nomes.Add(name);
    }

        for (int i = 0; i < 15; i++) {
            ordenado.Add(new List<string>());
        }

        foreach (var nome in nomes) {
            int tamanho = nome.Length;
            if (tamanho < 15) {
                ordenado[tamanho].Add(nome);
            }
        }

        for (int i = 0; i < ordenado.Count; i++) {
            if (ordenado[i].Count > 0) {
                foreach (var nome in ordenado[i]) {
                    Console.WriteLine(nome);
                }
            }
        }
    }
}