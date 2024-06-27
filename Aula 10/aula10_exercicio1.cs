using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
    
    List <string> nomes = new List<string>();
    List <string> nomesOrdem = new List<string>();
    
    Console.WriteLine("Quanto nomes serão inseridos?");
    uint quant = uint.Parse(Console.ReadLine());
    Console.Write("Insira um nome: ");
    
    for(int i=0; i<quant; i++) {
        
        if(i==0){
        } else if(i!=quant-1){
            Console.Write("Insira um outro nome: ");
        } else {
            Console.Write("Insira o último nome: ");
        }
        string anem = Console.ReadLine();
        nomes.Add(anem);
        
    }
    
    int tamanho, tamanhoant = 0;
    
    while(nomes.Count != 0) {
        
        foreach(string nome in nomes) {
        
        tamanho = nome.Length;
        if(tamanho < tamanhoant){
            nomesOrdem.Insert(nome)
        }
        tamanhoant = tamanho;
        nomes.Remove(nome);
        
        }
    }
    
    
    while(nomes.Count != 0) {
        
        foreach(string nome in nomes) {
        
        tamanho = nome.Length;
        if(tamanho != tamanhoant){
        Console.Write(nome);
        }
        tamanhoant = tamanho;
        nomes.Remove(nome);
        
        }
        Console.WriteLine("");
}
}
}